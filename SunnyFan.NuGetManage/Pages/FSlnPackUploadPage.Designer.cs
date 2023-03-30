namespace SunnyFan.NuGetManage.Pages
{
    partial class FSlnPackUploadPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uibtnSearch = new Sunny.UI.UIButton();
            this.uitxtSearch = new Sunny.UI.UITextBox();
            this.uidgv2 = new Sunny.UI.UISuperGrid();
            this.uibtnLoad = new Sunny.UI.UIButton();
            this.uitxtPath = new Sunny.UI.UITextBox();
            this.uirtbRemark = new Sunny.UI.UIRichTextBox();
            this.uirbnSelectSource = new Sunny.UI.UIRadioButtonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.uidgv2)).BeginInit();
            this.SuspendLayout();
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
            this.uibtnSearch.Location = new System.Drawing.Point(686, 165);
            this.uibtnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnSearch.Name = "uibtnSearch";
            this.uibtnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnSearch.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uibtnSearch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnSearch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnSearch.Size = new System.Drawing.Size(70, 29);
            this.uibtnSearch.Style = Sunny.UI.UIStyle.Orange;
            this.uibtnSearch.TabIndex = 13;
            this.uibtnSearch.Text = "搜索";
            this.uibtnSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnSearch.Click += new System.EventHandler(this.uibtnSearch_Click);
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
            this.uitxtSearch.Location = new System.Drawing.Point(323, 165);
            this.uitxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitxtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.uitxtSearch.Name = "uitxtSearch";
            this.uitxtSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtSearch.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uitxtSearch.ShowText = false;
            this.uitxtSearch.Size = new System.Drawing.Size(356, 29);
            this.uitxtSearch.Style = Sunny.UI.UIStyle.Orange;
            this.uitxtSearch.TabIndex = 12;
            this.uitxtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitxtSearch.Watermark = "";
            // 
            // uidgv2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uidgv2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uidgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uidgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uidgv2.DefaultCellStyle = dataGridViewCellStyle3;
            this.uidgv2.EnableHeadersVisualStyles = false;
            this.uidgv2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.uidgv2.Location = new System.Drawing.Point(13, 212);
            this.uidgv2.Name = "uidgv2";
            this.uidgv2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uidgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uidgv2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uidgv2.RowTemplate.Height = 23;
            this.uidgv2.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uidgv2.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uidgv2.SelectedIndex = -1;
            this.uidgv2.Size = new System.Drawing.Size(743, 360);
            this.uidgv2.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uidgv2.Style = Sunny.UI.UIStyle.Orange;
            this.uidgv2.TabIndex = 11;
            this.uidgv2.CellMouseButtonClick += new Sunny.UI.OnCellMouseButtonClick(this.uidgv_CellMouseButtonClick);
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
            this.uibtnLoad.Location = new System.Drawing.Point(249, 165);
            this.uibtnLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnLoad.Name = "uibtnLoad";
            this.uibtnLoad.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uibtnLoad.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uibtnLoad.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnLoad.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uibtnLoad.Size = new System.Drawing.Size(58, 29);
            this.uibtnLoad.Style = Sunny.UI.UIStyle.Orange;
            this.uibtnLoad.TabIndex = 10;
            this.uibtnLoad.Text = "读取";
            this.uibtnLoad.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnLoad.Click += new System.EventHandler(this.uibtnLoad_Click);
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
            this.uitxtPath.Location = new System.Drawing.Point(13, 165);
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
            this.uitxtPath.TabIndex = 9;
            this.uitxtPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitxtPath.Watermark = "请选择文件夹";
            this.uitxtPath.ButtonClick += new System.EventHandler(this.uitxtPath_ButtonClick);
            // 
            // uirtbRemark
            // 
            this.uirtbRemark.FillColor = System.Drawing.Color.White;
            this.uirtbRemark.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uirtbRemark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uirtbRemark.Location = new System.Drawing.Point(253, 32);
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
            this.uirtbRemark.TabIndex = 8;
            this.uirtbRemark.Text = "1、请选择项目根目录，将读取所有文件夹内的.csproj文件\n2、打包并上传至指定包源\n3、需保证项目文件能够正常编译\n4、需支持dotnet环境命令，请使用控制" +
    "台执行dotnet --version命令验证";
            this.uirtbRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uirbnSelectSource
            // 
            this.uirbnSelectSource.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uirbnSelectSource.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uirbnSelectSource.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uirbnSelectSource.Location = new System.Drawing.Point(13, 12);
            this.uirbnSelectSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uirbnSelectSource.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbnSelectSource.Name = "uirbnSelectSource";
            this.uirbnSelectSource.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uirbnSelectSource.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uirbnSelectSource.Size = new System.Drawing.Size(223, 131);
            this.uirbnSelectSource.Style = Sunny.UI.UIStyle.Orange;
            this.uirbnSelectSource.TabIndex = 7;
            this.uirbnSelectSource.Text = "选择包源";
            this.uirbnSelectSource.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FSlnPackUploadPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 585);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.uibtnSearch);
            this.Controls.Add(this.uitxtSearch);
            this.Controls.Add(this.uidgv2);
            this.Controls.Add(this.uibtnLoad);
            this.Controls.Add(this.uitxtPath);
            this.Controls.Add(this.uirtbRemark);
            this.Controls.Add(this.uirbnSelectSource);
            this.Name = "FSlnPackUploadPage";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Orange;
            this.StyleCustomMode = true;
            this.Text = "FSlnPackUpload";
            this.Initialize += new System.EventHandler(this.FSlnPackUploadPage_Initialize);
            ((System.ComponentModel.ISupportInitialize)(this.uidgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uibtnSearch;
        private Sunny.UI.UITextBox uitxtSearch;
        private Sunny.UI.UISuperGrid uidgv2;
        private Sunny.UI.UIButton uibtnLoad;
        private Sunny.UI.UITextBox uitxtPath;
        private Sunny.UI.UIRichTextBox uirtbRemark;
        private Sunny.UI.UIRadioButtonGroup uirbnSelectSource;
    }
}