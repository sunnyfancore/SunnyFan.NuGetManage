namespace SunnyFan.NuGetManage.Pages
{
    partial class FCommonNupkgUpLoadPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uirbnSelectSource = new Sunny.UI.UIRadioButtonGroup();
            this.uirtbRemark = new Sunny.UI.UIRichTextBox();
            this.uitxtPath = new Sunny.UI.UITextBox();
            this.uibtnLoad = new Sunny.UI.UIButton();
            this.uidgv = new Sunny.UI.UISuperGrid();
            this.uitxtSearch = new Sunny.UI.UITextBox();
            this.uibtnSearch = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uidgv)).BeginInit();
            this.SuspendLayout();
            // 
            // uirbnSelectSource
            // 
            this.uirbnSelectSource.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uirbnSelectSource.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uirbnSelectSource.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uirbnSelectSource.Location = new System.Drawing.Point(13, 13);
            this.uirbnSelectSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uirbnSelectSource.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbnSelectSource.Name = "uirbnSelectSource";
            this.uirbnSelectSource.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uirbnSelectSource.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uirbnSelectSource.Size = new System.Drawing.Size(223, 131);
            this.uirbnSelectSource.Style = Sunny.UI.UIStyle.Orange;
            this.uirbnSelectSource.TabIndex = 0;
            this.uirbnSelectSource.Text = "选择包源";
            this.uirbnSelectSource.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uirtbRemark
            // 
            this.uirtbRemark.FillColor = System.Drawing.Color.White;
            this.uirtbRemark.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uirtbRemark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uirtbRemark.Location = new System.Drawing.Point(253, 33);
            this.uirtbRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uirtbRemark.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirtbRemark.Name = "uirtbRemark";
            this.uirtbRemark.Padding = new System.Windows.Forms.Padding(2);
            this.uirtbRemark.ReadOnly = true;
            this.uirtbRemark.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uirtbRemark.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uirtbRemark.ShowText = false;
            this.uirtbRemark.Size = new System.Drawing.Size(502, 111);
            this.uirtbRemark.Style = Sunny.UI.UIStyle.Orange;
            this.uirtbRemark.TabIndex = 1;
            this.uirtbRemark.Text = "1、默认扫描nuget缓存路径下的nupak文件\n2、可修改路径到项目解决方案packages目录（兼容老项目）\n3、此功能主要针对已有的nupkg文件进行上传\n" +
    "4、需支持dotnet环境命令，请使用控制台执行dotnet --version命令验证";
            this.uirtbRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uitxtPath
            // 
            this.uitxtPath.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtPath.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uitxtPath.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uitxtPath.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtPath.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uitxtPath.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uitxtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitxtPath.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uitxtPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitxtPath.Location = new System.Drawing.Point(13, 166);
            this.uitxtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitxtPath.MinimumSize = new System.Drawing.Size(1, 16);
            this.uitxtPath.Name = "uitxtPath";
            this.uitxtPath.ReadOnly = true;
            this.uitxtPath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtPath.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtPath.ShowButton = true;
            this.uitxtPath.ShowText = false;
            this.uitxtPath.Size = new System.Drawing.Size(229, 29);
            this.uitxtPath.Style = Sunny.UI.UIStyle.Orange;
            this.uitxtPath.TabIndex = 2;
            this.uitxtPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitxtPath.Watermark = "请选择文件夹";
            this.uitxtPath.ButtonClick += new System.EventHandler(this.uiTextBox1_ButtonClick);
            // 
            // uibtnLoad
            // 
            this.uibtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnLoad.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnLoad.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uibtnLoad.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnLoad.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnLoad.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnLoad.Location = new System.Drawing.Point(249, 166);
            this.uibtnLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnLoad.Name = "uibtnLoad";
            this.uibtnLoad.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnLoad.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uibtnLoad.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnLoad.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnLoad.Size = new System.Drawing.Size(58, 29);
            this.uibtnLoad.Style = Sunny.UI.UIStyle.Orange;
            this.uibtnLoad.TabIndex = 3;
            this.uibtnLoad.Text = "读取";
            this.uibtnLoad.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnLoad.Click += new System.EventHandler(this.uibtnLoad_Click);
            // 
            // uidgv
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.uidgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uidgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.uidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uidgv.DefaultCellStyle = dataGridViewCellStyle18;
            this.uidgv.EnableHeadersVisualStyles = false;
            this.uidgv.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.uidgv.Location = new System.Drawing.Point(13, 213);
            this.uidgv.Name = "uidgv";
            this.uidgv.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uidgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uidgv.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.uidgv.RowTemplate.Height = 23;
            this.uidgv.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uidgv.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uidgv.SelectedIndex = -1;
            this.uidgv.Size = new System.Drawing.Size(743, 360);
            this.uidgv.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv.Style = Sunny.UI.UIStyle.Orange;
            this.uidgv.TabIndex = 4;
            this.uidgv.CellMouseButtonClick += new Sunny.UI.OnCellMouseButtonClick(this.uidgv_CellMouseButtonClick);
            // 
            // uitxtSearch
            // 
            this.uitxtSearch.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtSearch.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uitxtSearch.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uitxtSearch.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtSearch.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uitxtSearch.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uitxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitxtSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uitxtSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitxtSearch.Location = new System.Drawing.Point(323, 166);
            this.uitxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitxtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.uitxtSearch.Name = "uitxtSearch";
            this.uitxtSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtSearch.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtSearch.ShowText = false;
            this.uitxtSearch.Size = new System.Drawing.Size(356, 29);
            this.uitxtSearch.Style = Sunny.UI.UIStyle.Orange;
            this.uitxtSearch.TabIndex = 5;
            this.uitxtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitxtSearch.Watermark = "";
            // 
            // uibtnSearch
            // 
            this.uibtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnSearch.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uibtnSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnSearch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnSearch.Location = new System.Drawing.Point(686, 166);
            this.uibtnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnSearch.Name = "uibtnSearch";
            this.uibtnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnSearch.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uibtnSearch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnSearch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnSearch.Size = new System.Drawing.Size(70, 29);
            this.uibtnSearch.Style = Sunny.UI.UIStyle.Orange;
            this.uibtnSearch.TabIndex = 6;
            this.uibtnSearch.Text = "搜索";
            this.uibtnSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnSearch.Click += new System.EventHandler(this.uibtnSearch_Click);
            // 
            // FCommonNupkgUpLoadPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 585);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.uibtnSearch);
            this.Controls.Add(this.uitxtSearch);
            this.Controls.Add(this.uidgv);
            this.Controls.Add(this.uibtnLoad);
            this.Controls.Add(this.uitxtPath);
            this.Controls.Add(this.uirtbRemark);
            this.Controls.Add(this.uirbnSelectSource);
            this.Name = "FCommonNupkgUpLoadPage";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Orange;
            this.StyleCustomMode = true;
            this.Text = "FCommonNupkgUpLoad";
            this.Initialize += new System.EventHandler(this.FCommonNupkgUpLoadPage_Initialize);
            ((System.ComponentModel.ISupportInitialize)(this.uidgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButtonGroup uirbnSelectSource;
        private Sunny.UI.UIRichTextBox uirtbRemark;
        private Sunny.UI.UITextBox uitxtPath;
        private Sunny.UI.UIButton uibtnLoad;
        private Sunny.UI.UISuperGrid uidgv;
        private Sunny.UI.UITextBox uitxtSearch;
        private Sunny.UI.UIButton uibtnSearch;
    }
}