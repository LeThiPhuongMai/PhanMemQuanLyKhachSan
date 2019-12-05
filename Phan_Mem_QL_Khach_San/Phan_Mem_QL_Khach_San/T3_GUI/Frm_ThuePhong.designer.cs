namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    partial class Frm_ThuePhong
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAPTLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label mAPLabel;
            System.Windows.Forms.Label nGAYNHANLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThuePhong));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_maphieuthue = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new ConTrols.NumbericTextBox();
            this.btn_themkh = new DevComponents.DotNetBar.ButtonX();
            this.cbo_makh = new System.Windows.Forms.ComboBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_giaphong = new ConTrols.NumbericTextBox();
            this.btn_themphong = new DevComponents.DotNetBar.ButtonX();
            this.cbo_loaiphong = new System.Windows.Forms.ComboBox();
            this.cbo_maphong = new System.Windows.Forms.ComboBox();
            this.txt_ngaynhan = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pHIEUTHUEPHONGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btn_reset = new System.Windows.Forms.ToolStripButton();
            this.dtgrid_thuephong = new System.Windows.Forms.DataGridView();
            this.MAPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAPTLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            mAPLabel = new System.Windows.Forms.Label();
            nGAYNHANLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUEPHONGBindingNavigator)).BeginInit();
            this.pHIEUTHUEPHONGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_thuephong)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPTLabel
            // 
            mAPTLabel.AutoSize = true;
            mAPTLabel.ForeColor = System.Drawing.Color.Blue;
            mAPTLabel.Location = new System.Drawing.Point(5, 27);
            mAPTLabel.Name = "mAPTLabel";
            mAPTLabel.Size = new System.Drawing.Size(117, 19);
            mAPTLabel.TabIndex = 0;
            mAPTLabel.Text = "Mã Phiếu Thuê:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.ForeColor = System.Drawing.Color.Blue;
            mAKHLabel.Location = new System.Drawing.Point(5, 61);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(120, 19);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "Mã Khách Hàng";
            // 
            // mAPLabel
            // 
            mAPLabel.AutoSize = true;
            mAPLabel.ForeColor = System.Drawing.Color.Blue;
            mAPLabel.Location = new System.Drawing.Point(10, 61);
            mAPLabel.Name = "mAPLabel";
            mAPLabel.Size = new System.Drawing.Size(83, 19);
            mAPLabel.TabIndex = 2;
            mAPLabel.Text = "Mã Phòng:";
            // 
            // nGAYNHANLabel
            // 
            nGAYNHANLabel.AutoSize = true;
            nGAYNHANLabel.ForeColor = System.Drawing.Color.Blue;
            nGAYNHANLabel.Location = new System.Drawing.Point(10, 126);
            nGAYNHANLabel.Name = "nGAYNHANLabel";
            nGAYNHANLabel.Size = new System.Drawing.Size(86, 19);
            nGAYNHANLabel.TabIndex = 6;
            nGAYNHANLabel.Text = "Ngày nhận:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(5, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Blue;
            label2.Location = new System.Drawing.Point(10, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 19);
            label2.TabIndex = 0;
            label2.Text = "Loại phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(13, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 19);
            label3.TabIndex = 0;
            label3.Text = "Giá phòng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Blue;
            label4.Location = new System.Drawing.Point(5, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 19);
            label4.TabIndex = 0;
            label4.Text = "CMND:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_tenkh);
            this.groupPanel1.Controls.Add(this.txt_maphieuthue);
            this.groupPanel1.Controls.Add(this.txt_cmnd);
            this.groupPanel1.Controls.Add(this.btn_themkh);
            this.groupPanel1.Controls.Add(this.cbo_makh);
            this.groupPanel1.Controls.Add(mAKHLabel);
            this.groupPanel1.Controls.Add(label4);
            this.groupPanel1.Controls.Add(label1);
            this.groupPanel1.Controls.Add(mAPTLabel);
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(22, 41);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(370, 182);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "PHIẾU THUÊ PHÒNG";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Enabled = false;
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(137, 87);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(205, 26);
            this.txt_tenkh.TabIndex = 9;
            // 
            // txt_maphieuthue
            // 
            this.txt_maphieuthue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphieuthue.Location = new System.Drawing.Point(137, 20);
            this.txt_maphieuthue.Name = "txt_maphieuthue";
            this.txt_maphieuthue.Size = new System.Drawing.Size(205, 26);
            this.txt_maphieuthue.TabIndex = 9;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Enabled = false;
            this.txt_cmnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Location = new System.Drawing.Point(137, 122);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(205, 26);
            this.txt_cmnd.TabIndex = 8;
            // 
            // btn_themkh
            // 
            this.btn_themkh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themkh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themkh.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.add;
            this.btn_themkh.Location = new System.Drawing.Point(313, 58);
            this.btn_themkh.Name = "btn_themkh";
            this.btn_themkh.Size = new System.Drawing.Size(29, 23);
            this.btn_themkh.TabIndex = 7;
            this.btn_themkh.Click += new System.EventHandler(this.btn_themkh_Click);
            // 
            // cbo_makh
            // 
            this.cbo_makh.DisplayMember = "MAKH";
            this.cbo_makh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_makh.FormattingEnabled = true;
            this.cbo_makh.Location = new System.Drawing.Point(137, 53);
            this.cbo_makh.Name = "cbo_makh";
            this.cbo_makh.Size = new System.Drawing.Size(170, 27);
            this.cbo_makh.TabIndex = 4;
            this.cbo_makh.ValueMember = "MAKH";
            this.cbo_makh.SelectedValueChanged += new System.EventHandler(this.cbo_makh_SelectedValueChanged);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txt_giaphong);
            this.groupPanel2.Controls.Add(this.btn_themphong);
            this.groupPanel2.Controls.Add(this.cbo_loaiphong);
            this.groupPanel2.Controls.Add(this.cbo_maphong);
            this.groupPanel2.Controls.Add(nGAYNHANLabel);
            this.groupPanel2.Controls.Add(this.txt_ngaynhan);
            this.groupPanel2.Controls.Add(label3);
            this.groupPanel2.Controls.Add(label2);
            this.groupPanel2.Controls.Add(mAPLabel);
            this.groupPanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(398, 41);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(390, 182);
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
            this.groupPanel2.TabIndex = 4;
            this.groupPanel2.Text = "CHI TIẾT PHIẾU THUÊ PHÒNG";
            // 
            // txt_giaphong
            // 
            this.txt_giaphong.Enabled = false;
            this.txt_giaphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaphong.Location = new System.Drawing.Point(131, 91);
            this.txt_giaphong.Name = "txt_giaphong";
            this.txt_giaphong.Size = new System.Drawing.Size(211, 26);
            this.txt_giaphong.TabIndex = 10;
            // 
            // btn_themphong
            // 
            this.btn_themphong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themphong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themphong.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.add;
            this.btn_themphong.Location = new System.Drawing.Point(313, 57);
            this.btn_themphong.Name = "btn_themphong";
            this.btn_themphong.Size = new System.Drawing.Size(29, 23);
            this.btn_themphong.TabIndex = 9;
            this.btn_themphong.Click += new System.EventHandler(this.btn_themphong_Click);
            // 
            // cbo_loaiphong
            // 
            this.cbo_loaiphong.DisplayMember = "MAP";
            this.cbo_loaiphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loaiphong.FormattingEnabled = true;
            this.cbo_loaiphong.Location = new System.Drawing.Point(131, 19);
            this.cbo_loaiphong.Name = "cbo_loaiphong";
            this.cbo_loaiphong.Size = new System.Drawing.Size(211, 27);
            this.cbo_loaiphong.TabIndex = 8;
            this.cbo_loaiphong.ValueMember = "MAP";
            this.cbo_loaiphong.SelectedValueChanged += new System.EventHandler(this.cbo_loaiphong_SelectedValueChanged);
            // 
            // cbo_maphong
            // 
            this.cbo_maphong.DisplayMember = "MAP";
            this.cbo_maphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_maphong.FormattingEnabled = true;
            this.cbo_maphong.Location = new System.Drawing.Point(131, 53);
            this.cbo_maphong.Name = "cbo_maphong";
            this.cbo_maphong.Size = new System.Drawing.Size(176, 27);
            this.cbo_maphong.TabIndex = 8;
            this.cbo_maphong.ValueMember = "MAP";
            this.cbo_maphong.SelectedValueChanged += new System.EventHandler(this.cbo_maphong_SelectedValueChanged);
            // 
            // txt_ngaynhan
            // 
            this.txt_ngaynhan.CustomFormat = " MM/dd/yyyy";
            this.txt_ngaynhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaynhan.Location = new System.Drawing.Point(131, 126);
            this.txt_ngaynhan.Name = "txt_ngaynhan";
            this.txt_ngaynhan.Size = new System.Drawing.Size(211, 26);
            this.txt_ngaynhan.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phiếu Thuê";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Phòng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYDANGKY";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày Đăng Ký";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAYNHAN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày Nhận";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // pHIEUTHUEPHONGBindingNavigator
            // 
            this.pHIEUTHUEPHONGBindingNavigator.AddNewItem = null;
            this.pHIEUTHUEPHONGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pHIEUTHUEPHONGBindingNavigator.DeleteItem = null;
            this.pHIEUTHUEPHONGBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHIEUTHUEPHONGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_them,
            this.btn_xoa,
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.btn_reset});
            this.pHIEUTHUEPHONGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pHIEUTHUEPHONGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pHIEUTHUEPHONGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pHIEUTHUEPHONGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pHIEUTHUEPHONGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pHIEUTHUEPHONGBindingNavigator.Name = "pHIEUTHUEPHONGBindingNavigator";
            this.pHIEUTHUEPHONGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pHIEUTHUEPHONGBindingNavigator.Size = new System.Drawing.Size(811, 28);
            this.pHIEUTHUEPHONGBindingNavigator.TabIndex = 1;
            this.pHIEUTHUEPHONGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_them.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.add;
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(73, 25);
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_xoa.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.remove;
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(61, 25);
            this.btn_xoa.Text = "Xóa";
            // 
            // pHIEUTHUEPHONGBindingNavigatorSaveItem
            // 
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pHIEUTHUEPHONGBindingNavigatorSaveItem.Image")));
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem.Name = "pHIEUTHUEPHONGBindingNavigatorSaveItem";
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem.Size = new System.Drawing.Size(60, 25);
            this.pHIEUTHUEPHONGBindingNavigatorSaveItem.Text = "Lưu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripButton1.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.thoat;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(74, 25);
            this.toolStripButton1.Text = "Thoát";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripButton2.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.find;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(102, 25);
            this.toolStripButton2.Text = "Tìm kiếm";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_reset.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.tsbRefresh;
            this.btn_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(88, 25);
            this.btn_reset.Text = "Refresh";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dtgrid_thuephong
            // 
            this.dtgrid_thuephong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_thuephong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPT,
            this.MAKH,
            this.TENKH,
            this.CMDN,
            this.MAP,
            this.GIAPHONG,
            this.NGAYNHAN});
            this.dtgrid_thuephong.Location = new System.Drawing.Point(12, 229);
            this.dtgrid_thuephong.Name = "dtgrid_thuephong";
            this.dtgrid_thuephong.Size = new System.Drawing.Size(787, 229);
            this.dtgrid_thuephong.TabIndex = 5;
            this.dtgrid_thuephong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_thuephong_CellContentClick);
            // 
            // MAPT
            // 
            this.MAPT.DataPropertyName = "MAPT";
            this.MAPT.HeaderText = "Mã phiếu thuê";
            this.MAPT.Name = "MAPT";
            this.MAPT.Width = 90;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 110;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.Width = 150;
            // 
            // CMDN
            // 
            this.CMDN.DataPropertyName = "CMDN";
            this.CMDN.HeaderText = "CMND";
            this.CMDN.Name = "CMDN";
            // 
            // MAP
            // 
            this.MAP.DataPropertyName = "MAP";
            this.MAP.HeaderText = "Mã phòng";
            this.MAP.Name = "MAP";
            this.MAP.Width = 80;
            // 
            // GIAPHONG
            // 
            this.GIAPHONG.DataPropertyName = "GIAPHONG";
            this.GIAPHONG.HeaderText = "Giá phòng";
            this.GIAPHONG.Name = "GIAPHONG";
            // 
            // NGAYNHAN
            // 
            this.NGAYNHAN.DataPropertyName = "NGAYNHAN";
            this.NGAYNHAN.HeaderText = "Ngày nhận";
            this.NGAYNHAN.Name = "NGAYNHAN";
            // 
            // Frm_ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 470);
            this.Controls.Add(this.dtgrid_thuephong);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.pHIEUTHUEPHONGBindingNavigator);
            this.Controls.Add(this.groupPanel1);
            this.Name = "Frm_ThuePhong";
            this.Text = "Frm_ThuePhong";
            this.Load += new System.EventHandler(this.Frm_ThuePhong_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUEPHONGBindingNavigator)).EndInit();
            this.pHIEUTHUEPHONGBindingNavigator.ResumeLayout(false);
            this.pHIEUTHUEPHONGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_thuephong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DateTimePicker txt_ngaynhan;
        private System.Windows.Forms.ComboBox cbo_makh;
        private System.Windows.Forms.ComboBox cbo_maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevComponents.DotNetBar.ButtonX btn_themkh;
        private DevComponents.DotNetBar.ButtonX btn_themphong;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pHIEUTHUEPHONGBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.BindingNavigator pHIEUTHUEPHONGBindingNavigator;
        private System.Windows.Forms.DataGridView dtgrid_thuephong;
        private ConTrols.NumbericTextBox txt_cmnd;
        private ConTrols.NumbericTextBox txt_giaphong;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_maphieuthue;
        private System.Windows.Forms.ComboBox cbo_loaiphong;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.ToolStripButton btn_reset;
        private System.Windows.Forms.ToolStripButton btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAN;

    }
}