using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CliWrap;
using CliWrap.Buffered;

using NuGet.Common;
using NuGet.Configuration;
using Sunny.UI;
using Sunny.UI.Win32;
using SunnyFan.NuGetManage.Models;


namespace SunnyFan.NuGetManage.Pages
{
    public partial class FSlnPackUploadPage : UIPage
    {
        private List<PackSourceModel> _packs;

        private List<string> _rList;

        private List<FileInfoModel> _fileInfos;

        public FSlnPackUploadPage()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            DataGridViewColumn dataGridViewColumn = uidgv2.AddColumn("FullName", "FullName");
            dataGridViewColumn.Visible = false;
            uidgv2.SetRowHeight(31); //设置行高29
            uidgv2.AddColumn("序号", "Index", 40)
                .SuperGridIndexColumn();
            uidgv2.AddColumn("名称", "Name", alignment: DataGridViewContentAlignment.MiddleLeft);

            uidgv2.AddColumn("操作", "Button1", 40)
                .SuperGridButtonColumn() //设置固定按钮，忽略这一列是什么值   .AddSymbolButton("查看", UIColor.Blue, UIColor.White, 61452)
                .AddSymbolButton("上传", UIColor.Green, UIColor.White, 57456);


            uidgv2.Init();
        }

        private void InitControl()
        {
            //var settings = Settings.LoadDefaultSettings(null);

            //var settings = Settings.LoadDefaultSettings(null);

            uitxtPath.Text = Properties.Settings.Default.LastSelectedFolder1;
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
            FileInfo[] fileInfos = dir.GetFiles("*.csproj", SearchOption.AllDirectories);
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
                uidgv2.DataSource = _fileInfos;
                uidgv2.Refresh();
                HideWaitForm();
            }
        }

        private void uibtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uitxtSearch.Text))
            {
                uidgv2.DataSource = _fileInfos;
                uidgv2.Refresh();
                return;

            }
            ShowWaitForm();
            uidgv2.DataSource = _fileInfos.Where(a => a.Name.ToLower().Contains(uitxtSearch.Text.ToLower())).ToList();
            uidgv2.Refresh();
            HideWaitForm();
        }

        private void uidgv_CellMouseButtonClick(object sender, DataGridViewCellMouseButtonClickEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string fullName = this.uidgv2.Rows[e.RowIndex].Cells[0].Value.ToString();

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

            string tempPath = AppDomain.CurrentDomain.BaseDirectory + "\\nupkgs";

            DirectoryInfo dir = new DirectoryInfo(tempPath);
            if (dir.Exists)
            {
                dir.Delete(true);
            }

            ShowWaitForm();
            try
            {
                BufferedCommandResult commandResult = Task.Run(async () =>
                {
                    return await Cli.Wrap("dotnet")
                        .WithArguments(
                            args => args
                                .Add("pack")
                                .Add(fullName)
                                //.Add("--no-build")
                                .Add("--output")
                                .Add("nupkgs")
                        ).ExecuteBufferedAsync(Encoding.UTF8);
                }).Result;

                FileInfo[] fileInfos = dir.GetFiles("*.nupkg", SearchOption.AllDirectories);
                if (fileInfos.Length == 0)
                {
                    HideWaitForm();
                    ShowErrorDialog(UILocalize.ErrorTitle, commandResult.StandardError, this.Style, false);
                    return;
                }

                BufferedCommandResult pushBufferedCommandResult = Task.Run(async () =>
                {
                    return await Cli.Wrap("dotnet")
                        .WithArguments(
                            args => args
                                .Add("nuget")
                                .Add("push")
                                .Add(fileInfos[0].FullName)
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
            finally
            {
                dir.Refresh();
                if (dir.Exists)
                {
                    dir.Delete(true);
                }
            }
        }

        private void uitxtPath_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.SelectedPath = Properties.Settings.Default.LastSelectedFolder1;
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                Properties.Settings.Default.LastSelectedFolder1 = dilog.SelectedPath;
                Properties.Settings.Default.Save();

                uitxtPath.Text = dilog.SelectedPath;
            }
        }

        private void FSlnPackUploadPage_Initialize(object sender, EventArgs e)
        {
            InitPacks();
            BindRadio();
            InitControl();
           
        }
    }
}
