namespace SunnyFan.NuGetManage
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiLinkLabel2 = new Sunny.UI.UILinkLabel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Location = new System.Drawing.Point(0, 120);
            this.Aside.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Aside.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Aside.Size = new System.Drawing.Size(250, 585);
            this.Aside.Style = Sunny.UI.UIStyle.Orange;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.uiLinkLabel2);
            this.Header.Controls.Add(this.uiMarkLabel2);
            this.Header.Controls.Add(this.uiLinkLabel1);
            this.Header.Controls.Add(this.uiMarkLabel1);
            this.Header.Controls.Add(this.uiSmoothLabel1);
            this.Header.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Header.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Header.Size = new System.Drawing.Size(1018, 85);
            this.Header.Style = Sunny.UI.UIStyle.Orange;
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(3, 10);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiSmoothLabel1.Size = new System.Drawing.Size(258, 66);
            this.uiSmoothLabel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiSmoothLabel1.TabIndex = 0;
            this.uiSmoothLabel1.Text = "SunnyFan";
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(657, 10);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(174, 23);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiMarkLabel1.TabIndex = 1;
            this.uiMarkLabel1.Text = "dotNET 开发指南";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel1.Location = new System.Drawing.Point(837, 10);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(149, 23);
            this.uiLinkLabel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiLinkLabel1.TabIndex = 2;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "www.sunnyfan.cn";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uiLinkLabel1_LinkClicked);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(657, 43);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(174, 23);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Orange;
            this.uiMarkLabel2.TabIndex = 3;
            this.uiMarkLabel2.Text = "Baget私服搭建教程";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLinkLabel2
            // 
            this.uiLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel2.Location = new System.Drawing.Point(837, 43);
            this.uiLinkLabel2.Name = "uiLinkLabel2";
            this.uiLinkLabel2.Size = new System.Drawing.Size(149, 23);
            this.uiLinkLabel2.Style = Sunny.UI.UIStyle.Orange;
            this.uiLinkLabel2.TabIndex = 4;
            this.uiLinkLabel2.TabStop = true;
            this.uiLinkLabel2.Text = "点    击    进    入";
            this.uiLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uiLinkLabel2_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1018, 705);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Orange;
            this.StyleCustomMode = true;
            this.Text = "NuGet管理工具";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UILinkLabel uiLinkLabel2;
    }
}

