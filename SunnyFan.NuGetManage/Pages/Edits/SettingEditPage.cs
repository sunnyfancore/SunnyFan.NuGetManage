using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunnyFan.NuGetManage.Models;
using System.Xml.Linq;

namespace SunnyFan.NuGetManage.Pages.Edits
{
    public partial class SettingEditPage : UIEditForm
    {
        public SettingEditPage()
        {
            InitializeComponent();
        }


        protected override bool CheckData()
        {
            return CheckEmpty(uitxtTitle, "请填写包源名称！")
                   && CheckEmpty(uitxtPackSource, "请填写包源！");

        }

        private PackSourceModel pSourceModel;

        private Guid guid;

        public PackSourceModel PSourceModel
        {
            get
            {
                if (pSourceModel == null)
                {
                    pSourceModel = new PackSourceModel();
                }
                pSourceModel.Id = guid == null || guid == Guid.Empty ? Guid.NewGuid() : guid;
                pSourceModel.Title = uitxtTitle.Text;
                pSourceModel.Source = uitxtPackSource.Text;
                pSourceModel.APIKey = uitxtAPIKey.Text;
                return pSourceModel;
            }
            set
            {
                pSourceModel = value;
                guid = value.Id;
                uitxtTitle.Text = value.Title;
                uitxtPackSource.Text = value.Source;
                uitxtAPIKey.Text = value.APIKey;
            }
        }

    }
}
