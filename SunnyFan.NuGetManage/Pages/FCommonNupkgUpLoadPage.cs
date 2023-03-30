using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CliWrap;
using CliWrap.Buffered;
using NuGet.Configuration;
using Sunny.UI;
using SunnyFan.NuGetManage.Models;
using SunnyFan.NuGetManage.Properties;
using Sunny.UI.Win32;


namespace SunnyFan.NuGetManage.Pages
{
    public partial class FCommonNupkgUpLoadPage : UIPage
    {

        private List<PackSourceModel> _packs;

        private List<string> _rList;

        private List<FileInfoModel> _fileInfos;

        public FCommonNupkgUpLoadPage()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            DataGridViewColumn dataGridViewColumn = uidgv.AddColumn("FullName", "FullName");
            dataGridViewColumn.Visible = false;
            uidgv.SetRowHeight(31); //设置行高29
            uidgv.AddColumn("序号", "Index", 40)
                .SuperGridIndexColumn();
            uidgv.AddColumn("名称", "Name", alignment: DataGridViewContentAlignment.MiddleLeft);

            uidgv.AddColumn("操作", "Button1", 40)
                .SuperGridButtonColumn() //设置固定按钮，忽略这一列是什么值   .AddSymbolButton("查看", UIColor.Blue, UIColor.White, 61452)
                .AddSymbolButton("上传", UIColor.Green, UIColor.White, 57456);


            uidgv.Init();
        }

        private void InitControl()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.LastSelectedFolder))
            {
                var settings = NuGet.Configuration.Settings.LoadDefaultSettings(null);
                uitxtPath.Text = SettingsUtility.GetGlobalPackagesFolder(settings);
            }
            else
            {
                uitxtPath.Text = Properties.Settings.Default.LastSelectedFolder;
            }
        }

        private void BindRadio()
        {
            uirbnSelectSource.Clear();
            _rList = new List<string>();
            foreach (var pack in _packs)
            {
                _rList.Add(pack.Title);
                uirbnSelectSource.Items.Add(pack.Title);
                uirbnSelectSource.SelectedIndex = 0;
            }
        }

        private void InitPacks()
        {
            _packs = new PackSourceModel().Load();
        }

        private void uiTextBox1_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.SelectedPath = Properties.Settings.Default.LastSelectedFolder;
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                Properties.Settings.Default.LastSelectedFolder = dilog.SelectedPath;
                Properties.Settings.Default.Save();
                uitxtPath.Text = dilog.SelectedPath;
            }
        }

        private void uibtnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uitxtPath.Text))
            {
                ShowErrorTip("请选择文件路径！");
                return;
            }
            ShowWaitForm();
            DirectoryInfo dir = new DirectoryInfo(uitxtPath.Text);

            SetWaitFormDescription("系统正在处理中，请稍候...");
            FileInfo[] fileInfos = dir.GetFiles("*.nupkg", SearchOption.AllDirectories);
            SetWaitFormDescription("系统正在处理中，请稍候...");
            if (fileInfos.Length > 0)
            {
                _fileInfos = new List<FileInfoModel>();

                SetWaitFormDescription("系统正在处理中，请稍候...");
                foreach (var fileInfo in fileInfos)
                {
                    _fileInfos.Add(new FileInfoModel()
                    {
                        FullName = fileInfo.FullName,
                        Name = fileInfo.Name
                    });

                }

                SetWaitFormDescription("系统正在处理中，请稍候...");
                uidgv.DataSource = _fileInfos;
                uidgv.Refresh();
                HideWaitForm();
            }
        }

        private void uibtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uitxtSearch.Text))
            {
                uidgv.DataSource = _fileInfos;
                uidgv.Refresh();
                return;
            }
            ShowWaitForm();
            uidgv.DataSource = _fileInfos.Where(a => a.Name.ToLower().Contains(uitxtSearch.Text.ToLower())).ToList();
            uidgv.Refresh();
            HideWaitForm();
        }

        private void uidgv_CellMouseButtonClick(object sender, DataGridViewCellMouseButtonClickEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string fullName = this.uidgv.Rows[e.RowIndex].Cells[0].Value.ToString();

                switch (e.ButtonText)
                {
                    case "上传":
                        upload(fullName);
                        break;
                }
            }
        }

        private void upload(string fullName)
        {

            if (uirbnSelectSource.SelectedIndex < 0)
            {
                ShowWarningTip("请选择包源");
                return;
            }

            string pName = _rList[uirbnSelectSource.SelectedIndex];

            PackSourceModel packSource = _packs.FirstOrDefault(a => a.Title == pName);

            ShowWaitForm();
            try
            {
                BufferedCommandResult pushBufferedCommandResult = Task.Run(async () =>
                {
                    return await Cli.Wrap("dotnet")
                        .WithArguments(
                            args => args
                                .Add("nuget")
                                .Add("push")
                                .Add(fullName)
                                .Add("-s")
                                .Add(packSource.Source)
                                .Add("--skip-duplicate")
                                .Add("-k")
                                .Add(packSource.APIKey)
                        ).ExecuteBufferedAsync(Encoding.UTF8);
                }).Result;

                string error = pushBufferedCommandResult.StandardError;
                string output = pushBufferedCommandResult.StandardOutput;
                if (string.IsNullOrEmpty(error))
                {
                    HideWaitForm();
                    ShowInfoDialog(UILocalize.InfoTitle, output, this.Style, false);
                }
                else
                {
                    HideWaitForm();
                    ShowInfoDialog(UILocalize.InfoTitle, error, this.Style, false);
                }
            }
            catch (Exception e)
            {
                HideWaitForm();
                ShowErrorDialog(UILocalize.ErrorTitle, e.InnerException.Message, this.Style, false);
            }
        }

        private void FCommonNupkgUpLoadPage_Initialize(object sender, EventArgs e)
        {
            InitPacks();
            BindRadio();
            InitControl();
           
        }
    }
}
