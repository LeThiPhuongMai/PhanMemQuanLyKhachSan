namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    partial class Frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            this.lbl_kh = new System.Windows.Forms.Label();
            this.menuStrip_qlthuvien = new System.Windows.Forms.MenuStrip();
            this.Them = new System.Windows.Forms.ToolStripMenuItem();
            this.Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.Luu = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_in = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_timkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_tenkh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_sdt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_dc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_khachsanDataSet = new Phan_Mem_QL_Khach_San.ql_khachsanDataSet();
            this.kHACHHANGTableAdapter = new Phan_Mem_QL_Khach_San.ql_khachsanDataSetTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new Phan_Mem_QL_Khach_San.ql_khachsanDataSetTableAdapters.TableAdapterManager();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new ConTrols.NumbericTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip_qlthuvien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_khachsanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kh
            // 
            this.lbl_kh.AutoSize = true;
            this.lbl_kh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_kh.Location = new System.Drawing.Point(211, 61);
            this.lbl_kh.Name = "lbl_kh";
            this.lbl_kh.Size = new System.Drawing.Size(328, 26);
            this.lbl_kh.TabIndex = 6;
            this.lbl_kh.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // menuStrip_qlthuvien
            // 
            this.menuStrip_qlthuvien.AutoSize = false;
            this.menuStrip_qlthuvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip_qlthuvien.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_qlthuvien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Them,
            this.Xoa,
            this.Luu,
            this.Thoat,
            this.btn_in,
            this.btn_timkiem});
            this.menuStrip_qlthuvien.Location = new System.Drawing.Point(7, 9);
            this.menuStrip_qlthuvien.Name = "menuStrip_qlthuvien";
            this.menuStrip_qlthuvien.Size = new System.Drawing.Size(752, 40);
            this.menuStrip_qlthuvien.TabIndex = 5;
            this.menuStrip_qlthuvien.Text = "menuStrip1";
            // 
            // Them
            // 
            this.Them.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Them.AutoSize = false;
            this.Them.AutoToolTip = true;
            this.Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Them.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Them.Image = ((System.Drawing.Image)(resources.GetObject("Them.Image")));
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(90, 30);
            this.Them.Text = "Thêm";
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.AutoSize = false;
            this.Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Xoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(80, 30);
            this.Xoa.Text = "Xóa";
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Luu
            // 
            this.Luu.AutoSize = false;
            this.Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Luu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Luu.Image = ((System.Drawing.Image)(resources.GetObject("Luu.Image")));
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(80, 30);
            this.Luu.Text = "Lưu";
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Thoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Thoat.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.Image")));
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(87, 36);
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.AutoSize = false;
            this.btn_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_in.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(94, 30);
            this.btn_in.Text = "In";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_timkiem.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.find;
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 36);
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Navy;
            this.labelX1.Location = new System.Drawing.Point(36, 106);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Mã Khách Hàng";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Navy;
            this.labelX2.Location = new System.Drawing.Point(36, 148);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(129, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Tên Khách Hàng";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Navy;
            this.labelX3.Location = new System.Drawing.Point(36, 194);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "CMND";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Navy;
            this.labelX4.Location = new System.Drawing.Point(399, 148);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Địa Chỉ";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Navy;
            this.labelX5.Location = new System.Drawing.Point(399, 106);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(111, 23);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Số Điện Thoại";
            // 
            // txt_tenkh
            // 
            // 
            // 
            // 
            this.txt_tenkh.Border.Class = "TextBoxBorder";
            this.txt_tenkh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(172, 150);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(203, 26);
            this.txt_tenkh.TabIndex = 13;
            // 
            // txt_sdt
            // 
            // 
            // 
            // 
            this.txt_sdt.Border.Class = "TextBoxBorder";
            this.txt_sdt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(516, 109);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(197, 26);
            this.txt_sdt.TabIndex = 15;
            // 
            // txt_dc
            // 
            // 
            // 
            // 
            this.txt_dc.Border.Class = "TextBoxBorder";
            this.txt_dc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_dc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(516, 150);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(197, 26);
            this.txt_dc.TabIndex = 16;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Checked = true;
            this.rdo_nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nam.ForeColor = System.Drawing.Color.Black;
            this.rdo_nam.Location = new System.Drawing.Point(118, 12);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(57, 23);
            this.rdo_nam.TabIndex = 18;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nu.ForeColor = System.Drawing.Color.Black;
            this.rdo_nu.Location = new System.Drawing.Point(209, 13);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(48, 23);
            this.rdo_nu.TabIndex = 19;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_nu);
            this.groupBox1.Controls.Add(this.rdo_nam);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(399, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 41);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới Tính";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.cMDNDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kHACHHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 186);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "Mã Khách Hàng";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.Width = 110;
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            this.tENKHDataGridViewTextBoxColumn.Width = 130;
            // 
            // cMDNDataGridViewTextBoxColumn
            // 
            this.cMDNDataGridViewTextBoxColumn.DataPropertyName = "CMDN";
            this.cMDNDataGridViewTextBoxColumn.HeaderText = "CMDN";
            this.cMDNDataGridViewTextBoxColumn.Name = "cMDNDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.Width = 150;
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.ql_khachsanDataSet;
            // 
            // ql_khachsanDataSet
            // 
            this.ql_khachsanDataSet.DataSetName = "ql_khachsanDataSet";
            this.ql_khachsanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADONTableAdapter = null;
            this.tableAdapterManager.CHITIETPHIEUTHUEPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.LOAINGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUEPHONGTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.QUIDINHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Phan_Mem_QL_Khach_San.ql_khachsanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_makh
            // 
            this.txt_makh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MAKH", true));
            this.txt_makh.Enabled = false;
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(172, 106);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(203, 26);
            this.txt_makh.TabIndex = 22;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "CMDN", true));
            this.txt_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Location = new System.Drawing.Point(172, 197);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(203, 26);
            this.txt_cmnd.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(546, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 26);
            this.textBox1.TabIndex = 24;
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lbl_kh);
            this.Controls.Add(this.menuStrip_qlthuvien);
            this.Name = "Frm_KhachHang";
            this.Text = "Frm_KhachHang";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.menuStrip_qlthuvien.ResumeLayout(false);
            this.menuStrip_qlthuvien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_khachsanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kh;
        private System.Windows.Forms.MenuStrip menuStrip_qlthuvien;
        private System.Windows.Forms.ToolStripMenuItem Them;
        private System.Windows.Forms.ToolStripMenuItem Xoa;
        private System.Windows.Forms.ToolStripMenuItem Luu;
        private System.Windows.Forms.ToolStripMenuItem Thoat;
        private System.Windows.Forms.ToolStripMenuItem btn_in;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tenkh;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sdt;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_dc;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ql_khachsanDataSet ql_khachsanDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private ql_khachsanDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btn_timkiem;
        private ql_khachsanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_makh;
        private ConTrols.NumbericTextBox txt_cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}