namespace RobotGaitDesign
{
    partial class Form1
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
            this.btn_analysis = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_motorData = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_showMessage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_log = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_connect = new DevComponents.DotNetBar.ButtonX();
            this.btn_disConnect = new DevComponents.DotNetBar.ButtonX();
            this.btn_refresh = new DevComponents.DotNetBar.ButtonX();
            this.cmb_comList = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_comMsg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmb_idFilter = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chk_filterByMotorID = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // btn_analysis
            // 
            this.btn_analysis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_analysis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_analysis.Location = new System.Drawing.Point(1964, 120);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(261, 59);
            this.btn_analysis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_analysis.TabIndex = 0;
            this.btn_analysis.Text = "analysis";
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1046, 120);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(137, 49);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "id:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(1380, 107);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(137, 49);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "data:";
            // 
            // txt_id
            // 
            // 
            // 
            // 
            this.txt_id.Border.Class = "TextBoxBorder";
            this.txt_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_id.Location = new System.Drawing.Point(1138, 120);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_id.Size = new System.Drawing.Size(226, 184);
            this.txt_id.TabIndex = 3;
            this.txt_id.Text = "18007FFD";
            // 
            // txt_motorData
            // 
            // 
            // 
            // 
            this.txt_motorData.Border.Class = "TextBoxBorder";
            this.txt_motorData.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_motorData.Location = new System.Drawing.Point(1473, 107);
            this.txt_motorData.Multiline = true;
            this.txt_motorData.Name = "txt_motorData";
            this.txt_motorData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_motorData.Size = new System.Drawing.Size(469, 211);
            this.txt_motorData.TabIndex = 4;
            this.txt_motorData.Text = "8461 7F EF 7F FF 01 36";
            // 
            // txt_showMessage
            // 
            // 
            // 
            // 
            this.txt_showMessage.Border.Class = "TextBoxBorder";
            this.txt_showMessage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_showMessage.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_showMessage.Location = new System.Drawing.Point(12, 343);
            this.txt_showMessage.Multiline = true;
            this.txt_showMessage.Name = "txt_showMessage";
            this.txt_showMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_showMessage.Size = new System.Drawing.Size(2239, 781);
            this.txt_showMessage.TabIndex = 5;
            // 
            // btn_log
            // 
            this.btn_log.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_log.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_log.Location = new System.Drawing.Point(1962, 34);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(261, 59);
            this.btn_log.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_log.TabIndex = 6;
            this.btn_log.Text = "Log";
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(69, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(137, 49);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "COM:";
            // 
            // btn_connect
            // 
            this.btn_connect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_connect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_connect.Location = new System.Drawing.Point(496, 6);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(204, 59);
            this.btn_connect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "connect";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disConnect
            // 
            this.btn_disConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_disConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_disConnect.Location = new System.Drawing.Point(791, 6);
            this.btn_disConnect.Name = "btn_disConnect";
            this.btn_disConnect.Size = new System.Drawing.Size(174, 59);
            this.btn_disConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_disConnect.TabIndex = 10;
            this.btn_disConnect.Text = "disConnect";
            this.btn_disConnect.Click += new System.EventHandler(this.btn_disConnect_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_refresh.Location = new System.Drawing.Point(987, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(174, 59);
            this.btn_refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cmb_comList
            // 
            this.cmb_comList.DisplayMember = "Text";
            this.cmb_comList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_comList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comList.FormattingEnabled = true;
            this.cmb_comList.ItemHeight = 29;
            this.cmb_comList.Location = new System.Drawing.Point(161, 26);
            this.cmb_comList.Name = "cmb_comList";
            this.cmb_comList.Size = new System.Drawing.Size(226, 35);
            this.cmb_comList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_comList.TabIndex = 12;
            // 
            // txt_comMsg
            // 
            // 
            // 
            // 
            this.txt_comMsg.Border.Class = "TextBoxBorder";
            this.txt_comMsg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_comMsg.Location = new System.Drawing.Point(25, 158);
            this.txt_comMsg.Multiline = true;
            this.txt_comMsg.Name = "txt_comMsg";
            this.txt_comMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_comMsg.Size = new System.Drawing.Size(972, 173);
            this.txt_comMsg.TabIndex = 13;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(37, 80);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(137, 49);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "idFilter:";
            // 
            // cmb_idFilter
            // 
            this.cmb_idFilter.DisplayMember = "Text";
            this.cmb_idFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_idFilter.FormattingEnabled = true;
            this.cmb_idFilter.ItemHeight = 29;
            this.cmb_idFilter.Location = new System.Drawing.Point(161, 94);
            this.cmb_idFilter.Name = "cmb_idFilter";
            this.cmb_idFilter.Size = new System.Drawing.Size(226, 35);
            this.cmb_idFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_idFilter.TabIndex = 15;
            this.cmb_idFilter.SelectedIndexChanged += new System.EventHandler(this.cmb_idFilter_SelectedIndexChanged);
            this.cmb_idFilter.RightToLeftChanged += new System.EventHandler(this.cmb_idFilter_RightToLeftChanged);
            this.cmb_idFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_idFilter_KeyPress);
            // 
            // chk_filterByMotorID
            // 
            // 
            // 
            // 
            this.chk_filterByMotorID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_filterByMotorID.Location = new System.Drawing.Point(496, 80);
            this.chk_filterByMotorID.Name = "chk_filterByMotorID";
            this.chk_filterByMotorID.Size = new System.Drawing.Size(204, 58);
            this.chk_filterByMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_filterByMotorID.TabIndex = 16;
            this.chk_filterByMotorID.Text = "filterByMotorID";
            this.chk_filterByMotorID.CheckedChanged += new System.EventHandler(this.chk_filterByMotorID_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1122);
            this.Controls.Add(this.chk_filterByMotorID);
            this.Controls.Add(this.cmb_idFilter);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txt_comMsg);
            this.Controls.Add(this.cmb_comList);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_disConnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.txt_showMessage);
            this.Controls.Add(this.txt_motorData);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_analysis);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_analysis;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_id;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_motorData;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_showMessage;
        private DevComponents.DotNetBar.ButtonX btn_log;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btn_connect;
        private DevComponents.DotNetBar.ButtonX btn_disConnect;
        private DevComponents.DotNetBar.ButtonX btn_refresh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_comList;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_comMsg;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_idFilter;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_filterByMotorID;
    }
}

