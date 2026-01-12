namespace RobotGaitDesign
{
    partial class RobotMotorControlMain
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
            this.btn_log_ext = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_connect = new DevComponents.DotNetBar.ButtonX();
            this.btn_disConnect = new DevComponents.DotNetBar.ButtonX();
            this.btn_refresh_ext = new DevComponents.DotNetBar.ButtonX();
            this.cmb_comList = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmb_idFilter = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chk_filterByMotorID = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_OnlyFeedBackData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_clearShowMessage = new DevComponents.DotNetBar.ButtonX();
            this.btn_saveShowMessage = new DevComponents.DotNetBar.ButtonX();
            this.txt_MotorAckData = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chk_GetMotorAckData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_saveMotorAckData = new DevComponents.DotNetBar.ButtonX();
            this.btn_motorRW = new DevComponents.DotNetBar.ButtonX();
            this.btn_motorScanner = new DevComponents.DotNetBar.ButtonX();
            this.btn_ReadMotorVersion = new DevComponents.DotNetBar.ButtonX();
            this.chk_readMotorVersion = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_analysisFailedShowSocketData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_findMotorID = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lab_busUsedRate = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_analysis
            // 
            this.btn_analysis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_analysis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_analysis.Location = new System.Drawing.Point(428, 12);
            this.btn_analysis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(127, 278);
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
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 48);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "id:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(20, 184);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 48);
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
            this.txt_id.Location = new System.Drawing.Point(88, 12);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_id.Size = new System.Drawing.Size(332, 116);
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
            this.txt_motorData.Location = new System.Drawing.Point(88, 150);
            this.txt_motorData.Margin = new System.Windows.Forms.Padding(4);
            this.txt_motorData.Multiline = true;
            this.txt_motorData.Name = "txt_motorData";
            this.txt_motorData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_motorData.Size = new System.Drawing.Size(332, 140);
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
            this.txt_showMessage.Location = new System.Drawing.Point(0, 420);
            this.txt_showMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txt_showMessage.Multiline = true;
            this.txt_showMessage.Name = "txt_showMessage";
            this.txt_showMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_showMessage.Size = new System.Drawing.Size(2221, 697);
            this.txt_showMessage.TabIndex = 5;
            // 
            // btn_log_ext
            // 
            this.btn_log_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_log_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_log_ext.Location = new System.Drawing.Point(1251, 13);
            this.btn_log_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_log_ext.Name = "btn_log_ext";
            this.btn_log_ext.Size = new System.Drawing.Size(200, 60);
            this.btn_log_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_log_ext.TabIndex = 6;
            this.btn_log_ext.Text = "Log";
            this.btn_log_ext.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(36, -2);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 52);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "COM:";
            // 
            // btn_connect
            // 
            this.btn_connect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_connect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_connect.Location = new System.Drawing.Point(548, 6);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(204, 60);
            this.btn_connect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "connect";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disConnect
            // 
            this.btn_disConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_disConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_disConnect.Location = new System.Drawing.Point(792, 6);
            this.btn_disConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_disConnect.Name = "btn_disConnect";
            this.btn_disConnect.Size = new System.Drawing.Size(174, 60);
            this.btn_disConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_disConnect.TabIndex = 10;
            this.btn_disConnect.Text = "disConnect";
            this.btn_disConnect.Click += new System.EventHandler(this.btn_disConnect_Click);
            // 
            // btn_refresh_ext
            // 
            this.btn_refresh_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_refresh_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_refresh_ext.Location = new System.Drawing.Point(1048, 13);
            this.btn_refresh_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_ext.Name = "btn_refresh_ext";
            this.btn_refresh_ext.Size = new System.Drawing.Size(183, 60);
            this.btn_refresh_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_refresh_ext.TabIndex = 11;
            this.btn_refresh_ext.Text = "刷新";
            this.btn_refresh_ext.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cmb_comList
            // 
            this.cmb_comList.DisplayMember = "Text";
            this.cmb_comList.DropDownHeight = 200;
            this.cmb_comList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comList.FormattingEnabled = true;
            this.cmb_comList.IntegralHeight = false;
            this.cmb_comList.ItemHeight = 24;
            this.cmb_comList.Location = new System.Drawing.Point(128, 12);
            this.cmb_comList.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_comList.Name = "cmb_comList";
            this.cmb_comList.Size = new System.Drawing.Size(398, 32);
            this.cmb_comList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_comList.TabIndex = 12;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(4, 66);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(108, 48);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "idFilter:";
            // 
            // cmb_idFilter
            // 
            this.cmb_idFilter.DisplayMember = "Text";
            this.cmb_idFilter.DropDownHeight = 200;
            this.cmb_idFilter.FormattingEnabled = true;
            this.cmb_idFilter.IntegralHeight = false;
            this.cmb_idFilter.ItemHeight = 24;
            this.cmb_idFilter.Location = new System.Drawing.Point(128, 80);
            this.cmb_idFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_idFilter.Name = "cmb_idFilter";
            this.cmb_idFilter.Size = new System.Drawing.Size(398, 32);
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
            this.chk_filterByMotorID.Location = new System.Drawing.Point(548, 80);
            this.chk_filterByMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.chk_filterByMotorID.Name = "chk_filterByMotorID";
            this.chk_filterByMotorID.Size = new System.Drawing.Size(224, 58);
            this.chk_filterByMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_filterByMotorID.TabIndex = 16;
            this.chk_filterByMotorID.Text = "filterByMotorID";
            this.chk_filterByMotorID.CheckedChanged += new System.EventHandler(this.chk_filterByMotorID_CheckedChanged);
            // 
            // chk_OnlyFeedBackData
            // 
            this.chk_OnlyFeedBackData.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_OnlyFeedBackData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_OnlyFeedBackData.Location = new System.Drawing.Point(548, 137);
            this.chk_OnlyFeedBackData.Margin = new System.Windows.Forms.Padding(4);
            this.chk_OnlyFeedBackData.Name = "chk_OnlyFeedBackData";
            this.chk_OnlyFeedBackData.Size = new System.Drawing.Size(248, 58);
            this.chk_OnlyFeedBackData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_OnlyFeedBackData.TabIndex = 17;
            this.chk_OnlyFeedBackData.Text = "OnlyFeedBackData";
            this.chk_OnlyFeedBackData.CheckedChanged += new System.EventHandler(this.chk_OnlyFeedBackData_CheckedChanged);
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
            this.groupPanel1.Location = new System.Drawing.Point(1619, 12);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(576, 336);
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
            // btn_clearShowMessage
            // 
            this.btn_clearShowMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearShowMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearShowMessage.Location = new System.Drawing.Point(1967, 356);
            this.btn_clearShowMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearShowMessage.Name = "btn_clearShowMessage";
            this.btn_clearShowMessage.Size = new System.Drawing.Size(200, 60);
            this.btn_clearShowMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clearShowMessage.TabIndex = 21;
            this.btn_clearShowMessage.Text = "ClearOutput";
            this.btn_clearShowMessage.Click += new System.EventHandler(this.btn_clearShowMessage_Click);
            // 
            // btn_saveShowMessage
            // 
            this.btn_saveShowMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_saveShowMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_saveShowMessage.Location = new System.Drawing.Point(1619, 356);
            this.btn_saveShowMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveShowMessage.Name = "btn_saveShowMessage";
            this.btn_saveShowMessage.Size = new System.Drawing.Size(174, 60);
            this.btn_saveShowMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_saveShowMessage.TabIndex = 23;
            this.btn_saveShowMessage.Text = "保存数据";
            this.btn_saveShowMessage.Click += new System.EventHandler(this.btn_saveShowMessage_Click);
            // 
            // txt_MotorAckData
            // 
            // 
            // 
            // 
            this.txt_MotorAckData.Border.Class = "TextBoxBorder";
            this.txt_MotorAckData.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MotorAckData.Location = new System.Drawing.Point(112, 12);
            this.txt_MotorAckData.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MotorAckData.Multiline = true;
            this.txt_MotorAckData.Name = "txt_MotorAckData";
            this.txt_MotorAckData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MotorAckData.Size = new System.Drawing.Size(422, 154);
            this.txt_MotorAckData.TabIndex = 25;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.chk_GetMotorAckData);
            this.groupPanel3.Controls.Add(this.btn_saveMotorAckData);
            this.groupPanel3.Controls.Add(this.txt_MotorAckData);
            this.groupPanel3.Location = new System.Drawing.Point(264, 207);
            this.groupPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(684, 205);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 26;
            this.groupPanel3.Text = "电机ACK数据";
            // 
            // chk_GetMotorAckData
            // 
            this.chk_GetMotorAckData.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_GetMotorAckData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_GetMotorAckData.Location = new System.Drawing.Point(-1, -20);
            this.chk_GetMotorAckData.Margin = new System.Windows.Forms.Padding(4);
            this.chk_GetMotorAckData.Name = "chk_GetMotorAckData";
            this.chk_GetMotorAckData.Size = new System.Drawing.Size(108, 125);
            this.chk_GetMotorAckData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_GetMotorAckData.TabIndex = 40;
            this.chk_GetMotorAckData.Text = "Get Ack Data";
            // 
            // btn_saveMotorAckData
            // 
            this.btn_saveMotorAckData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_saveMotorAckData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_saveMotorAckData.Location = new System.Drawing.Point(552, 8);
            this.btn_saveMotorAckData.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveMotorAckData.Name = "btn_saveMotorAckData";
            this.btn_saveMotorAckData.Size = new System.Drawing.Size(112, 154);
            this.btn_saveMotorAckData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_saveMotorAckData.TabIndex = 26;
            this.btn_saveMotorAckData.Text = "保存数据";
            this.btn_saveMotorAckData.Click += new System.EventHandler(this.btn_saveMotorAckData_Click);
            // 
            // btn_motorRW
            // 
            this.btn_motorRW.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_motorRW.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_motorRW.Location = new System.Drawing.Point(1481, 13);
            this.btn_motorRW.Margin = new System.Windows.Forms.Padding(4);
            this.btn_motorRW.Name = "btn_motorRW";
            this.btn_motorRW.Size = new System.Drawing.Size(130, 231);
            this.btn_motorRW.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_motorRW.TabIndex = 27;
            this.btn_motorRW.Text = "MotorRW电机交互";
            this.btn_motorRW.Click += new System.EventHandler(this.btn_motorRW_Click);
            // 
            // btn_motorScanner
            // 
            this.btn_motorScanner.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_motorScanner.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_motorScanner.Location = new System.Drawing.Point(792, 80);
            this.btn_motorScanner.Margin = new System.Windows.Forms.Padding(4);
            this.btn_motorScanner.Name = "btn_motorScanner";
            this.btn_motorScanner.Size = new System.Drawing.Size(174, 105);
            this.btn_motorScanner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_motorScanner.TabIndex = 35;
            this.btn_motorScanner.Text = "MotorScanner";
            this.btn_motorScanner.Click += new System.EventHandler(this.btn_motorScanner_Click);
            // 
            // btn_ReadMotorVersion
            // 
            this.btn_ReadMotorVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ReadMotorVersion.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ReadMotorVersion.Location = new System.Drawing.Point(1251, 125);
            this.btn_ReadMotorVersion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ReadMotorVersion.Name = "btn_ReadMotorVersion";
            this.btn_ReadMotorVersion.Size = new System.Drawing.Size(200, 60);
            this.btn_ReadMotorVersion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ReadMotorVersion.TabIndex = 36;
            this.btn_ReadMotorVersion.Text = "ReadMotorVersion";
            this.btn_ReadMotorVersion.Click += new System.EventHandler(this.btn_ReadMotorVersion_Click);
            // 
            // chk_readMotorVersion
            // 
            // 
            // 
            // 
            this.chk_readMotorVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_readMotorVersion.Location = new System.Drawing.Point(1048, 137);
            this.chk_readMotorVersion.Margin = new System.Windows.Forms.Padding(4);
            this.chk_readMotorVersion.Name = "chk_readMotorVersion";
            this.chk_readMotorVersion.Size = new System.Drawing.Size(197, 58);
            this.chk_readMotorVersion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_readMotorVersion.TabIndex = 37;
            this.chk_readMotorVersion.Text = "VerAnaysisON";
            // 
            // chk_analysisFailedShowSocketData
            // 
            // 
            // 
            // 
            this.chk_analysisFailedShowSocketData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_analysisFailedShowSocketData.Location = new System.Drawing.Point(13, 137);
            this.chk_analysisFailedShowSocketData.Margin = new System.Windows.Forms.Padding(4);
            this.chk_analysisFailedShowSocketData.Name = "chk_analysisFailedShowSocketData";
            this.chk_analysisFailedShowSocketData.Size = new System.Drawing.Size(243, 58);
            this.chk_analysisFailedShowSocketData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_analysisFailedShowSocketData.TabIndex = 38;
            this.chk_analysisFailedShowSocketData.Text = "解析失败显示报文";
            // 
            // chk_findMotorID
            // 
            // 
            // 
            // 
            this.chk_findMotorID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_findMotorID.Checked = true;
            this.chk_findMotorID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_findMotorID.CheckValue = "Y";
            this.chk_findMotorID.Location = new System.Drawing.Point(264, 137);
            this.chk_findMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.chk_findMotorID.Name = "chk_findMotorID";
            this.chk_findMotorID.Size = new System.Drawing.Size(248, 58);
            this.chk_findMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_findMotorID.TabIndex = 39;
            this.chk_findMotorID.Text = "AutoFindMotorID";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(26, 227);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(180, 52);
            this.labelX5.TabIndex = 40;
            this.labelX5.Text = "总线使用率：";
            // 
            // lab_busUsedRate
            // 
            // 
            // 
            // 
            this.lab_busUsedRate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_busUsedRate.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_busUsedRate.Location = new System.Drawing.Point(26, 296);
            this.lab_busUsedRate.Margin = new System.Windows.Forms.Padding(4);
            this.lab_busUsedRate.Name = "lab_busUsedRate";
            this.lab_busUsedRate.Size = new System.Drawing.Size(180, 52);
            this.lab_busUsedRate.TabIndex = 41;
            this.lab_busUsedRate.Text = "0.00%";
            // 
            // RobotMotorControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2221, 1069);
            this.Controls.Add(this.lab_busUsedRate);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btn_motorScanner);
            this.Controls.Add(this.chk_readMotorVersion);
            this.Controls.Add(this.btn_ReadMotorVersion);
            this.Controls.Add(this.btn_motorRW);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.btn_saveShowMessage);
            this.Controls.Add(this.btn_clearShowMessage);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.chk_OnlyFeedBackData);
            this.Controls.Add(this.chk_filterByMotorID);
            this.Controls.Add(this.cmb_idFilter);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cmb_comList);
            this.Controls.Add(this.btn_refresh_ext);
            this.Controls.Add(this.btn_disConnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btn_log_ext);
            this.Controls.Add(this.txt_showMessage);
            this.Controls.Add(this.chk_analysisFailedShowSocketData);
            this.Controls.Add(this.chk_findMotorID);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RobotMotorControlMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_analysis;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_id;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_motorData;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_showMessage;
        private DevComponents.DotNetBar.ButtonX btn_log_ext;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btn_connect;
        private DevComponents.DotNetBar.ButtonX btn_disConnect;
        private DevComponents.DotNetBar.ButtonX btn_refresh_ext;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_comList;
        private DevComponents.DotNetBar.LabelX labelX4;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmb_idFilter;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_filterByMotorID;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_OnlyFeedBackData;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_clearShowMessage;
        private DevComponents.DotNetBar.ButtonX btn_saveShowMessage;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MotorAckData;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btn_saveMotorAckData;
        private DevComponents.DotNetBar.ButtonX btn_motorRW;
        private DevComponents.DotNetBar.ButtonX btn_motorScanner;
        private DevComponents.DotNetBar.ButtonX btn_ReadMotorVersion;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_readMotorVersion;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_analysisFailedShowSocketData;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_findMotorID;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_GetMotorAckData;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lab_busUsedRate;
    }
}

