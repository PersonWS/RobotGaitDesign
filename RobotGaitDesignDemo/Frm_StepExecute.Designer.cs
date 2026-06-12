namespace RobotGaitDesignDemo
{
    partial class Frm_StepExecute
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
            this.btn_readExcel = new DevComponents.DotNetBar.ButtonX();
            this.gp_motorInfo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_motorInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gp_stepInfo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_stepInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_startExcute = new DevComponents.DotNetBar.ButtonX();
            this.btn_stopExcute = new DevComponents.DotNetBar.ButtonX();
            this.cmb_stepGainName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.gp_motorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorInfo)).BeginInit();
            this.gp_stepInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stepInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_readExcel
            // 
            this.btn_readExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_readExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_readExcel.Location = new System.Drawing.Point(18, 12);
            this.btn_readExcel.Name = "btn_readExcel";
            this.btn_readExcel.Size = new System.Drawing.Size(155, 73);
            this.btn_readExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_readExcel.TabIndex = 0;
            this.btn_readExcel.Text = "读取excel";
            this.btn_readExcel.Click += new System.EventHandler(this.btn_readExcel_Click);
            // 
            // gp_motorInfo
            // 
            this.gp_motorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gp_motorInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_motorInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_motorInfo.Controls.Add(this.dgv_motorInfo);
            this.gp_motorInfo.Location = new System.Drawing.Point(12, 119);
            this.gp_motorInfo.Name = "gp_motorInfo";
            this.gp_motorInfo.Size = new System.Drawing.Size(777, 547);
            // 
            // 
            // 
            this.gp_motorInfo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_motorInfo.Style.BackColorGradientAngle = 90;
            this.gp_motorInfo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_motorInfo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorInfo.Style.BorderBottomWidth = 1;
            this.gp_motorInfo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_motorInfo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorInfo.Style.BorderLeftWidth = 1;
            this.gp_motorInfo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorInfo.Style.BorderRightWidth = 1;
            this.gp_motorInfo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_motorInfo.Style.BorderTopWidth = 1;
            this.gp_motorInfo.Style.CornerDiameter = 4;
            this.gp_motorInfo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_motorInfo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_motorInfo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_motorInfo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_motorInfo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_motorInfo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_motorInfo.TabIndex = 1;
            this.gp_motorInfo.Text = "电机信息";
            // 
            // dgv_motorInfo
            // 
            this.dgv_motorInfo.AllowUserToAddRows = false;
            this.dgv_motorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_motorInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_motorInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_motorInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_motorInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_motorInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_motorInfo.Location = new System.Drawing.Point(3, 30);
            this.dgv_motorInfo.Name = "dgv_motorInfo";
            this.dgv_motorInfo.RowHeadersVisible = false;
            this.dgv_motorInfo.RowHeadersWidth = 82;
            this.dgv_motorInfo.RowTemplate.Height = 37;
            this.dgv_motorInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_motorInfo.Size = new System.Drawing.Size(765, 478);
            this.dgv_motorInfo.TabIndex = 0;
            // 
            // gp_stepInfo
            // 
            this.gp_stepInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_stepInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_stepInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_stepInfo.Controls.Add(this.dgv_stepInfo);
            this.gp_stepInfo.Location = new System.Drawing.Point(795, 119);
            this.gp_stepInfo.Name = "gp_stepInfo";
            this.gp_stepInfo.Size = new System.Drawing.Size(721, 547);
            // 
            // 
            // 
            this.gp_stepInfo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_stepInfo.Style.BackColorGradientAngle = 90;
            this.gp_stepInfo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_stepInfo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_stepInfo.Style.BorderBottomWidth = 1;
            this.gp_stepInfo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_stepInfo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_stepInfo.Style.BorderLeftWidth = 1;
            this.gp_stepInfo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_stepInfo.Style.BorderRightWidth = 1;
            this.gp_stepInfo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_stepInfo.Style.BorderTopWidth = 1;
            this.gp_stepInfo.Style.CornerDiameter = 4;
            this.gp_stepInfo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_stepInfo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_stepInfo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_stepInfo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_stepInfo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_stepInfo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_stepInfo.TabIndex = 2;
            this.gp_stepInfo.Text = "步态信息";
            // 
            // dgv_stepInfo
            // 
            this.dgv_stepInfo.AllowUserToAddRows = false;
            this.dgv_stepInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_stepInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_stepInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_stepInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stepInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stepInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_stepInfo.Location = new System.Drawing.Point(3, 30);
            this.dgv_stepInfo.Name = "dgv_stepInfo";
            this.dgv_stepInfo.RowHeadersVisible = false;
            this.dgv_stepInfo.RowHeadersWidth = 82;
            this.dgv_stepInfo.RowTemplate.Height = 37;
            this.dgv_stepInfo.Size = new System.Drawing.Size(709, 478);
            this.dgv_stepInfo.TabIndex = 1;
            // 
            // btn_startExcute
            // 
            this.btn_startExcute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_startExcute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_startExcute.Location = new System.Drawing.Point(857, 12);
            this.btn_startExcute.Name = "btn_startExcute";
            this.btn_startExcute.Size = new System.Drawing.Size(155, 73);
            this.btn_startExcute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_startExcute.TabIndex = 3;
            this.btn_startExcute.Text = "开始执行";
            // 
            // btn_stopExcute
            // 
            this.btn_stopExcute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_stopExcute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_stopExcute.Location = new System.Drawing.Point(1039, 12);
            this.btn_stopExcute.Name = "btn_stopExcute";
            this.btn_stopExcute.Size = new System.Drawing.Size(155, 73);
            this.btn_stopExcute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_stopExcute.TabIndex = 4;
            this.btn_stopExcute.Text = "停止执行";
            // 
            // cmb_stepGainName
            // 
            this.cmb_stepGainName.DisplayMember = "Text";
            this.cmb_stepGainName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_stepGainName.FormattingEnabled = true;
            this.cmb_stepGainName.ItemHeight = 29;
            this.cmb_stepGainName.Location = new System.Drawing.Point(366, 31);
            this.cmb_stepGainName.Name = "cmb_stepGainName";
            this.cmb_stepGainName.Size = new System.Drawing.Size(294, 35);
            this.cmb_stepGainName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_stepGainName.TabIndex = 5;
            this.cmb_stepGainName.SelectedIndexChanged += new System.EventHandler(this.cmb_stepGainName_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(217, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(133, 46);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "选择步态：";
            // 
            // Frm_StepExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 778);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmb_stepGainName);
            this.Controls.Add(this.btn_stopExcute);
            this.Controls.Add(this.btn_startExcute);
            this.Controls.Add(this.gp_stepInfo);
            this.Controls.Add(this.gp_motorInfo);
            this.Controls.Add(this.btn_readExcel);
            this.DoubleBuffered = true;
            this.Name = "Frm_StepExecute";
            this.Text = "Frm_StepExecute";
            this.gp_motorInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_motorInfo)).EndInit();
            this.gp_stepInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stepInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_readExcel;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_motorInfo;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_stepInfo;
        private DevComponents.DotNetBar.ButtonX btn_startExcute;
        private DevComponents.DotNetBar.ButtonX btn_stopExcute;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_motorInfo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_stepInfo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_stepGainName;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}