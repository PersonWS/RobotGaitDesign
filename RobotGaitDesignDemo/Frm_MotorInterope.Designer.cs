namespace RobotGaitDesignDemo
{
    partial class Frm_MotorInterope
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.chk_gprw_motorZeroOffsetProfessional = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_gprw_motorZeroOffset = new DevComponents.DotNetBar.ButtonX();
            this.txt_gprw_motorZeroOffset = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_gprw_motorReprotInterval = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.dgv_motorParameter = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_gprw_clearDgv_motorParameter = new DevComponents.DotNetBar.ButtonX();
            this.btn_gprw_modifyMotorID = new DevComponents.DotNetBar.ButtonX();
            this.gp_singleMotor = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txt_gprw_soureMotorID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txt_gprw_destinationMotorID = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.txt_gprw_SetMotorParameter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btn_gprw_SetMotorParameter = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorParameter)).BeginInit();
            this.gp_singleMotor.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.ForeColor = System.Drawing.Color.Red;
            this.labelX13.Location = new System.Drawing.Point(16, 306);
            this.labelX13.Margin = new System.Windows.Forms.Padding(4);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(225, 48);
            this.labelX13.TabIndex = 81;
            this.labelX13.Text = "零位角度(deg)偏置:";
            // 
            // chk_gprw_motorZeroOffsetProfessional
            // 
            this.chk_gprw_motorZeroOffsetProfessional.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_gprw_motorZeroOffsetProfessional.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_gprw_motorZeroOffsetProfessional.Location = new System.Drawing.Point(17, 76);
            this.chk_gprw_motorZeroOffsetProfessional.Margin = new System.Windows.Forms.Padding(4);
            this.chk_gprw_motorZeroOffsetProfessional.Name = "chk_gprw_motorZeroOffsetProfessional";
            this.chk_gprw_motorZeroOffsetProfessional.Size = new System.Drawing.Size(170, 58);
            this.chk_gprw_motorZeroOffsetProfessional.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_gprw_motorZeroOffsetProfessional.TabIndex = 84;
            this.chk_gprw_motorZeroOffsetProfessional.Text = "专家模式";
            this.chk_gprw_motorZeroOffsetProfessional.CheckedChanged += new System.EventHandler(this.chk_gprw_motorZeroOffsetProfessional_CheckedChanged);
            this.chk_gprw_motorZeroOffsetProfessional.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chk_gprw_motorZeroOffsetProfessional_MouseUp);
            // 
            // btn_gprw_motorZeroOffset
            // 
            this.btn_gprw_motorZeroOffset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorZeroOffset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorZeroOffset.Location = new System.Drawing.Point(509, 306);
            this.btn_gprw_motorZeroOffset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorZeroOffset.Name = "btn_gprw_motorZeroOffset";
            this.btn_gprw_motorZeroOffset.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorZeroOffset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorZeroOffset.TabIndex = 83;
            this.btn_gprw_motorZeroOffset.Text = "零位偏置[专家功能][谨慎使用]";
            this.btn_gprw_motorZeroOffset.TextColor = System.Drawing.Color.Red;
            this.btn_gprw_motorZeroOffset.Click += new System.EventHandler(this.btn_gprw_motorZeroOffset_Click);
            // 
            // txt_gprw_motorZeroOffset
            // 
            // 
            // 
            // 
            this.txt_gprw_motorZeroOffset.Border.Class = "TextBoxBorder";
            this.txt_gprw_motorZeroOffset.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_motorZeroOffset.Location = new System.Drawing.Point(235, 306);
            this.txt_gprw_motorZeroOffset.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_motorZeroOffset.Multiline = true;
            this.txt_gprw_motorZeroOffset.Name = "txt_gprw_motorZeroOffset";
            this.txt_gprw_motorZeroOffset.Size = new System.Drawing.Size(258, 48);
            this.txt_gprw_motorZeroOffset.TabIndex = 82;
            this.txt_gprw_motorZeroOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_SetMotorParameter_KeyPress);
            // 
            // txt_gprw_motorReprotInterval
            // 
            // 
            // 
            // 
            this.txt_gprw_motorReprotInterval.Border.Class = "TextBoxBorder";
            this.txt_gprw_motorReprotInterval.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_motorReprotInterval.Location = new System.Drawing.Point(29, 263);
            this.txt_gprw_motorReprotInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_motorReprotInterval.Multiline = true;
            this.txt_gprw_motorReprotInterval.Name = "txt_gprw_motorReprotInterval";
            this.txt_gprw_motorReprotInterval.Size = new System.Drawing.Size(186, 48);
            this.txt_gprw_motorReprotInterval.TabIndex = 80;
            this.txt_gprw_motorReprotInterval.Text = "200";
            this.txt_gprw_motorReprotInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_motorReprotInterval_KeyPress);
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(9, 198);
            this.labelX12.Margin = new System.Windows.Forms.Padding(4);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(247, 48);
            this.labelX12.TabIndex = 79;
            this.labelX12.Text = "上报频率设定值:";
            // 
            // dgv_motorParameter
            // 
            this.dgv_motorParameter.AllowUserToAddRows = false;
            this.dgv_motorParameter.AllowUserToDeleteRows = false;
            this.dgv_motorParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_motorParameter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_motorParameter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_motorParameter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_motorParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_motorParameter.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_motorParameter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_motorParameter.Location = new System.Drawing.Point(3, 120);
            this.dgv_motorParameter.Name = "dgv_motorParameter";
            this.dgv_motorParameter.RowHeadersVisible = false;
            this.dgv_motorParameter.RowHeadersWidth = 82;
            this.dgv_motorParameter.RowTemplate.Height = 37;
            this.dgv_motorParameter.Size = new System.Drawing.Size(727, 789);
            this.dgv_motorParameter.TabIndex = 78;
            // 
            // btn_gprw_clearDgv_motorParameter
            // 
            this.btn_gprw_clearDgv_motorParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_clearDgv_motorParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_clearDgv_motorParameter.Location = new System.Drawing.Point(265, 32);
            this.btn_gprw_clearDgv_motorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_clearDgv_motorParameter.Name = "btn_gprw_clearDgv_motorParameter";
            this.btn_gprw_clearDgv_motorParameter.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_clearDgv_motorParameter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_clearDgv_motorParameter.TabIndex = 77;
            this.btn_gprw_clearDgv_motorParameter.Text = "电机参数表清除";
            this.btn_gprw_clearDgv_motorParameter.Click += new System.EventHandler(this.btn_gprw_clearDgv_motorParameter_Click);
            // 
            // btn_gprw_modifyMotorID
            // 
            this.btn_gprw_modifyMotorID.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_modifyMotorID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gprw_modifyMotorID.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_modifyMotorID.Location = new System.Drawing.Point(509, 18);
            this.btn_gprw_modifyMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_modifyMotorID.Name = "btn_gprw_modifyMotorID";
            this.btn_gprw_modifyMotorID.Size = new System.Drawing.Size(206, 60);
            this.btn_gprw_modifyMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_modifyMotorID.TabIndex = 76;
            this.btn_gprw_modifyMotorID.Text = "执行修改电机ID";
            this.btn_gprw_modifyMotorID.Click += new System.EventHandler(this.btn_gprw_modifyMotorID_Click);
            // 
            // gp_singleMotor
            // 
            this.gp_singleMotor.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_singleMotor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_singleMotor.Controls.Add(this.txt_gprw_destinationMotorID);
            this.gp_singleMotor.Controls.Add(this.labelX10);
            this.gp_singleMotor.Controls.Add(this.txt_gprw_soureMotorID);
            this.gp_singleMotor.Controls.Add(this.labelX11);
            this.gp_singleMotor.Controls.Add(this.btn_gprw_modifyMotorID);
            this.gp_singleMotor.Location = new System.Drawing.Point(15, 925);
            this.gp_singleMotor.Name = "gp_singleMotor";
            this.gp_singleMotor.Size = new System.Drawing.Size(736, 131);
            // 
            // 
            // 
            this.gp_singleMotor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_singleMotor.Style.BackColorGradientAngle = 90;
            this.gp_singleMotor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_singleMotor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_singleMotor.Style.BorderBottomWidth = 1;
            this.gp_singleMotor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_singleMotor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_singleMotor.Style.BorderLeftWidth = 1;
            this.gp_singleMotor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_singleMotor.Style.BorderRightWidth = 1;
            this.gp_singleMotor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_singleMotor.Style.BorderTopWidth = 1;
            this.gp_singleMotor.Style.CornerDiameter = 4;
            this.gp_singleMotor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_singleMotor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_singleMotor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_singleMotor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_singleMotor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_singleMotor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_singleMotor.TabIndex = 86;
            this.gp_singleMotor.Text = "单电机配置";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(4, 18);
            this.labelX10.Margin = new System.Windows.Forms.Padding(4);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(125, 48);
            this.labelX10.TabIndex = 72;
            this.labelX10.Text = "电机id:";
            // 
            // txt_gprw_soureMotorID
            // 
            // 
            // 
            // 
            this.txt_gprw_soureMotorID.Border.Class = "TextBoxBorder";
            this.txt_gprw_soureMotorID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_soureMotorID.Location = new System.Drawing.Point(135, 18);
            this.txt_gprw_soureMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_soureMotorID.Multiline = true;
            this.txt_gprw_soureMotorID.Name = "txt_gprw_soureMotorID";
            this.txt_gprw_soureMotorID.Size = new System.Drawing.Size(108, 48);
            this.txt_gprw_soureMotorID.TabIndex = 73;
            this.txt_gprw_soureMotorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_motorReprotInterval_KeyPress);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(253, 18);
            this.labelX11.Margin = new System.Windows.Forms.Padding(4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(137, 48);
            this.labelX11.TabIndex = 74;
            this.labelX11.Text = "修改为：";
            // 
            // txt_gprw_destinationMotorID
            // 
            // 
            // 
            // 
            this.txt_gprw_destinationMotorID.Border.Class = "TextBoxBorder";
            this.txt_gprw_destinationMotorID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_destinationMotorID.Location = new System.Drawing.Point(355, 18);
            this.txt_gprw_destinationMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_destinationMotorID.Multiline = true;
            this.txt_gprw_destinationMotorID.Name = "txt_gprw_destinationMotorID";
            this.txt_gprw_destinationMotorID.Size = new System.Drawing.Size(131, 48);
            this.txt_gprw_destinationMotorID.TabIndex = 75;
            this.txt_gprw_destinationMotorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_motorReprotInterval_KeyPress);
            // 
            // chk_gprw_isParameterHold
            // 
            this.chk_gprw_isParameterHold.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_gprw_isParameterHold.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_gprw_isParameterHold.Location = new System.Drawing.Point(35, 97);
            this.chk_gprw_isParameterHold.Margin = new System.Windows.Forms.Padding(4);
            this.chk_gprw_isParameterHold.Name = "chk_gprw_isParameterHold";
            this.chk_gprw_isParameterHold.Size = new System.Drawing.Size(456, 42);
            this.chk_gprw_isParameterHold.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_gprw_isParameterHold.TabIndex = 71;
            this.chk_gprw_isParameterHold.Text = "写入到Hold区域(会导致电机丢失使能)";
            // 
            // btn_gprw_motorParameterRead
            // 
            this.btn_gprw_motorParameterRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorParameterRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorParameterRead.Location = new System.Drawing.Point(30, 32);
            this.btn_gprw_motorParameterRead.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorParameterRead.Name = "btn_gprw_motorParameterRead";
            this.btn_gprw_motorParameterRead.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorParameterRead.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorParameterRead.TabIndex = 70;
            this.btn_gprw_motorParameterRead.Text = "参数读取";
            this.btn_gprw_motorParameterRead.Click += new System.EventHandler(this.btn_gprw_motorParameterRead_Click);
            // 
            // btn_gprw_SetMotorReportInterval
            // 
            this.btn_gprw_SetMotorReportInterval.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_SetMotorReportInterval.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_SetMotorReportInterval.Location = new System.Drawing.Point(264, 187);
            this.btn_gprw_SetMotorReportInterval.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_SetMotorReportInterval.Name = "btn_gprw_SetMotorReportInterval";
            this.btn_gprw_SetMotorReportInterval.Size = new System.Drawing.Size(126, 124);
            this.btn_gprw_SetMotorReportInterval.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_SetMotorReportInterval.TabIndex = 69;
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
            this.labelX5.Location = new System.Drawing.Point(27, 36);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(139, 48);
            this.labelX5.TabIndex = 52;
            this.labelX5.Text = "motorID:";
            // 
            // btn_gprw_UnEnableMotorReport
            // 
            this.btn_gprw_UnEnableMotorReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_UnEnableMotorReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_UnEnableMotorReport.Location = new System.Drawing.Point(414, 187);
            this.btn_gprw_UnEnableMotorReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_UnEnableMotorReport.Name = "btn_gprw_UnEnableMotorReport";
            this.btn_gprw_UnEnableMotorReport.Size = new System.Drawing.Size(126, 124);
            this.btn_gprw_UnEnableMotorReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_UnEnableMotorReport.TabIndex = 68;
            this.btn_gprw_UnEnableMotorReport.Text = "关闭电机上报";
            this.btn_gprw_UnEnableMotorReport.Click += new System.EventHandler(this.btn_gprw_UnEnableMotorReport_Click);
            // 
            // btn_gprw_motorEnable
            // 
            this.btn_gprw_motorEnable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorEnable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorEnable.Location = new System.Drawing.Point(29, 19);
            this.btn_gprw_motorEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorEnable.Name = "btn_gprw_motorEnable";
            this.btn_gprw_motorEnable.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorEnable.TabIndex = 51;
            this.btn_gprw_motorEnable.Text = "上使能";
            this.btn_gprw_motorEnable.Click += new System.EventHandler(this.btn_gprw_motorEnable_Click);
            // 
            // btn_gprw_EnableMotorReport
            // 
            this.btn_gprw_EnableMotorReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_EnableMotorReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_EnableMotorReport.Location = new System.Drawing.Point(559, 187);
            this.btn_gprw_EnableMotorReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_EnableMotorReport.Name = "btn_gprw_EnableMotorReport";
            this.btn_gprw_EnableMotorReport.Size = new System.Drawing.Size(126, 124);
            this.btn_gprw_EnableMotorReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_EnableMotorReport.TabIndex = 67;
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
            this.txt_gprw_motorID.Location = new System.Drawing.Point(195, 36);
            this.txt_gprw_motorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_motorID.Multiline = true;
            this.txt_gprw_motorID.Name = "txt_gprw_motorID";
            this.txt_gprw_motorID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gprw_motorID.Size = new System.Drawing.Size(303, 84);
            this.txt_gprw_motorID.TabIndex = 53;
            // 
            // btn_clearMotorError
            // 
            this.btn_clearMotorError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearMotorError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearMotorError.Location = new System.Drawing.Point(489, 102);
            this.btn_clearMotorError.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearMotorError.Name = "btn_clearMotorError";
            this.btn_clearMotorError.Size = new System.Drawing.Size(204, 60);
            this.btn_clearMotorError.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clearMotorError.TabIndex = 66;
            this.btn_clearMotorError.Text = "故障清除";
            this.btn_clearMotorError.Click += new System.EventHandler(this.btn_clearMotorError_Click);
            // 
            // btn_gprw_motorUnEnable
            // 
            this.btn_gprw_motorUnEnable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorUnEnable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorUnEnable.Location = new System.Drawing.Point(262, 19);
            this.btn_gprw_motorUnEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorUnEnable.Name = "btn_gprw_motorUnEnable";
            this.btn_gprw_motorUnEnable.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorUnEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorUnEnable.TabIndex = 54;
            this.btn_gprw_motorUnEnable.Text = "下使能";
            this.btn_gprw_motorUnEnable.Click += new System.EventHandler(this.btn_gprw_motorUnEnable_Click);
            // 
            // cmb_gprw_SetMotorParameter
            // 
            this.cmb_gprw_SetMotorParameter.DisplayMember = "Text";
            this.cmb_gprw_SetMotorParameter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_gprw_SetMotorParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gprw_SetMotorParameter.FormattingEnabled = true;
            this.cmb_gprw_SetMotorParameter.ItemHeight = 24;
            this.cmb_gprw_SetMotorParameter.Location = new System.Drawing.Point(237, 161);
            this.cmb_gprw_SetMotorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_gprw_SetMotorParameter.Name = "cmb_gprw_SetMotorParameter";
            this.cmb_gprw_SetMotorParameter.Size = new System.Drawing.Size(256, 30);
            this.cmb_gprw_SetMotorParameter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_gprw_SetMotorParameter.TabIndex = 59;
            // 
            // btn_gprw_motorZero
            // 
            this.btn_gprw_motorZero.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_motorZero.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_motorZero.Location = new System.Drawing.Point(489, 15);
            this.btn_gprw_motorZero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_motorZero.Name = "btn_gprw_motorZero";
            this.btn_gprw_motorZero.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_motorZero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_motorZero.TabIndex = 55;
            this.btn_gprw_motorZero.Text = "置0位";
            this.btn_gprw_motorZero.Click += new System.EventHandler(this.btn_gprw_motorZero_Click);
            // 
            // btn_gprw_getAllMotor
            // 
            this.btn_gprw_getAllMotor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_getAllMotor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_getAllMotor.Location = new System.Drawing.Point(510, 36);
            this.btn_gprw_getAllMotor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_getAllMotor.Name = "btn_gprw_getAllMotor";
            this.btn_gprw_getAllMotor.Size = new System.Drawing.Size(241, 84);
            this.btn_gprw_getAllMotor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_getAllMotor.TabIndex = 65;
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
            this.labelX6.Location = new System.Drawing.Point(29, 26);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(216, 48);
            this.labelX6.TabIndex = 56;
            this.labelX6.Text = "motorRunMode:";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(29, 152);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(212, 48);
            this.labelX7.TabIndex = 58;
            this.labelX7.Text = "设置电机数据:";
            // 
            // cmb_gprw_motorRunMode
            // 
            this.cmb_gprw_motorRunMode.DisplayMember = "Text";
            this.cmb_gprw_motorRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gprw_motorRunMode.FormattingEnabled = true;
            this.cmb_gprw_motorRunMode.ItemHeight = 24;
            this.cmb_gprw_motorRunMode.Location = new System.Drawing.Point(241, 33);
            this.cmb_gprw_motorRunMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_gprw_motorRunMode.Name = "cmb_gprw_motorRunMode";
            this.cmb_gprw_motorRunMode.Size = new System.Drawing.Size(256, 32);
            this.cmb_gprw_motorRunMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_gprw_motorRunMode.TabIndex = 57;
            // 
            // btn_MotorRunModeChange
            // 
            this.btn_MotorRunModeChange.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_MotorRunModeChange.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_MotorRunModeChange.Location = new System.Drawing.Point(509, 23);
            this.btn_MotorRunModeChange.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MotorRunModeChange.Name = "btn_MotorRunModeChange";
            this.btn_MotorRunModeChange.Size = new System.Drawing.Size(204, 60);
            this.btn_MotorRunModeChange.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_MotorRunModeChange.TabIndex = 64;
            this.btn_MotorRunModeChange.Text = "设定运行模式";
            this.btn_MotorRunModeChange.Click += new System.EventHandler(this.btn_MotorRunModeChange_Click);
            // 
            // txt_gprw_SetMotorParameter
            // 
            // 
            // 
            // 
            this.txt_gprw_SetMotorParameter.Border.Class = "TextBoxBorder";
            this.txt_gprw_SetMotorParameter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_SetMotorParameter.Location = new System.Drawing.Point(237, 235);
            this.txt_gprw_SetMotorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_SetMotorParameter.Multiline = true;
            this.txt_gprw_SetMotorParameter.Name = "txt_gprw_SetMotorParameter";
            this.txt_gprw_SetMotorParameter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gprw_SetMotorParameter.Size = new System.Drawing.Size(256, 48);
            this.txt_gprw_SetMotorParameter.TabIndex = 62;
            this.txt_gprw_SetMotorParameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_SetMotorParameter_KeyPress);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(29, 235);
            this.labelX8.Margin = new System.Windows.Forms.Padding(4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(212, 48);
            this.labelX8.TabIndex = 61;
            this.labelX8.Text = "电机设定值:";
            // 
            // btn_gprw_SetMotorParameter
            // 
            this.btn_gprw_SetMotorParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_SetMotorParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_SetMotorParameter.Location = new System.Drawing.Point(509, 113);
            this.btn_gprw_SetMotorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_SetMotorParameter.Name = "btn_gprw_SetMotorParameter";
            this.btn_gprw_SetMotorParameter.Size = new System.Drawing.Size(204, 172);
            this.btn_gprw_SetMotorParameter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_SetMotorParameter.TabIndex = 60;
            this.btn_gprw_SetMotorParameter.Text = "设定电机参数";
            this.btn_gprw_SetMotorParameter.Click += new System.EventHandler(this.btn_gprw_SetMotorParameter_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.gp_singleMotor);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.chk_gprw_motorZeroOffsetProfessional);
            this.groupPanel1.Controls.Add(this.btn_gprw_getAllMotor);
            this.groupPanel1.Controls.Add(this.txt_gprw_motorID);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Controls.Add(this.groupPanel5);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1536, 1166);
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
            this.groupPanel1.TabIndex = 85;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.labelX12);
            this.groupPanel3.Controls.Add(this.btn_gprw_SetMotorReportInterval);
            this.groupPanel3.Controls.Add(this.btn_gprw_UnEnableMotorReport);
            this.groupPanel3.Controls.Add(this.btn_gprw_EnableMotorReport);
            this.groupPanel3.Controls.Add(this.txt_gprw_motorReprotInterval);
            this.groupPanel3.Controls.Add(this.btn_gprw_motorEnable);
            this.groupPanel3.Controls.Add(this.btn_gprw_motorZero);
            this.groupPanel3.Controls.Add(this.btn_gprw_motorUnEnable);
            this.groupPanel3.Controls.Add(this.btn_clearMotorError);
            this.groupPanel3.Location = new System.Drawing.Point(15, 141);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(736, 364);
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
            this.groupPanel3.TabIndex = 86;
            this.groupPanel3.Text = "一般性调试数据";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.chk_gprw_isParameterHold);
            this.groupPanel2.Controls.Add(this.cmb_gprw_SetMotorParameter);
            this.groupPanel2.Controls.Add(this.labelX13);
            this.groupPanel2.Controls.Add(this.btn_gprw_motorZeroOffset);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.txt_gprw_motorZeroOffset);
            this.groupPanel2.Controls.Add(this.btn_gprw_SetMotorParameter);
            this.groupPanel2.Controls.Add(this.cmb_gprw_motorRunMode);
            this.groupPanel2.Controls.Add(this.btn_MotorRunModeChange);
            this.groupPanel2.Controls.Add(this.txt_gprw_SetMotorParameter);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Location = new System.Drawing.Point(15, 511);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(736, 408);
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
            this.groupPanel2.TabIndex = 85;
            this.groupPanel2.Text = "关键数据";
            // 
            // groupPanel5
            // 
            this.groupPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.dgv_motorParameter);
            this.groupPanel5.Controls.Add(this.btn_gprw_motorParameterRead);
            this.groupPanel5.Controls.Add(this.btn_gprw_clearDgv_motorParameter);
            this.groupPanel5.Location = new System.Drawing.Point(776, 36);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(739, 1105);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 87;
            this.groupPanel5.Text = "电机参数数据";
            // 
            // Frm_MotorInterope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 1213);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "Frm_MotorInterope";
            this.Text = "电机配置";
            this.Load += new System.EventHandler(this.Frm_MotorInterope_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorParameter)).EndInit();
            this.gp_singleMotor.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_gprw_motorZeroOffsetProfessional;
        private DevComponents.DotNetBar.ButtonX btn_gprw_motorZeroOffset;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_motorZeroOffset;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_motorReprotInterval;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_motorParameter;
        private DevComponents.DotNetBar.ButtonX btn_gprw_clearDgv_motorParameter;
        private DevComponents.DotNetBar.ButtonX btn_gprw_modifyMotorID;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_destinationMotorID;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_soureMotorID;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_gprw_isParameterHold;
        private DevComponents.DotNetBar.ButtonX btn_gprw_motorParameterRead;
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
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gprw_SetMotorParameter;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btn_gprw_SetMotorParameter;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_singleMotor;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
    }
}