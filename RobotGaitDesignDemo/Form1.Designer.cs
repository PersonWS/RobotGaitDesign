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
            this.txt_batchCan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmb_idFilter = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chk_filterByMotorID = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_OnlyFeedBackData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_batchCanAnalysis = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_clearShowMessage = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_saveShowMessage = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_analysis
            // 
            this.btn_analysis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_analysis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_analysis.Location = new System.Drawing.Point(426, 15);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(196, 275);
            this.btn_analysis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_analysis.TabIndex = 0;
            this.btn_analysis.Text = "analysis";
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(20, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 49);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "id:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(20, 185);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 49);
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
            this.txt_id.Location = new System.Drawing.Point(87, 12);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_id.Size = new System.Drawing.Size(333, 117);
            this.txt_id.TabIndex = 3;
            this.txt_id.Text = "FD-03-02-98";
            // 
            // txt_motorData
            // 
            // 
            // 
            // 
            this.txt_motorData.Border.Class = "TextBoxBorder";
            this.txt_motorData.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_motorData.Location = new System.Drawing.Point(87, 150);
            this.txt_motorData.Multiline = true;
            this.txt_motorData.Name = "txt_motorData";
            this.txt_motorData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_motorData.Size = new System.Drawing.Size(333, 140);
            this.txt_motorData.TabIndex = 4;
            this.txt_motorData.Text = "83517FA47FFF01E0";
            // 
            // txt_showMessage
            // 
            this.txt_showMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_showMessage.Border.Class = "TextBoxBorder";
            this.txt_showMessage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_showMessage.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_showMessage.Location = new System.Drawing.Point(0, 419);
            this.txt_showMessage.Multiline = true;
            this.txt_showMessage.Name = "txt_showMessage";
            this.txt_showMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_showMessage.Size = new System.Drawing.Size(2179, 691);
            this.txt_showMessage.TabIndex = 5;
            // 
            // btn_log
            // 
            this.btn_log.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_log.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_log.Location = new System.Drawing.Point(1182, 6);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(200, 59);
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
            this.labelX3.Size = new System.Drawing.Size(86, 53);
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
            // txt_batchCan
            // 
            // 
            // 
            // 
            this.txt_batchCan.Border.Class = "TextBoxBorder";
            this.txt_batchCan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_batchCan.Location = new System.Drawing.Point(3, 3);
            this.txt_batchCan.Multiline = true;
            this.txt_batchCan.Name = "txt_batchCan";
            this.txt_batchCan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_batchCan.Size = new System.Drawing.Size(1237, 164);
            this.txt_batchCan.TabIndex = 13;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(37, 80);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(109, 49);
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
            this.chk_filterByMotorID.Size = new System.Drawing.Size(223, 58);
            this.chk_filterByMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_filterByMotorID.TabIndex = 16;
            this.chk_filterByMotorID.Text = "filterByMotorID";
            this.chk_filterByMotorID.CheckedChanged += new System.EventHandler(this.chk_filterByMotorID_CheckedChanged);
            // 
            // chk_OnlyFeedBackData
            // 
            // 
            // 
            // 
            this.chk_OnlyFeedBackData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_OnlyFeedBackData.Location = new System.Drawing.Point(791, 80);
            this.chk_OnlyFeedBackData.Name = "chk_OnlyFeedBackData";
            this.chk_OnlyFeedBackData.Size = new System.Drawing.Size(249, 58);
            this.chk_OnlyFeedBackData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_OnlyFeedBackData.TabIndex = 17;
            this.chk_OnlyFeedBackData.Text = "OnlyFeedBackData";
            this.chk_OnlyFeedBackData.CheckedChanged += new System.EventHandler(this.chk_OnlyFeedBackData_CheckedChanged);
            // 
            // btn_batchCanAnalysis
            // 
            this.btn_batchCanAnalysis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_batchCanAnalysis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_batchCanAnalysis.Location = new System.Drawing.Point(1246, 3);
            this.btn_batchCanAnalysis.Name = "btn_batchCanAnalysis";
            this.btn_batchCanAnalysis.Size = new System.Drawing.Size(119, 164);
            this.btn_batchCanAnalysis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_batchCanAnalysis.TabIndex = 18;
            this.btn_batchCanAnalysis.Text = "解析";
            this.btn_batchCanAnalysis.Click += new System.EventHandler(this.btn_batchCanAnalysis_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_id);
            this.groupPanel1.Controls.Add(this.txt_motorData);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.btn_analysis);
            this.groupPanel1.Location = new System.Drawing.Point(1527, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(640, 337);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 19;
            this.groupPanel1.Text = "CAN报文解析(监听软件)";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txt_batchCan);
            this.groupPanel2.Controls.Add(this.btn_batchCanAnalysis);
            this.groupPanel2.Location = new System.Drawing.Point(0, 177);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1382, 225);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 20;
            this.groupPanel2.Text = "CAN报文解析(批量报文)";
            // 
            // btn_clearShowMessage
            // 
            this.btn_clearShowMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearShowMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearShowMessage.Location = new System.Drawing.Point(1182, 80);
            this.btn_clearShowMessage.Name = "btn_clearShowMessage";
            this.btn_clearShowMessage.Size = new System.Drawing.Size(200, 59);
            this.btn_clearShowMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clearShowMessage.TabIndex = 21;
            this.btn_clearShowMessage.Text = "ClearOutput";
            this.btn_clearShowMessage.Click += new System.EventHandler(this.btn_clearShowMessage_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(1956, 354);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(200, 59);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 22;
            this.buttonX1.Text = "ClearOutput";
            // 
            // btn_saveShowMessage
            // 
            this.btn_saveShowMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_saveShowMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_saveShowMessage.Location = new System.Drawing.Point(1647, 355);
            this.btn_saveShowMessage.Name = "btn_saveShowMessage";
            this.btn_saveShowMessage.Size = new System.Drawing.Size(174, 59);
            this.btn_saveShowMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_saveShowMessage.TabIndex = 23;
            this.btn_saveShowMessage.Text = "保存数据";
            this.btn_saveShowMessage.Click += new System.EventHandler(this.btn_saveShowMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2179, 1122);
            this.Controls.Add(this.btn_saveShowMessage);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btn_clearShowMessage);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.chk_OnlyFeedBackData);
            this.Controls.Add(this.chk_filterByMotorID);
            this.Controls.Add(this.cmb_idFilter);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cmb_comList);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_disConnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.txt_showMessage);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Controls.TextBoxX txt_batchCan;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_idFilter;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_filterByMotorID;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_OnlyFeedBackData;
        private DevComponents.DotNetBar.ButtonX btn_batchCanAnalysis;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btn_clearShowMessage;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn_saveShowMessage;
    }
}

