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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txt_batchCan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmb_idFilter = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chk_filterByMotorID = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_OnlyFeedBackData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_batchCanAnalysis = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_clearShowMessage = new DevComponents.DotNetBar.ButtonX();
            this.btn_saveShowMessage = new DevComponents.DotNetBar.ButtonX();
            this.txt_MotorAckData = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_saveMotorAckData = new DevComponents.DotNetBar.ButtonX();
            this.btn_motorRW = new DevComponents.DotNetBar.ButtonX();
            this.gp_motorRW = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_gprw_modifyMotorID = new DevComponents.DotNetBar.ButtonX();
            this.txt_gprw_destinationMotorID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txt_gprw_soureMotorID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.chk_gprw_isParameterHold = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_gprw_motorParameterRead = new DevComponents.DotNetBar.ButtonX();
            this.btn_gprw_SetMotorReportInterval = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btn_gprw_UnEnableMotorReport = new DevComponents.DotNetBar.ButtonX();
            this.btn_gprw_motorEnable = new DevComponents.DotNetBar.ButtonX();
            this.btn_gprw_EnableMotorReport = new DevComponents.DotNetBar.ButtonX();
            this.txt_gprw_motorID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_clearMotorError = new DevComponents.DotNetBar.ButtonX();
            this.btn_gprw_motorUnEnable = new DevComponents.DotNetBar.ButtonX();
            this.cmb_gprw_SetMotorParameter = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_gprw_motorZero = new DevComponents.DotNetBar.ButtonX();
            this.btn_gprw_getAllMotor = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cmb_gprw_motorRunMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_MotorRunModeChange = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txt_gprw_SetMotorParameter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btn_gprw_SetMotorParameter = new DevComponents.DotNetBar.ButtonX();
            this.btn_motorScanner = new DevComponents.DotNetBar.ButtonX();
            this.btn_gprw_clearDgv_motorParameter = new DevComponents.DotNetBar.ButtonX();
            this.dgv_motorParameter = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txt_gprw_motorReprotInterval = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.gp_motorRW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_analysis
            // 
            this.btn_analysis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_analysis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_analysis.Location = new System.Drawing.Point(426, 16);
            this.btn_analysis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(196, 276);
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
            this.txt_showMessage.Size = new System.Drawing.Size(2180, 692);
            this.txt_showMessage.TabIndex = 5;
            // 
            // btn_log_ext
            // 
            this.btn_log_ext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_log_ext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_log_ext.Location = new System.Drawing.Point(1182, 6);
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
            this.btn_refresh_ext.Location = new System.Drawing.Point(988, 6);
            this.btn_refresh_ext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_ext.Name = "btn_refresh_ext";
            this.btn_refresh_ext.Size = new System.Drawing.Size(174, 60);
            this.btn_refresh_ext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_refresh_ext.TabIndex = 11;
            this.btn_refresh_ext.Text = "刷新";
            this.btn_refresh_ext.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cmb_comList
            // 
            this.cmb_comList.DisplayMember = "Text";
            this.cmb_comList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_comList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comList.FormattingEnabled = true;
            this.cmb_comList.ItemHeight = 29;
            this.cmb_comList.Location = new System.Drawing.Point(128, 12);
            this.cmb_comList.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_comList.Name = "cmb_comList";
            this.cmb_comList.Size = new System.Drawing.Size(398, 35);
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
            this.txt_batchCan.Location = new System.Drawing.Point(4, 4);
            this.txt_batchCan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_batchCan.Multiline = true;
            this.txt_batchCan.Name = "txt_batchCan";
            this.txt_batchCan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_batchCan.Size = new System.Drawing.Size(596, 164);
            this.txt_batchCan.TabIndex = 13;
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
            this.cmb_idFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_idFilter.FormattingEnabled = true;
            this.cmb_idFilter.ItemHeight = 29;
            this.cmb_idFilter.Location = new System.Drawing.Point(128, 80);
            this.cmb_idFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_idFilter.Name = "cmb_idFilter";
            this.cmb_idFilter.Size = new System.Drawing.Size(398, 35);
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
            // 
            // 
            // 
            this.chk_OnlyFeedBackData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_OnlyFeedBackData.Location = new System.Drawing.Point(792, 80);
            this.chk_OnlyFeedBackData.Margin = new System.Windows.Forms.Padding(4);
            this.chk_OnlyFeedBackData.Name = "chk_OnlyFeedBackData";
            this.chk_OnlyFeedBackData.Size = new System.Drawing.Size(248, 58);
            this.chk_OnlyFeedBackData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_OnlyFeedBackData.TabIndex = 17;
            this.chk_OnlyFeedBackData.Text = "OnlyFeedBackData";
            this.chk_OnlyFeedBackData.CheckedChanged += new System.EventHandler(this.chk_OnlyFeedBackData_CheckedChanged);
            // 
            // btn_batchCanAnalysis
            // 
            this.btn_batchCanAnalysis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_batchCanAnalysis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_batchCanAnalysis.Location = new System.Drawing.Point(604, 4);
            this.btn_batchCanAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_batchCanAnalysis.Name = "btn_batchCanAnalysis";
            this.btn_batchCanAnalysis.Size = new System.Drawing.Size(120, 164);
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
            this.groupPanel1.Location = new System.Drawing.Point(1528, 12);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(640, 336);
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
            this.groupPanel2.Location = new System.Drawing.Point(0, 176);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(752, 220);
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
            this.btn_saveShowMessage.Location = new System.Drawing.Point(1648, 356);
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
            this.txt_MotorAckData.Location = new System.Drawing.Point(16, 12);
            this.txt_MotorAckData.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MotorAckData.Multiline = true;
            this.txt_MotorAckData.Name = "txt_MotorAckData";
            this.txt_MotorAckData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MotorAckData.Size = new System.Drawing.Size(518, 154);
            this.txt_MotorAckData.TabIndex = 25;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btn_saveMotorAckData);
            this.groupPanel3.Controls.Add(this.txt_MotorAckData);
            this.groupPanel3.Location = new System.Drawing.Point(758, 176);
            this.groupPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(684, 220);
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
            // btn_saveMotorAckData
            // 
            this.btn_saveMotorAckData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_saveMotorAckData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_saveMotorAckData.Location = new System.Drawing.Point(552, 12);
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
            this.btn_motorRW.Location = new System.Drawing.Point(792, 134);
            this.btn_motorRW.Margin = new System.Windows.Forms.Padding(4);
            this.btn_motorRW.Name = "btn_motorRW";
            this.btn_motorRW.Size = new System.Drawing.Size(204, 60);
            this.btn_motorRW.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_motorRW.TabIndex = 27;
            this.btn_motorRW.Text = "MotorRW";
            this.btn_motorRW.Click += new System.EventHandler(this.btn_motorRW_Click);
            // 
            // gp_motorRW
            // 
            this.gp_motorRW.AutoScroll = true;
            this.gp_motorRW.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_motorRW.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_motorRW.Controls.Add(this.txt_gprw_motorReprotInterval);
            this.gp_motorRW.Controls.Add(this.labelX12);
            this.gp_motorRW.Controls.Add(this.dgv_motorParameter);
            this.gp_motorRW.Controls.Add(this.btn_gprw_clearDgv_motorParameter);
            this.gp_motorRW.Controls.Add(this.btn_gprw_modifyMotorID);
            this.gp_motorRW.Controls.Add(this.txt_gprw_destinationMotorID);
            this.gp_motorRW.Controls.Add(this.labelX11);
            this.gp_motorRW.Controls.Add(this.txt_gprw_soureMotorID);
            this.gp_motorRW.Controls.Add(this.labelX10);
            this.gp_motorRW.Controls.Add(this.chk_gprw_isParameterHold);
            this.gp_motorRW.Controls.Add(this.btn_gprw_motorParameterRead);
            this.gp_motorRW.Controls.Add(this.btn_gprw_SetMotorReportInterval);
            this.gp_motorRW.Controls.Add(this.labelX5);
            this.gp_motorRW.Controls.Add(this.btn_gprw_UnEnableMotorReport);
            this.gp_motorRW.Controls.Add(this.btn_gprw_motorEnable);
            this.gp_motorRW.Controls.Add(this.btn_gprw_EnableMotorReport);
            this.gp_motorRW.Controls.Add(this.txt_gprw_motorID);
            this.gp_motorRW.Controls.Add(this.btn_clearMotorError);
            this.gp_motorRW.Controls.Add(this.btn_gprw_motorUnEnable);
            this.gp_motorRW.Controls.Add(this.cmb_gprw_SetMotorParameter);
            this.gp_motorRW.Controls.Add(this.btn_gprw_motorZero);
            this.gp_motorRW.Controls.Add(this.btn_gprw_getAllMotor);
            this.gp_motorRW.Controls.Add(this.labelX6);
            this.gp_motorRW.Controls.Add(this.labelX7);
            this.gp_motorRW.Controls.Add(this.cmb_gprw_motorRunMode);
            this.gp_motorRW.Controls.Add(this.btn_MotorRunModeChange);
            this.gp_motorRW.Controls.Add(this.labelX9);
            this.gp_motorRW.Controls.Add(this.txt_gprw_SetMotorParameter);
            this.gp_motorRW.Controls.Add(this.labelX8);
            this.gp_motorRW.Controls.Add(this.btn_gprw_SetMotorParameter);
            this.gp_motorRW.Location = new System.Drawing.Point(200, 176);
            this.gp_motorRW.Margin = new System.Windows.Forms.Padding(4);
            this.gp_motorRW.Name = "gp_motorRW";
            this.gp_motorRW.Size = new System.Drawing.Size(1760, 816);
            // 
            // 
            // 
            this.gp_motorRW.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_motorRW.Style.BackColorGradientAngle = 90;
            this.gp_motorRW.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_motorRW.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorRW.Style.BorderBottomWidth = 1;
            this.gp_motorRW.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_motorRW.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorRW.Style.BorderLeftWidth = 1;
            this.gp_motorRW.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorRW.Style.BorderRightWidth = 1;
            this.gp_motorRW.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorRW.Style.BorderTopWidth = 1;
            this.gp_motorRW.Style.CornerDiameter = 4;
            this.gp_motorRW.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_motorRW.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_motorRW.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_motorRW.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_motorRW.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_motorRW.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_motorRW.TabIndex = 34;
            this.gp_motorRW.Text = "groupPanel4";
            this.gp_motorRW.Visible = false;
            this.gp_motorRW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gp_motorRW_MouseDown);
            this.gp_motorRW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gp_motorRW_MouseMove);
            this.gp_motorRW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gp_motorRW_MouseUp);
            // 
            // btn_gprw_modifyMotorID
            // 
            this.btn_gprw_modifyMotorID.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_modifyMotorID.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_modifyMotorID.Location = new System.Drawing.Point(512, 548);
            this.btn_gprw_modifyMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_modifyMotorID.Name = "btn_gprw_modifyMotorID";
            this.btn_gprw_modifyMotorID.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_modifyMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_modifyMotorID.TabIndex = 41;
            this.btn_gprw_modifyMotorID.Text = "执行修改电机ID";
            this.btn_gprw_modifyMotorID.Click += new System.EventHandler(this.btn_gprw_modifyMotorID_Click);
            // 
            // txt_gprw_destinationMotorID
            // 
            // 
            // 
            // 
            this.txt_gprw_destinationMotorID.Border.Class = "TextBoxBorder";
            this.txt_gprw_destinationMotorID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_destinationMotorID.Location = new System.Drawing.Point(332, 558);
            this.txt_gprw_destinationMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_destinationMotorID.Multiline = true;
            this.txt_gprw_destinationMotorID.Name = "txt_gprw_destinationMotorID";
            this.txt_gprw_destinationMotorID.Size = new System.Drawing.Size(108, 48);
            this.txt_gprw_destinationMotorID.TabIndex = 40;
            this.txt_gprw_destinationMotorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(244, 558);
            this.labelX11.Margin = new System.Windows.Forms.Padding(4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(108, 48);
            this.labelX11.TabIndex = 39;
            this.labelX11.Text = "修改为：";
            // 
            // txt_gprw_soureMotorID
            // 
            // 
            // 
            // 
            this.txt_gprw_soureMotorID.Border.Class = "TextBoxBorder";
            this.txt_gprw_soureMotorID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_soureMotorID.Location = new System.Drawing.Point(126, 558);
            this.txt_gprw_soureMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_soureMotorID.Multiline = true;
            this.txt_gprw_soureMotorID.Name = "txt_gprw_soureMotorID";
            this.txt_gprw_soureMotorID.Size = new System.Drawing.Size(108, 48);
            this.txt_gprw_soureMotorID.TabIndex = 38;
            this.txt_gprw_soureMotorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(20, 558);
            this.labelX10.Margin = new System.Windows.Forms.Padding(4);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(100, 48);
            this.labelX10.TabIndex = 37;
            this.labelX10.Text = "电机id:";
            // 
            // chk_gprw_isParameterHold
            // 
            this.chk_gprw_isParameterHold.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_gprw_isParameterHold.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_gprw_isParameterHold.Location = new System.Drawing.Point(38, 198);
            this.chk_gprw_isParameterHold.Margin = new System.Windows.Forms.Padding(4);
            this.chk_gprw_isParameterHold.Name = "chk_gprw_isParameterHold";
            this.chk_gprw_isParameterHold.Size = new System.Drawing.Size(456, 42);
            this.chk_gprw_isParameterHold.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_gprw_isParameterHold.TabIndex = 36;
            this.chk_gprw_isParameterHold.Text = "写入到Hold区域(会导致电机丢失使能)";
            // 
            // btn_gprw_motorParameterRead
            // 
            this.btn_gprw_motorParameterRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorParameterRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorParameterRead.Location = new System.Drawing.Point(1404, 20);
            this.btn_gprw_motorParameterRead.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorParameterRead.Name = "btn_gprw_motorParameterRead";
            this.btn_gprw_motorParameterRead.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorParameterRead.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorParameterRead.TabIndex = 35;
            this.btn_gprw_motorParameterRead.Text = "参数读取";
            this.btn_gprw_motorParameterRead.Click += new System.EventHandler(this.btn_gprw_motorParameterRead_Click);
            // 
            // btn_gprw_SetMotorReportInterval
            // 
            this.btn_gprw_SetMotorReportInterval.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_SetMotorReportInterval.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_SetMotorReportInterval.Location = new System.Drawing.Point(293, 404);
            this.btn_gprw_SetMotorReportInterval.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_SetMotorReportInterval.Name = "btn_gprw_SetMotorReportInterval";
            this.btn_gprw_SetMotorReportInterval.Size = new System.Drawing.Size(126, 124);
            this.btn_gprw_SetMotorReportInterval.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_SetMotorReportInterval.TabIndex = 33;
            this.btn_gprw_SetMotorReportInterval.Text = "设定上报频率";
            this.btn_gprw_SetMotorReportInterval.Click += new System.EventHandler(this.btn_gprw_SetMotorReportInterval_Click);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(64, 16);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(102, 48);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "motorID:";
            // 
            // btn_gprw_UnEnableMotorReport
            // 
            this.btn_gprw_UnEnableMotorReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_UnEnableMotorReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_UnEnableMotorReport.Location = new System.Drawing.Point(443, 404);
            this.btn_gprw_UnEnableMotorReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_UnEnableMotorReport.Name = "btn_gprw_UnEnableMotorReport";
            this.btn_gprw_UnEnableMotorReport.Size = new System.Drawing.Size(126, 124);
            this.btn_gprw_UnEnableMotorReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_UnEnableMotorReport.TabIndex = 32;
            this.btn_gprw_UnEnableMotorReport.Text = "关闭电机上报";
            this.btn_gprw_UnEnableMotorReport.Click += new System.EventHandler(this.btn_gprw_UnEnableMotorReport_Click);
            // 
            // btn_gprw_motorEnable
            // 
            this.btn_gprw_motorEnable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorEnable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorEnable.Location = new System.Drawing.Point(512, 20);
            this.btn_gprw_motorEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorEnable.Name = "btn_gprw_motorEnable";
            this.btn_gprw_motorEnable.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorEnable.TabIndex = 10;
            this.btn_gprw_motorEnable.Text = "上使能";
            this.btn_gprw_motorEnable.Click += new System.EventHandler(this.btn_motorEnable_Click);
            // 
            // btn_gprw_EnableMotorReport
            // 
            this.btn_gprw_EnableMotorReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_EnableMotorReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_EnableMotorReport.Location = new System.Drawing.Point(588, 404);
            this.btn_gprw_EnableMotorReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_EnableMotorReport.Name = "btn_gprw_EnableMotorReport";
            this.btn_gprw_EnableMotorReport.Size = new System.Drawing.Size(126, 124);
            this.btn_gprw_EnableMotorReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_EnableMotorReport.TabIndex = 31;
            this.btn_gprw_EnableMotorReport.Text = "开启电机上报";
            this.btn_gprw_EnableMotorReport.Click += new System.EventHandler(this.btn_gprw_EnableMotorReport_Click);
            // 
            // txt_gprw_motorID
            // 
            // 
            // 
            // 
            this.txt_gprw_motorID.Border.Class = "TextBoxBorder";
            this.txt_gprw_motorID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_motorID.Location = new System.Drawing.Point(176, 24);
            this.txt_gprw_motorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_motorID.Multiline = true;
            this.txt_gprw_motorID.Name = "txt_gprw_motorID";
            this.txt_gprw_motorID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gprw_motorID.Size = new System.Drawing.Size(324, 84);
            this.txt_gprw_motorID.TabIndex = 16;
            // 
            // btn_clearMotorError
            // 
            this.btn_clearMotorError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearMotorError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearMotorError.Location = new System.Drawing.Point(1184, 20);
            this.btn_clearMotorError.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearMotorError.Name = "btn_clearMotorError";
            this.btn_clearMotorError.Size = new System.Drawing.Size(204, 60);
            this.btn_clearMotorError.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clearMotorError.TabIndex = 30;
            this.btn_clearMotorError.Text = "故障清除";
            this.btn_clearMotorError.Click += new System.EventHandler(this.btn_clearMotorError_Click);
            // 
            // btn_gprw_motorUnEnable
            // 
            this.btn_gprw_motorUnEnable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorUnEnable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorUnEnable.Location = new System.Drawing.Point(736, 20);
            this.btn_gprw_motorUnEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorUnEnable.Name = "btn_gprw_motorUnEnable";
            this.btn_gprw_motorUnEnable.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorUnEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorUnEnable.TabIndex = 17;
            this.btn_gprw_motorUnEnable.Text = "下使能";
            this.btn_gprw_motorUnEnable.Click += new System.EventHandler(this.btn_motorUnEnable_Click);
            // 
            // cmb_gprw_SetMotorParameter
            // 
            this.cmb_gprw_SetMotorParameter.DisplayMember = "Text";
            this.cmb_gprw_SetMotorParameter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_gprw_SetMotorParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gprw_SetMotorParameter.FormattingEnabled = true;
            this.cmb_gprw_SetMotorParameter.ItemHeight = 29;
            this.cmb_gprw_SetMotorParameter.Location = new System.Drawing.Point(240, 262);
            this.cmb_gprw_SetMotorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_gprw_SetMotorParameter.Name = "cmb_gprw_SetMotorParameter";
            this.cmb_gprw_SetMotorParameter.Size = new System.Drawing.Size(256, 35);
            this.cmb_gprw_SetMotorParameter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_gprw_SetMotorParameter.TabIndex = 22;
            // 
            // btn_gprw_motorZero
            // 
            this.btn_gprw_motorZero.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorZero.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorZero.Location = new System.Drawing.Point(960, 20);
            this.btn_gprw_motorZero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorZero.Name = "btn_gprw_motorZero";
            this.btn_gprw_motorZero.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorZero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorZero.TabIndex = 18;
            this.btn_gprw_motorZero.Text = "置0位";
            this.btn_gprw_motorZero.Click += new System.EventHandler(this.btn_motorZero_Click);
            // 
            // btn_gprw_getAllMotor
            // 
            this.btn_gprw_getAllMotor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_getAllMotor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_getAllMotor.Location = new System.Drawing.Point(68, 68);
            this.btn_gprw_getAllMotor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_getAllMotor.Name = "btn_gprw_getAllMotor";
            this.btn_gprw_getAllMotor.Size = new System.Drawing.Size(102, 40);
            this.btn_gprw_getAllMotor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_getAllMotor.TabIndex = 29;
            this.btn_gprw_getAllMotor.Text = "ALL";
            this.btn_gprw_getAllMotor.Click += new System.EventHandler(this.btn_gprw_getAllMotor_Click);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(68, 134);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(180, 48);
            this.labelX6.TabIndex = 19;
            this.labelX6.Text = "motorRunMode:";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(64, 262);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(180, 48);
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "设置电机数据:";
            // 
            // cmb_gprw_motorRunMode
            // 
            this.cmb_gprw_motorRunMode.DisplayMember = "Text";
            this.cmb_gprw_motorRunMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_gprw_motorRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gprw_motorRunMode.FormattingEnabled = true;
            this.cmb_gprw_motorRunMode.ItemHeight = 29;
            this.cmb_gprw_motorRunMode.Location = new System.Drawing.Point(244, 134);
            this.cmb_gprw_motorRunMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_gprw_motorRunMode.Name = "cmb_gprw_motorRunMode";
            this.cmb_gprw_motorRunMode.Size = new System.Drawing.Size(256, 35);
            this.cmb_gprw_motorRunMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_gprw_motorRunMode.TabIndex = 20;
            // 
            // btn_MotorRunModeChange
            // 
            this.btn_MotorRunModeChange.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_MotorRunModeChange.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_MotorRunModeChange.Location = new System.Drawing.Point(512, 124);
            this.btn_MotorRunModeChange.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MotorRunModeChange.Name = "btn_MotorRunModeChange";
            this.btn_MotorRunModeChange.Size = new System.Drawing.Size(204, 60);
            this.btn_MotorRunModeChange.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_MotorRunModeChange.TabIndex = 28;
            this.btn_MotorRunModeChange.Text = "设定运行模式";
            this.btn_MotorRunModeChange.Click += new System.EventHandler(this.btn_MotorRunModeChange_Click);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.ForeColor = System.Drawing.Color.Red;
            this.labelX9.Location = new System.Drawing.Point(1696, 4);
            this.labelX9.Margin = new System.Windows.Forms.Padding(4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(52, 48);
            this.labelX9.TabIndex = 26;
            this.labelX9.Text = "×";
            this.labelX9.Click += new System.EventHandler(this.labelX9_Click);
            // 
            // txt_gprw_SetMotorParameter
            // 
            // 
            // 
            // 
            this.txt_gprw_SetMotorParameter.Border.Class = "TextBoxBorder";
            this.txt_gprw_SetMotorParameter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_SetMotorParameter.Location = new System.Drawing.Point(240, 336);
            this.txt_gprw_SetMotorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_SetMotorParameter.Multiline = true;
            this.txt_gprw_SetMotorParameter.Name = "txt_gprw_SetMotorParameter";
            this.txt_gprw_SetMotorParameter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gprw_SetMotorParameter.Size = new System.Drawing.Size(256, 48);
            this.txt_gprw_SetMotorParameter.TabIndex = 25;
            this.txt_gprw_SetMotorParameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_SetMotorParameter_KeyPress);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(64, 336);
            this.labelX8.Margin = new System.Windows.Forms.Padding(4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(180, 48);
            this.labelX8.TabIndex = 24;
            this.labelX8.Text = "电机设定值:";
            // 
            // btn_gprw_SetMotorParameter
            // 
            this.btn_gprw_SetMotorParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_SetMotorParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_SetMotorParameter.Location = new System.Drawing.Point(512, 214);
            this.btn_gprw_SetMotorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_SetMotorParameter.Name = "btn_gprw_SetMotorParameter";
            this.btn_gprw_SetMotorParameter.Size = new System.Drawing.Size(204, 172);
            this.btn_gprw_SetMotorParameter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_SetMotorParameter.TabIndex = 23;
            this.btn_gprw_SetMotorParameter.Text = "设定电机参数";
            this.btn_gprw_SetMotorParameter.Click += new System.EventHandler(this.btn_gprw_SetMotorParameter_Click);
            // 
            // btn_motorScanner
            // 
            this.btn_motorScanner.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_motorScanner.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_motorScanner.Location = new System.Drawing.Point(546, 134);
            this.btn_motorScanner.Margin = new System.Windows.Forms.Padding(4);
            this.btn_motorScanner.Name = "btn_motorScanner";
            this.btn_motorScanner.Size = new System.Drawing.Size(204, 60);
            this.btn_motorScanner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_motorScanner.TabIndex = 35;
            this.btn_motorScanner.Text = "MotorScanner";
            this.btn_motorScanner.Click += new System.EventHandler(this.btn_motorScanner_Click);
            // 
            // btn_gprw_clearDgv_motorParameter
            // 
            this.btn_gprw_clearDgv_motorParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_clearDgv_motorParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_clearDgv_motorParameter.Location = new System.Drawing.Point(1404, 630);
            this.btn_gprw_clearDgv_motorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_clearDgv_motorParameter.Name = "btn_gprw_clearDgv_motorParameter";
            this.btn_gprw_clearDgv_motorParameter.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_clearDgv_motorParameter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_clearDgv_motorParameter.TabIndex = 43;
            this.btn_gprw_clearDgv_motorParameter.Text = "电机参数清除";
            this.btn_gprw_clearDgv_motorParameter.Click += new System.EventHandler(this.btn_gprw_clearDgv_motorParameter_Click);
            // 
            // dgv_motorParameter
            // 
            this.dgv_motorParameter.AllowUserToAddRows = false;
            this.dgv_motorParameter.AllowUserToDeleteRows = false;
            this.dgv_motorParameter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_motorParameter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_motorParameter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_motorParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_motorParameter.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_motorParameter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_motorParameter.Location = new System.Drawing.Point(754, 134);
            this.dgv_motorParameter.Name = "dgv_motorParameter";
            this.dgv_motorParameter.RowHeadersVisible = false;
            this.dgv_motorParameter.RowHeadersWidth = 82;
            this.dgv_motorParameter.RowTemplate.Height = 37;
            this.dgv_motorParameter.Size = new System.Drawing.Size(854, 472);
            this.dgv_motorParameter.TabIndex = 44;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(64, 415);
            this.labelX12.Margin = new System.Windows.Forms.Padding(4);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(180, 48);
            this.labelX12.TabIndex = 45;
            this.labelX12.Text = "上报频率设定值:";
            // 
            // txt_gprw_motorReprotInterval
            // 
            // 
            // 
            // 
            this.txt_gprw_motorReprotInterval.Border.Class = "TextBoxBorder";
            this.txt_gprw_motorReprotInterval.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_motorReprotInterval.Location = new System.Drawing.Point(58, 480);
            this.txt_gprw_motorReprotInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_motorReprotInterval.Multiline = true;
            this.txt_gprw_motorReprotInterval.Name = "txt_gprw_motorReprotInterval";
            this.txt_gprw_motorReprotInterval.Size = new System.Drawing.Size(186, 48);
            this.txt_gprw_motorReprotInterval.TabIndex = 46;
            this.txt_gprw_motorReprotInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2180, 1064);
            this.Controls.Add(this.btn_motorScanner);
            this.Controls.Add(this.gp_motorRW);
            this.Controls.Add(this.btn_motorRW);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.btn_saveShowMessage);
            this.Controls.Add(this.btn_clearShowMessage);
            this.Controls.Add(this.groupPanel2);
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
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.gp_motorRW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorParameter)).EndInit();
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
        private DevComponents.DotNetBar.Controls.TextBoxX txt_batchCan;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_idFilter;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_filterByMotorID;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_OnlyFeedBackData;
        private DevComponents.DotNetBar.ButtonX btn_batchCanAnalysis;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btn_clearShowMessage;
        private DevComponents.DotNetBar.ButtonX btn_saveShowMessage;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MotorAckData;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btn_saveMotorAckData;
        private DevComponents.DotNetBar.ButtonX btn_motorRW;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_motorRW;
        private DevComponents.DotNetBar.ButtonX btn_gprw_SetMotorReportInterval;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btn_gprw_UnEnableMotorReport;
        private DevComponents.DotNetBar.ButtonX btn_gprw_motorEnable;
        private DevComponents.DotNetBar.ButtonX btn_gprw_EnableMotorReport;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_motorID;
        private DevComponents.DotNetBar.ButtonX btn_clearMotorError;
        private DevComponents.DotNetBar.ButtonX btn_gprw_motorUnEnable;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_gprw_SetMotorParameter;
        private DevComponents.DotNetBar.ButtonX btn_gprw_motorZero;
        private DevComponents.DotNetBar.ButtonX btn_gprw_getAllMotor;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_gprw_motorRunMode;
        private DevComponents.DotNetBar.ButtonX btn_MotorRunModeChange;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_SetMotorParameter;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btn_gprw_SetMotorParameter;
        private DevComponents.DotNetBar.ButtonX btn_gprw_motorParameterRead;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_gprw_isParameterHold;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_destinationMotorID;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_soureMotorID;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ButtonX btn_gprw_modifyMotorID;
        private DevComponents.DotNetBar.ButtonX btn_motorScanner;
        private DevComponents.DotNetBar.ButtonX btn_gprw_clearDgv_motorParameter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_motorParameter;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_motorReprotInterval;
        private DevComponents.DotNetBar.LabelX labelX12;
    }
}

