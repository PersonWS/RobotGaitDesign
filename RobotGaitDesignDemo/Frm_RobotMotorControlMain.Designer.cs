namespace RobotGaitDesign
{
    partial class Frm_RobotMotorControlMain
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
            this.btn_clearShowMessage_ext = new DevComponents.DotNetBar.ButtonX();
            this.btn_saveShowMessage_ext = new DevComponents.DotNetBar.ButtonX();
            this.btn_motorRW = new DevComponents.DotNetBar.ButtonX();
            this.btn_motorScanner = new DevComponents.DotNetBar.ButtonX();
            this.btn_ReadMotorVersion = new DevComponents.DotNetBar.ButtonX();
            this.chk_readMotorVersion = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_analysisFailedShowSocketData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_findMotorID = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lab_busUsedRate = new DevComponents.DotNetBar.LabelX();
            this.chk_OnlyWriteToMotorData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_motorScannerResultSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btn_readConfigMotor_ext = new DevComponents.DotNetBar.ButtonX();
            this.btn_clearDdFilter_ext = new DevComponents.DotNetBar.ButtonX();
            this.btn_StepExecute_ext = new DevComponents.DotNetBar.ButtonX();
            this.grp_motorInfo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmb_motrorBrand = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lab_motorVersion = new DevComponents.DotNetBar.LabelX();
            this.lab_motorType = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.grp_chDevice = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grp_information = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grp_motorInterope = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel1.SuspendLayout();
            this.grp_motorInfo.SuspendLayout();
            this.grp_chDevice.SuspendLayout();
            this.grp_information.SuspendLayout();
            this.grp_motorInterope.SuspendLayout();
            this.groupPanel2.SuspendLayout();
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
            this.txt_id.Text = "18-00-01-00";
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
            // 
            // 
            // 
            this.txt_showMessage.Border.Class = "TextBoxBorder";
            this.txt_showMessage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_showMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_showMessage.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_showMessage.Location = new System.Drawing.Point(0, 0);
            this.txt_showMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txt_showMessage.Multiline = true;
            this.txt_showMessage.Name = "txt_showMessage";
            this.txt_showMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_showMessage.Size = new System.Drawing.Size(2094, 505);
            this.txt_showMessage.TabIndex = 5;
            // 
            // btn_log_ext
            // 
            this.btn_log_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_log_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_log_ext.Location = new System.Drawing.Point(440, 12);
            this.btn_log_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_log_ext.Name = "btn_log_ext";
            this.btn_log_ext.Size = new System.Drawing.Size(204, 89);
            this.btn_log_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_log_ext.TabIndex = 6;
            this.btn_log_ext.Text = "DebugTraceLog";
            this.btn_log_ext.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(20, 7);
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
            this.btn_connect.Location = new System.Drawing.Point(247, 80);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(204, 60);
            this.btn_connect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "连接调试器";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disConnect
            // 
            this.btn_disConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_disConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_disConnect.Location = new System.Drawing.Point(487, 80);
            this.btn_disConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_disConnect.Name = "btn_disConnect";
            this.btn_disConnect.Size = new System.Drawing.Size(174, 60);
            this.btn_disConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_disConnect.TabIndex = 10;
            this.btn_disConnect.Text = "断开调试器";
            this.btn_disConnect.Click += new System.EventHandler(this.btn_disConnect_Click);
            // 
            // btn_refresh_ext
            // 
            this.btn_refresh_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_refresh_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_refresh_ext.Location = new System.Drawing.Point(20, 80);
            this.btn_refresh_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_ext.Name = "btn_refresh_ext";
            this.btn_refresh_ext.Size = new System.Drawing.Size(183, 60);
            this.btn_refresh_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_refresh_ext.TabIndex = 11;
            this.btn_refresh_ext.Text = "刷新列表";
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
            this.cmb_comList.Location = new System.Drawing.Point(127, 21);
            this.cmb_comList.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_comList.Name = "cmb_comList";
            this.cmb_comList.Size = new System.Drawing.Size(534, 32);
            this.cmb_comList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_comList.TabIndex = 12;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(8, 75);
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
            this.cmb_idFilter.Location = new System.Drawing.Point(151, 85);
            this.cmb_idFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_idFilter.Name = "cmb_idFilter";
            this.cmb_idFilter.Size = new System.Drawing.Size(278, 32);
            this.cmb_idFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_idFilter.TabIndex = 15;
            this.cmb_idFilter.SelectedIndexChanged += new System.EventHandler(this.cmb_idFilter_SelectedIndexChanged);
            this.cmb_idFilter.RightToLeftChanged += new System.EventHandler(this.cmb_idFilter_RightToLeftChanged);
            this.cmb_idFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_idFilter_KeyPress);
            // 
            // chk_filterByMotorID
            // 
            this.chk_filterByMotorID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_filterByMotorID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_filterByMotorID.Location = new System.Drawing.Point(10, 150);
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
            this.chk_OnlyFeedBackData.Location = new System.Drawing.Point(262, 132);
            this.chk_OnlyFeedBackData.Margin = new System.Windows.Forms.Padding(4);
            this.chk_OnlyFeedBackData.Name = "chk_OnlyFeedBackData";
            this.chk_OnlyFeedBackData.Size = new System.Drawing.Size(278, 58);
            this.chk_OnlyFeedBackData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_OnlyFeedBackData.TabIndex = 17;
            this.chk_OnlyFeedBackData.Text = "仅显示电机返回数据";
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
            this.groupPanel1.Location = new System.Drawing.Point(1417, 12);
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
            // btn_clearShowMessage_ext
            // 
            this.btn_clearShowMessage_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearShowMessage_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearShowMessage_ext.Location = new System.Drawing.Point(548, 4);
            this.btn_clearShowMessage_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearShowMessage_ext.Name = "btn_clearShowMessage_ext";
            this.btn_clearShowMessage_ext.Size = new System.Drawing.Size(125, 112);
            this.btn_clearShowMessage_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clearShowMessage_ext.TabIndex = 21;
            this.btn_clearShowMessage_ext.Text = "【清除】LOG数据";
            this.btn_clearShowMessage_ext.Click += new System.EventHandler(this.btn_clearShowMessage_Click);
            // 
            // btn_saveShowMessage_ext
            // 
            this.btn_saveShowMessage_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_saveShowMessage_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_saveShowMessage_ext.Location = new System.Drawing.Point(548, 132);
            this.btn_saveShowMessage_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveShowMessage_ext.Name = "btn_saveShowMessage_ext";
            this.btn_saveShowMessage_ext.Size = new System.Drawing.Size(125, 125);
            this.btn_saveShowMessage_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_saveShowMessage_ext.TabIndex = 23;
            this.btn_saveShowMessage_ext.Text = "【保存】LOG数据";
            this.btn_saveShowMessage_ext.Click += new System.EventHandler(this.btn_saveShowMessage_Click);
            // 
            // btn_motorRW
            // 
            this.btn_motorRW.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_motorRW.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_motorRW.Location = new System.Drawing.Point(20, 12);
            this.btn_motorRW.Margin = new System.Windows.Forms.Padding(4);
            this.btn_motorRW.Name = "btn_motorRW";
            this.btn_motorRW.Size = new System.Drawing.Size(204, 89);
            this.btn_motorRW.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_motorRW.TabIndex = 27;
            this.btn_motorRW.Text = "MotorRW电机交互";
            this.btn_motorRW.Click += new System.EventHandler(this.btn_motorRW_Click);
            // 
            // btn_motorScanner
            // 
            this.btn_motorScanner.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_motorScanner.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_motorScanner.Location = new System.Drawing.Point(465, 3);
            this.btn_motorScanner.Margin = new System.Windows.Forms.Padding(4);
            this.btn_motorScanner.Name = "btn_motorScanner";
            this.btn_motorScanner.Size = new System.Drawing.Size(200, 67);
            this.btn_motorScanner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_motorScanner.TabIndex = 35;
            this.btn_motorScanner.Text = "电机扫描01";
            this.btn_motorScanner.Click += new System.EventHandler(this.btn_motorScanner_Click);
            // 
            // btn_ReadMotorVersion
            // 
            this.btn_ReadMotorVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ReadMotorVersion.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ReadMotorVersion.Location = new System.Drawing.Point(465, 85);
            this.btn_ReadMotorVersion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ReadMotorVersion.Name = "btn_ReadMotorVersion";
            this.btn_ReadMotorVersion.Size = new System.Drawing.Size(200, 90);
            this.btn_ReadMotorVersion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ReadMotorVersion.TabIndex = 36;
            this.btn_ReadMotorVersion.Text = "读电机版本(会掉电机使能)02";
            this.btn_ReadMotorVersion.Click += new System.EventHandler(this.btn_ReadMotorVersion_Click);
            // 
            // chk_readMotorVersion
            // 
            this.chk_readMotorVersion.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_readMotorVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_readMotorVersion.Location = new System.Drawing.Point(10, 199);
            this.chk_readMotorVersion.Margin = new System.Windows.Forms.Padding(4);
            this.chk_readMotorVersion.Name = "chk_readMotorVersion";
            this.chk_readMotorVersion.Size = new System.Drawing.Size(197, 58);
            this.chk_readMotorVersion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_readMotorVersion.TabIndex = 37;
            this.chk_readMotorVersion.Text = "VerAnaysisON";
            this.chk_readMotorVersion.Visible = false;
            // 
            // chk_analysisFailedShowSocketData
            // 
            this.chk_analysisFailedShowSocketData.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_analysisFailedShowSocketData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_analysisFailedShowSocketData.Location = new System.Drawing.Point(262, 58);
            this.chk_analysisFailedShowSocketData.Margin = new System.Windows.Forms.Padding(4);
            this.chk_analysisFailedShowSocketData.Name = "chk_analysisFailedShowSocketData";
            this.chk_analysisFailedShowSocketData.Size = new System.Drawing.Size(243, 58);
            this.chk_analysisFailedShowSocketData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_analysisFailedShowSocketData.TabIndex = 38;
            this.chk_analysisFailedShowSocketData.Text = "解析失败显示报文";
            // 
            // chk_findMotorID
            // 
            this.chk_findMotorID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_findMotorID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_findMotorID.Checked = true;
            this.chk_findMotorID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_findMotorID.CheckValue = "Y";
            this.chk_findMotorID.Location = new System.Drawing.Point(233, 150);
            this.chk_findMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.chk_findMotorID.Name = "chk_findMotorID";
            this.chk_findMotorID.Size = new System.Drawing.Size(224, 58);
            this.chk_findMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_findMotorID.TabIndex = 39;
            this.chk_findMotorID.Text = "AutoFindMotorID";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(24, 82);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(180, 52);
            this.labelX5.TabIndex = 40;
            this.labelX5.Text = "总线使用率：";
            // 
            // lab_busUsedRate
            // 
            this.lab_busUsedRate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lab_busUsedRate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_busUsedRate.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_busUsedRate.Location = new System.Drawing.Point(24, 151);
            this.lab_busUsedRate.Margin = new System.Windows.Forms.Padding(4);
            this.lab_busUsedRate.Name = "lab_busUsedRate";
            this.lab_busUsedRate.Size = new System.Drawing.Size(180, 52);
            this.lab_busUsedRate.TabIndex = 41;
            this.lab_busUsedRate.Text = "0.00%";
            // 
            // chk_OnlyWriteToMotorData
            // 
            this.chk_OnlyWriteToMotorData.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_OnlyWriteToMotorData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_OnlyWriteToMotorData.Location = new System.Drawing.Point(262, 199);
            this.chk_OnlyWriteToMotorData.Margin = new System.Windows.Forms.Padding(4);
            this.chk_OnlyWriteToMotorData.Name = "chk_OnlyWriteToMotorData";
            this.chk_OnlyWriteToMotorData.Size = new System.Drawing.Size(262, 58);
            this.chk_OnlyWriteToMotorData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_OnlyWriteToMotorData.TabIndex = 42;
            this.chk_OnlyWriteToMotorData.Text = "仅显示电机写入数据";
            this.chk_OnlyWriteToMotorData.CheckedChanged += new System.EventHandler(this.chk_isWriteToMotorData_CheckedChanged);
            // 
            // btn_motorScannerResultSave
            // 
            this.btn_motorScannerResultSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_motorScannerResultSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_motorScannerResultSave.Location = new System.Drawing.Point(465, 183);
            this.btn_motorScannerResultSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_motorScannerResultSave.Name = "btn_motorScannerResultSave";
            this.btn_motorScannerResultSave.Size = new System.Drawing.Size(200, 90);
            this.btn_motorScannerResultSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_motorScannerResultSave.TabIndex = 43;
            this.btn_motorScannerResultSave.Text = "保存idFilter到配置文件03";
            this.btn_motorScannerResultSave.Click += new System.EventHandler(this.btn_motorScannerResultSave_Click);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(10, 250);
            this.labelX9.Margin = new System.Windows.Forms.Padding(4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(180, 52);
            this.labelX9.TabIndex = 44;
            this.labelX9.Text = "电机  型号：";
            // 
            // btn_readConfigMotor_ext
            // 
            this.btn_readConfigMotor_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_readConfigMotor_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_readConfigMotor_ext.Location = new System.Drawing.Point(461, 281);
            this.btn_readConfigMotor_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_readConfigMotor_ext.Name = "btn_readConfigMotor_ext";
            this.btn_readConfigMotor_ext.Size = new System.Drawing.Size(204, 90);
            this.btn_readConfigMotor_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_readConfigMotor_ext.TabIndex = 45;
            this.btn_readConfigMotor_ext.Text = "从配置文件获取电机信息";
            this.btn_readConfigMotor_ext.Click += new System.EventHandler(this.btn_readConfigMotor_Click);
            // 
            // btn_clearDdFilter_ext
            // 
            this.btn_clearDdFilter_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearDdFilter_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearDdFilter_ext.Location = new System.Drawing.Point(461, 379);
            this.btn_clearDdFilter_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearDdFilter_ext.Name = "btn_clearDdFilter_ext";
            this.btn_clearDdFilter_ext.Size = new System.Drawing.Size(204, 89);
            this.btn_clearDdFilter_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clearDdFilter_ext.TabIndex = 46;
            this.btn_clearDdFilter_ext.Text = "清除idFilter";
            this.btn_clearDdFilter_ext.Click += new System.EventHandler(this.btn_clearDdFilter_Click);
            // 
            // btn_StepExecute_ext
            // 
            this.btn_StepExecute_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_StepExecute_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_StepExecute_ext.Location = new System.Drawing.Point(232, 12);
            this.btn_StepExecute_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StepExecute_ext.Name = "btn_StepExecute_ext";
            this.btn_StepExecute_ext.Size = new System.Drawing.Size(200, 89);
            this.btn_StepExecute_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_StepExecute_ext.TabIndex = 47;
            this.btn_StepExecute_ext.Text = "步态执行";
            // 
            // grp_motorInfo
            // 
            this.grp_motorInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.grp_motorInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grp_motorInfo.Controls.Add(this.btn_readConfigMotor_ext);
            this.grp_motorInfo.Controls.Add(this.cmb_motrorBrand);
            this.grp_motorInfo.Controls.Add(this.labelX7);
            this.grp_motorInfo.Controls.Add(this.lab_motorVersion);
            this.grp_motorInfo.Controls.Add(this.lab_motorType);
            this.grp_motorInfo.Controls.Add(this.labelX6);
            this.grp_motorInfo.Controls.Add(this.labelX9);
            this.grp_motorInfo.Controls.Add(this.btn_motorScanner);
            this.grp_motorInfo.Controls.Add(this.btn_clearDdFilter_ext);
            this.grp_motorInfo.Controls.Add(this.btn_ReadMotorVersion);
            this.grp_motorInfo.Controls.Add(this.chk_readMotorVersion);
            this.grp_motorInfo.Controls.Add(this.btn_motorScannerResultSave);
            this.grp_motorInfo.Controls.Add(this.labelX4);
            this.grp_motorInfo.Controls.Add(this.cmb_idFilter);
            this.grp_motorInfo.Controls.Add(this.chk_filterByMotorID);
            this.grp_motorInfo.Controls.Add(this.chk_findMotorID);
            this.grp_motorInfo.Location = new System.Drawing.Point(727, 12);
            this.grp_motorInfo.Name = "grp_motorInfo";
            this.grp_motorInfo.Size = new System.Drawing.Size(683, 504);
            // 
            // 
            // 
            this.grp_motorInfo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grp_motorInfo.Style.BackColorGradientAngle = 90;
            this.grp_motorInfo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grp_motorInfo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInfo.Style.BorderBottomWidth = 1;
            this.grp_motorInfo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grp_motorInfo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInfo.Style.BorderLeftWidth = 1;
            this.grp_motorInfo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInfo.Style.BorderRightWidth = 1;
            this.grp_motorInfo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInfo.Style.BorderTopWidth = 1;
            this.grp_motorInfo.Style.CornerDiameter = 4;
            this.grp_motorInfo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grp_motorInfo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grp_motorInfo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grp_motorInfo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grp_motorInfo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grp_motorInfo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grp_motorInfo.TabIndex = 48;
            this.grp_motorInfo.Text = "电机信息";
            // 
            // cmb_motrorBrand
            // 
            this.cmb_motrorBrand.DisplayMember = "Text";
            this.cmb_motrorBrand.DropDownHeight = 200;
            this.cmb_motrorBrand.FormattingEnabled = true;
            this.cmb_motrorBrand.IntegralHeight = false;
            this.cmb_motrorBrand.ItemHeight = 24;
            this.cmb_motrorBrand.Location = new System.Drawing.Point(151, 28);
            this.cmb_motrorBrand.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_motrorBrand.Name = "cmb_motrorBrand";
            this.cmb_motrorBrand.Size = new System.Drawing.Size(278, 32);
            this.cmb_motrorBrand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_motrorBrand.TabIndex = 51;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(10, 12);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(133, 48);
            this.labelX7.TabIndex = 50;
            this.labelX7.Text = "MotorBrand:";
            // 
            // lab_motorVersion
            // 
            this.lab_motorVersion.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lab_motorVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_motorVersion.Location = new System.Drawing.Point(198, 310);
            this.lab_motorVersion.Margin = new System.Windows.Forms.Padding(4);
            this.lab_motorVersion.Name = "lab_motorVersion";
            this.lab_motorVersion.Size = new System.Drawing.Size(180, 52);
            this.lab_motorVersion.TabIndex = 49;
            this.lab_motorVersion.Text = "null";
            // 
            // lab_motorType
            // 
            this.lab_motorType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lab_motorType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_motorType.Location = new System.Drawing.Point(198, 250);
            this.lab_motorType.Margin = new System.Windows.Forms.Padding(4);
            this.lab_motorType.Name = "lab_motorType";
            this.lab_motorType.Size = new System.Drawing.Size(180, 52);
            this.lab_motorType.TabIndex = 48;
            this.lab_motorType.Text = "null";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(10, 310);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(180, 52);
            this.labelX6.TabIndex = 47;
            this.labelX6.Text = "电机版本号：";
            // 
            // grp_chDevice
            // 
            this.grp_chDevice.CanvasColor = System.Drawing.SystemColors.Control;
            this.grp_chDevice.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grp_chDevice.Controls.Add(this.cmb_comList);
            this.grp_chDevice.Controls.Add(this.labelX3);
            this.grp_chDevice.Controls.Add(this.btn_connect);
            this.grp_chDevice.Controls.Add(this.btn_disConnect);
            this.grp_chDevice.Controls.Add(this.btn_refresh_ext);
            this.grp_chDevice.Location = new System.Drawing.Point(12, 13);
            this.grp_chDevice.Name = "grp_chDevice";
            this.grp_chDevice.Size = new System.Drawing.Size(683, 188);
            // 
            // 
            // 
            this.grp_chDevice.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grp_chDevice.Style.BackColorGradientAngle = 90;
            this.grp_chDevice.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grp_chDevice.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_chDevice.Style.BorderBottomWidth = 1;
            this.grp_chDevice.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grp_chDevice.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_chDevice.Style.BorderLeftWidth = 1;
            this.grp_chDevice.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_chDevice.Style.BorderRightWidth = 1;
            this.grp_chDevice.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_chDevice.Style.BorderTopWidth = 1;
            this.grp_chDevice.Style.CornerDiameter = 4;
            this.grp_chDevice.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grp_chDevice.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grp_chDevice.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grp_chDevice.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grp_chDevice.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grp_chDevice.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grp_chDevice.TabIndex = 49;
            this.grp_chDevice.Text = "调试器";
            // 
            // grp_information
            // 
            this.grp_information.CanvasColor = System.Drawing.SystemColors.Control;
            this.grp_information.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grp_information.Controls.Add(this.chk_OnlyWriteToMotorData);
            this.grp_information.Controls.Add(this.chk_analysisFailedShowSocketData);
            this.grp_information.Controls.Add(this.chk_OnlyFeedBackData);
            this.grp_information.Controls.Add(this.labelX5);
            this.grp_information.Controls.Add(this.btn_clearShowMessage_ext);
            this.grp_information.Controls.Add(this.lab_busUsedRate);
            this.grp_information.Controls.Add(this.btn_saveShowMessage_ext);
            this.grp_information.Location = new System.Drawing.Point(12, 207);
            this.grp_information.Name = "grp_information";
            this.grp_information.Size = new System.Drawing.Size(683, 309);
            // 
            // 
            // 
            this.grp_information.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grp_information.Style.BackColorGradientAngle = 90;
            this.grp_information.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grp_information.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_information.Style.BorderBottomWidth = 1;
            this.grp_information.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grp_information.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_information.Style.BorderLeftWidth = 1;
            this.grp_information.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_information.Style.BorderRightWidth = 1;
            this.grp_information.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_information.Style.BorderTopWidth = 1;
            this.grp_information.Style.CornerDiameter = 4;
            this.grp_information.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grp_information.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grp_information.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grp_information.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grp_information.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grp_information.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grp_information.TabIndex = 50;
            this.grp_information.Text = "信息筛选/展示";
            // 
            // grp_motorInterope
            // 
            this.grp_motorInterope.CanvasColor = System.Drawing.SystemColors.Control;
            this.grp_motorInterope.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grp_motorInterope.Controls.Add(this.btn_motorRW);
            this.grp_motorInterope.Controls.Add(this.btn_StepExecute_ext);
            this.grp_motorInterope.Controls.Add(this.btn_log_ext);
            this.grp_motorInterope.Location = new System.Drawing.Point(1417, 355);
            this.grp_motorInterope.Name = "grp_motorInterope";
            this.grp_motorInterope.Size = new System.Drawing.Size(683, 170);
            // 
            // 
            // 
            this.grp_motorInterope.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grp_motorInterope.Style.BackColorGradientAngle = 90;
            this.grp_motorInterope.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grp_motorInterope.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInterope.Style.BorderBottomWidth = 1;
            this.grp_motorInterope.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grp_motorInterope.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInterope.Style.BorderLeftWidth = 1;
            this.grp_motorInterope.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInterope.Style.BorderRightWidth = 1;
            this.grp_motorInterope.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grp_motorInterope.Style.BorderTopWidth = 1;
            this.grp_motorInterope.Style.CornerDiameter = 4;
            this.grp_motorInterope.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grp_motorInterope.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grp_motorInterope.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grp_motorInterope.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grp_motorInterope.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grp_motorInterope.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grp_motorInterope.TabIndex = 51;
            this.grp_motorInterope.Text = "交互操作";
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txt_showMessage);
            this.groupPanel2.Location = new System.Drawing.Point(12, 522);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(2100, 511);
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
            this.groupPanel2.TabIndex = 52;
            // 
            // Frm_RobotMotorControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2114, 1069);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.grp_motorInterope);
            this.Controls.Add(this.grp_information);
            this.Controls.Add(this.grp_chDevice);
            this.Controls.Add(this.grp_motorInfo);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_RobotMotorControlMain";
            this.Text = "四足机器人电机调试软件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobotMotorControlMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel1.ResumeLayout(false);
            this.grp_motorInfo.ResumeLayout(false);
            this.grp_chDevice.ResumeLayout(false);
            this.grp_information.ResumeLayout(false);
            this.grp_motorInterope.ResumeLayout(false);
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
        private DevComponents.DotNetBar.ButtonX btn_clearShowMessage_ext;
        private DevComponents.DotNetBar.ButtonX btn_saveShowMessage_ext;
        private DevComponents.DotNetBar.ButtonX btn_motorRW;
        private DevComponents.DotNetBar.ButtonX btn_motorScanner;
        private DevComponents.DotNetBar.ButtonX btn_ReadMotorVersion;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_readMotorVersion;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_analysisFailedShowSocketData;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_findMotorID;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lab_busUsedRate;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_OnlyWriteToMotorData;
        private DevComponents.DotNetBar.ButtonX btn_motorScannerResultSave;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btn_readConfigMotor_ext;
        private DevComponents.DotNetBar.ButtonX btn_clearDdFilter_ext;
        private DevComponents.DotNetBar.ButtonX btn_StepExecute_ext;
        private DevComponents.DotNetBar.Controls.GroupPanel grp_motorInfo;
        private DevComponents.DotNetBar.Controls.GroupPanel grp_chDevice;
        private DevComponents.DotNetBar.Controls.GroupPanel grp_information;
        private DevComponents.DotNetBar.Controls.GroupPanel grp_motorInterope;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX lab_motorVersion;
        private DevComponents.DotNetBar.LabelX lab_motorType;
        private DevComponents.DotNetBar.LabelX labelX6;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmb_motrorBrand;
        private DevComponents.DotNetBar.LabelX labelX7;
    }
}

