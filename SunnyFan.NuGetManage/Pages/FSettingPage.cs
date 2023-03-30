using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using SunnyFan.NuGetManage.Models;
using SunnyFan.NuGetManage.Pages.Edits;

namespace SunnyFan.NuGetManage.Pages
{
    public partial class FSettingPage : UIPage
    {

        private List<PackSourceModel> packSources;
        public FSettingPage()
        {
            InitializeComponent();

            DataGridViewColumn dataGridViewColumn = uidgv.AddColumn("Id", "Id");
            dataGridViewColumn.Visible = false;
            uidgv.SetRowHeight(31); //设置行高29
            uidgv.AddColumn("序号", "Index", 40)
                .SuperGridIndexColumn();

            uidgv.AddColumn("名称", "Title");

            uidgv.AddColumn("源", "Source");

            uidgv.AddColumn("APIKey", "APIKey");

            uidgv.AddColumn("操作", "Button2", 120)
                .SuperGridButtonColumn() //设置固定按钮，忽略这一列是什么值   .AddSymbolButton("查看", UIColor.Blue, UIColor.White, 61452)
                .AddSymbolButton("编辑", UIColor.Green, UIColor.White, 61508)
                .AddSymbolButton("删除", UIColor.Red, UIColor.White, 61453)
                ;

            uidgv.Init();
        }

        private void uibtnEdit_Click(object sender, EventArgs e)
        {
            SettingEditPage frm = new SettingEditPage();
            frm.Render();
            frm.Style = this.Style;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                this.ShowSuccessTip("添加成功");
                frm.PSourceModel.Add();
                RefreshData();
            }
            frm.Dispose();
        }

        private void RefreshData()
        {
            var packSource = new PackSourceModel();
            packSources = packSource.Load();
            uidgv.DataSource = packSources;
            uidgv.Refresh();

            uidgv.Invalidate();
        }

        private void FSettingPage_Initialize(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void uidgv_CellMouseButtonClick(object sender, DataGridViewCellMouseButtonClickEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string id = this.uidgv.Rows[e.RowIndex].Cells[0].Value.ToString();

                switch (e.ButtonText)
                {
                    case "编辑":
                        UpdateModel(id);
                        break;
                    case "删除":
                        DelModel(id);
                        break;
                }

            }
        }

        private void UpdateModel(string id)
        {
            Guid guid = Guid.Parse(id);


            SettingEditPage frm = new SettingEditPage();
            frm.PSourceModel = packSources.Where(a => a.Id == guid).FirstOrDefault();
            frm.Render();
            frm.Style = this.Style;
            frm.ShowDialog();
        
            if (frm.IsOK)
            {
                this.ShowSuccessTip("修改成功");
                frm.PSourceModel.Update();
                RefreshData();
            }
            frm.Dispose();
        }

        private void DelModel(string id)
        {
            Guid guid = Guid.Parse(id);
            new PackSourceModel().Delete(guid);
            RefreshData();

            this.ShowSuccessTip("删除成功");
        }
    }
}
