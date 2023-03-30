using Sunny.UI;
using SunnyFan.NuGetManage.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunnyFan.NuGetManage
{
    public partial class Main : UIHeaderAsideMainFrame
    {
        public Main()
        {
            InitializeComponent();

            Aside.TabControl = MainTabControl;

            //增加页面到Main
            AddPage(new FSettingPage(), 1001);
          
            AddPage(new FCommonNupkgUpLoadPage(), 1002);

            AddPage(new FSlnPackUploadPage(), 1003);

            Aside.CreateNode("包源配置", 362750, 25, 1001);

            Aside.CreateNode("通用依赖包上传", 57456, 25, 1002);

            Aside.CreateNode("解决方案包处理", 162740, 25, 1003);

            //显示默认界面
            Aside.SelectFirst();

        }

        private void uiLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"https://{uiLinkLabel1.Text}");
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void uiLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sunnyfan.cn/dir/core/docker_baget.html");
        }
    }
}
