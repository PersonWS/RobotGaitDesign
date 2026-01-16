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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.chk_gprw_motorZeroOffsetProfessional = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btn_gprw_motorZeroOffset = new DevComponents.DotNetBar.ButtonX();
            this.txt_gprw_motorZeroOffset = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_gprw_motorReprotInterval = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.dgv_motorParameter = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_gprw_clearDgv_motorParameter = new DevComponents.DotNetBar.ButtonX();
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
            this.txt_gprw_SetMotorParameter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btn_gprw_SetMotorParameter = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorParameter)).BeginInit();
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
            this.labelX13.Location = new System.Drawing.Point(116, 668);
            this.labelX13.Margin = new System.Windows.Forms.Padding(4);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(199, 48);
            this.labelX13.TabIndex = 81;
            this.labelX13.Text = "零位偏置[谨慎]:";
            // 
            // chk_gprw_motorZeroOffsetProfessional
            // 
            this.chk_gprw_motorZeroOffsetProfessional.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_gprw_motorZeroOffsetProfessional.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_gprw_motorZeroOffsetProfessional.Location = new System.Drawing.Point(8, 94);
            this.chk_gprw_motorZeroOffsetProfessional.Margin = new System.Windows.Forms.Padding(4);
            this.chk_gprw_motorZeroOffsetProfessional.Name = "chk_gprw_motorZeroOffsetProfessional";
            this.chk_gprw_motorZeroOffsetProfessional.Size = new System.Drawing.Size(137, 58);
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
            this.btn_gprw_motorZeroOffset.Location = new System.Drawing.Point(491, 656);
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
            this.txt_gprw_motorZeroOffset.Location = new System.Drawing.Point(311, 668);
            this.txt_gprw_motorZeroOffset.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_motorZeroOffset.Multiline = true;
            this.txt_gprw_motorZeroOffset.Name = "txt_gprw_motorZeroOffset";
            this.txt_gprw_motorZeroOffset.Size = new System.Drawing.Size(162, 48);
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
            this.txt_gprw_motorReprotInterval.Location = new System.Drawing.Point(37, 506);
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
            this.labelX12.Location = new System.Drawing.Point(43, 441);
            this.labelX12.Margin = new System.Windows.Forms.Padding(4);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(180, 48);
            this.labelX12.TabIndex = 79;
            this.labelX12.Text = "上报频率设定值:";
            // 
            // dgv_motorParameter
            // 
            this.dgv_motorParameter.AllowUserToAddRows = false;
            this.dgv_motorParameter.AllowUserToDeleteRows = false;
            this.dgv_motorParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.dgv_motorParameter.Location = new System.Drawing.Point(733, 224);
            this.dgv_motorParameter.Name = "dgv_motorParameter";
            this.dgv_motorParameter.RowHeadersVisible = false;
            this.dgv_motorParameter.RowHeadersWidth = 82;
            this.dgv_motorParameter.RowTemplate.Height = 37;
            this.dgv_motorParameter.Size = new System.Drawing.Size(866, 492);
            this.dgv_motorParameter.TabIndex = 78;
            // 
            // btn_gprw_clearDgv_motorParameter
            // 
            this.btn_gprw_clearDgv_motorParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_clearDgv_motorParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_clearDgv_motorParameter.Location = new System.Drawing.Point(1395, 46);
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
            this.btn_gprw_modifyMotorID.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_modifyMotorID.Location = new System.Drawing.Point(491, 574);
            this.btn_gprw_modifyMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_modifyMotorID.Name = "btn_gprw_modifyMotorID";
            this.btn_gprw_modifyMotorID.Size = new System.Drawing.Size(204, 60);
            this.btn_gprw_modifyMotorID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_modifyMotorID.TabIndex = 76;
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
            this.txt_gprw_destinationMotorID.Location = new System.Drawing.Point(311, 584);
            this.txt_gprw_destinationMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_destinationMotorID.Multiline = true;
            this.txt_gprw_destinationMotorID.Name = "txt_gprw_destinationMotorID";
            this.txt_gprw_destinationMotorID.Size = new System.Drawing.Size(108, 48);
            this.txt_gprw_destinationMotorID.TabIndex = 75;
            this.txt_gprw_destinationMotorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_motorReprotInterval_KeyPress);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(223, 584);
            this.labelX11.Margin = new System.Windows.Forms.Padding(4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(108, 48);
            this.labelX11.TabIndex = 74;
            this.labelX11.Text = "修改为：";
            // 
            // txt_gprw_soureMotorID
            // 
            // 
            // 
            // 
            this.txt_gprw_soureMotorID.Border.Class = "TextBoxBorder";
            this.txt_gprw_soureMotorID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_gprw_soureMotorID.Location = new System.Drawing.Point(105, 584);
            this.txt_gprw_soureMotorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_soureMotorID.Multiline = true;
            this.txt_gprw_soureMotorID.Name = "txt_gprw_soureMotorID";
            this.txt_gprw_soureMotorID.Size = new System.Drawing.Size(108, 48);
            this.txt_gprw_soureMotorID.TabIndex = 73;
            this.txt_gprw_soureMotorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gprw_motorReprotInterval_KeyPress);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(-1, 584);
            this.labelX10.Margin = new System.Windows.Forms.Padding(4);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(100, 48);
            this.labelX10.TabIndex = 72;
            this.labelX10.Text = "电机id:";
            // 
            // chk_gprw_isParameterHold
            // 
            this.chk_gprw_isParameterHold.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_gprw_isParameterHold.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_gprw_isParameterHold.Location = new System.Drawing.Point(17, 224);
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
            this.btn_gprw_motorParameterRead.Location = new System.Drawing.Point(1395, 132);
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
            this.btn_gprw_SetMotorReportInterval.Location = new System.Drawing.Point(272, 430);
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
            this.labelX5.Location = new System.Drawing.Point(43, 42);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(102, 48);
            this.labelX5.TabIndex = 52;
            this.labelX5.Text = "motorID:";
            // 
            // btn_gprw_UnEnableMotorReport
            // 
            this.btn_gprw_UnEnableMotorReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_UnEnableMotorReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_UnEnableMotorReport.Location = new System.Drawing.Point(422, 430);
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
            this.btn_gprw_motorEnable.Location = new System.Drawing.Point(721, 50);
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
            this.btn_gprw_EnableMotorReport.Location = new System.Drawing.Point(567, 430);
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
            this.txt_gprw_motorID.Location = new System.Drawing.Point(155, 50);
            this.txt_gprw_motorID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gprw_motorID.Multiline = true;
            this.txt_gprw_motorID.Name = "txt_gprw_motorID";
            this.txt_gprw_motorID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gprw_motorID.Size = new System.Drawing.Size(324, 84);
            this.txt_gprw_motorID.TabIndex = 53;
            // 
            // btn_clearMotorError
            // 
            this.btn_clearMotorError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearMotorError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearMotorError.Location = new System.Drawing.Point(954, 132);
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
            this.btn_gprw_motorUnEnable.Location = new System.Drawing.Point(954, 50);
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
            this.cmb_gprw_SetMotorParameter.Location = new System.Drawing.Point(219, 288);
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
            this.btn_gprw_motorZero.Location = new System.Drawing.Point(1181, 46);
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
            this.btn_gprw_getAllMotor.Location = new System.Drawing.Point(491, 50);
            this.btn_gprw_getAllMotor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_getAllMotor.Name = "btn_gprw_getAllMotor";
            this.btn_gprw_getAllMotor.Size = new System.Drawing.Size(209, 60);
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
            this.labelX6.Location = new System.Drawing.Point(47, 160);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(180, 48);
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
            this.labelX7.Location = new System.Drawing.Point(43, 288);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(180, 48);
            this.labelX7.TabIndex = 58;
            this.labelX7.Text = "设置电机数据:";
            // 
            // cmb_gprw_motorRunMode
            // 
            this.cmb_gprw_motorRunMode.DisplayMember = "Text";
            this.cmb_gprw_motorRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gprw_motorRunMode.FormattingEnabled = true;
            this.cmb_gprw_motorRunMode.ItemHeight = 24;
            this.cmb_gprw_motorRunMode.Location = new System.Drawing.Point(223, 160);
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
            this.btn_MotorRunModeChange.Location = new System.Drawing.Point(491, 150);
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
            this.txt_gprw_SetMotorParameter.Location = new System.Drawing.Point(219, 362);
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
            this.labelX8.Location = new System.Drawing.Point(43, 362);
            this.labelX8.Margin = new System.Windows.Forms.Padding(4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(180, 48);
            this.labelX8.TabIndex = 61;
            this.labelX8.Text = "电机设定值:";
            // 
            // btn_gprw_SetMotorParameter
            // 
            this.btn_gprw_SetMotorParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gprw_SetMotorParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gprw_SetMotorParameter.Location = new System.Drawing.Point(491, 240);
            this.btn_gprw_SetMotorParameter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gprw_SetMotorParameter.Name = "btn_gprw_SetMotorParameter";
            this.btn_gprw_SetMotorParameter.Size = new System.Drawing.Size(204, 172);
            this.btn_gprw_SetMotorParameter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gprw_SetMotorParameter.TabIndex = 60;
            this.btn_gprw_SetMotorParameter.Text = "设定电机参数";
            this.btn_gprw_SetMotorParameter.Click += new System.EventHandler(this.btn_gprw_SetMotorParameter_Click);
            // 
            // Frm_MotorInterope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1996, 731);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.chk_gprw_motorZeroOffsetProfessional);
            this.Controls.Add(this.btn_gprw_motorZeroOffset);
            this.Controls.Add(this.txt_gprw_motorZeroOffset);
            this.Controls.Add(this.txt_gprw_motorReprotInterval);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.dgv_motorParameter);
            this.Controls.Add(this.btn_gprw_clearDgv_motorParameter);
            this.Controls.Add(this.btn_gprw_modifyMotorID);
            this.Controls.Add(this.txt_gprw_destinationMotorID);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.txt_gprw_soureMotorID);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.chk_gprw_isParameterHold);
            this.Controls.Add(this.btn_gprw_motorParameterRead);
            this.Controls.Add(this.btn_gprw_SetMotorReportInterval);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btn_gprw_UnEnableMotorReport);
            this.Controls.Add(this.btn_gprw_motorEnable);
            this.Controls.Add(this.btn_gprw_EnableMotorReport);
            this.Controls.Add(this.txt_gprw_motorID);
            this.Controls.Add(this.btn_clearMotorError);
            this.Controls.Add(this.btn_gprw_motorUnEnable);
            this.Controls.Add(this.cmb_gprw_SetMotorParameter);
            this.Controls.Add(this.btn_gprw_motorZero);
            this.Controls.Add(this.btn_gprw_getAllMotor);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cmb_gprw_motorRunMode);
            this.Controls.Add(this.btn_MotorRunModeChange);
            this.Controls.Add(this.txt_gprw_SetMotorParameter);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.btn_gprw_SetMotorParameter);
            this.DoubleBuffered = true;
            this.Name = "Frm_MotorInterope";
            this.Text = "电机配置";
            this.Load += new System.EventHandler(this.Frm_MotorInterope_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorParameter)).EndInit();
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
    }
}