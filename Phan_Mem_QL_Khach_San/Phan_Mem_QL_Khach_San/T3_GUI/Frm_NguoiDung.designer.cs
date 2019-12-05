namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    partial class Frm_NguoiDung
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
            System.Windows.Forms.Label tENDANGNHAPLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label lOAINGUOIDUNGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NguoiDung));
            this.nGUOIDUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.btn_timkiem = new System.Windows.Forms.ToolStripButton();
            this.dtgridview_nguoidung = new System.Windows.Forms.DataGridView();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loainguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_loainguoidung = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.link_nhanvien = new System.Windows.Forms.LinkLabel();
            tENDANGNHAPLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            lOAINGUOIDUNGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingNavigator)).BeginInit();
            this.nGUOIDUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_nguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // tENDANGNHAPLabel
            // 
            tENDANGNHAPLabel.AutoSize = true;
            tENDANGNHAPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENDANGNHAPLabel.ForeColor = System.Drawing.Color.Blue;
            tENDANGNHAPLabel.Location = new System.Drawing.Point(128, 76);
            tENDANGNHAPLabel.Name = "tENDANGNHAPLabel";
            tENDANGNHAPLabel.Size = new System.Drawing.Size(120, 19);
            tENDANGNHAPLabel.TabIndex = 2;
            tENDANGNHAPLabel.Text = "Tên Đăng Nhập:";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATKHAULabel.ForeColor = System.Drawing.Color.Blue;
            mATKHAULabel.Location = new System.Drawing.Point(128, 108);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(83, 19);
            mATKHAULabel.TabIndex = 4;
            mATKHAULabel.Text = "Mật Khẩu:";
            // 
            // lOAINGUOIDUNGLabel
            // 
            lOAINGUOIDUNGLabel.AutoSize = true;
            lOAINGUOIDUNGLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOAINGUOIDUNGLabel.ForeColor = System.Drawing.Color.Blue;
            lOAINGUOIDUNGLabel.Location = new System.Drawing.Point(128, 140);
            lOAINGUOIDUNGLabel.Name = "lOAINGUOIDUNGLabel";
            lOAINGUOIDUNGLabel.Size = new System.Drawing.Size(131, 19);
            lOAINGUOIDUNGLabel.TabIndex = 6;
            lOAINGUOIDUNGLabel.Text = "Loại Người Dùng:";
            // 
            // nGUOIDUNGBindingNavigator
            // 
            this.nGUOIDUNGBindingNavigator.AddNewItem = null;
            this.nGUOIDUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nGUOIDUNGBindingNavigator.DeleteItem = null;
            this.nGUOIDUNGBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGUOIDUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btn_luu,
            this.btn_thoat,
            this.btn_timkiem});
            this.nGUOIDUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nGUOIDUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nGUOIDUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nGUOIDUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nGUOIDUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nGUOIDUNGBindingNavigator.Name = "nGUOIDUNGBindingNavigator";
            this.nGUOIDUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nGUOIDUNGBindingNavigator.Size = new System.Drawing.Size(636, 28);
            this.nGUOIDUNGBindingNavigator.TabIndex = 0;
            this.nGUOIDUNGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
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
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(60, 25);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_thoat.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.thoat;
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(74, 25);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_timkiem.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.find;
            this.btn_timkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(102, 25);
            this.btn_timkiem.Text = "Tìm kiếm";
            // 
            // dtgridview_nguoidung
            // 
            this.dtgridview_nguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridview_nguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendangnhap,
            this.matkhau,
            this.loainguoidung});
            this.dtgridview_nguoidung.Location = new System.Drawing.Point(12, 179);
            this.dtgridview_nguoidung.Name = "dtgridview_nguoidung";
            this.dtgridview_nguoidung.Size = new System.Drawing.Size(612, 200);
            this.dtgridview_nguoidung.TabIndex = 1;
            this.dtgridview_nguoidung.SelectionChanged += new System.EventHandler(this.dtgridview_nguoidung_SelectionChanged);
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "TENDANGNHAP";
            this.tendangnhap.HeaderText = "Tên đăng nhập";
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Width = 170;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "MATKHAU";
            this.matkhau.HeaderText = "Mật Khẩu";
            this.matkhau.Name = "matkhau";
            // 
            // loainguoidung
            // 
            this.loainguoidung.DataPropertyName = "LOAINGUOIDUNG";
            this.loainguoidung.HeaderText = "Loại người dùng";
            this.loainguoidung.Name = "loainguoidung";
            this.loainguoidung.Width = 200;
            // 
            // cbo_loainguoidung
            // 
            this.cbo_loainguoidung.DisplayMember = "LOAINGUOIDUNG";
            this.cbo_loainguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loainguoidung.FormattingEnabled = true;
            this.cbo_loainguoidung.Location = new System.Drawing.Point(279, 137);
            this.cbo_loainguoidung.Name = "cbo_loainguoidung";
            this.cbo_loainguoidung.Size = new System.Drawing.Size(198, 27);
            this.cbo_loainguoidung.TabIndex = 7;
            this.cbo_loainguoidung.ValueMember = "LOAINGUOIDUNG";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelX1.Location = new System.Drawing.Point(215, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(170, 37);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "NGƯỜI DÙNG";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Enabled = false;
            this.txt_tendangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendangnhap.Location = new System.Drawing.Point(279, 74);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(198, 26);
            this.txt_tendangnhap.TabIndex = 9;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(279, 107);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(198, 26);
            this.txt_matkhau.TabIndex = 9;
            // 
            // link_nhanvien
            // 
            this.link_nhanvien.AutoSize = true;
            this.link_nhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_nhanvien.Location = new System.Drawing.Point(503, 39);
            this.link_nhanvien.Name = "link_nhanvien";
            this.link_nhanvien.Size = new System.Drawing.Size(121, 19);
            this.link_nhanvien.TabIndex = 10;
            this.link_nhanvien.TabStop = true;
            this.link_nhanvien.Text = "Thêm Nhân Viên";
            this.link_nhanvien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_nhanvien_LinkClicked);
            // 
            // Frm_NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 391);
            this.Controls.Add(this.link_nhanvien);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(lOAINGUOIDUNGLabel);
            this.Controls.Add(this.cbo_loainguoidung);
            this.Controls.Add(mATKHAULabel);
            this.Controls.Add(tENDANGNHAPLabel);
            this.Controls.Add(this.dtgridview_nguoidung);
            this.Controls.Add(this.nGUOIDUNGBindingNavigator);
            this.Name = "Frm_NguoiDung";
            this.Text = "Frm_NguoiDung";
            this.Load += new System.EventHandler(this.Frm_NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingNavigator)).EndInit();
            this.nGUOIDUNGBindingNavigator.ResumeLayout(false);
            this.nGUOIDUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_nguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator nGUOIDUNGBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_luu;
        private System.Windows.Forms.DataGridView dtgridview_nguoidung;
        private System.Windows.Forms.ComboBox cbo_loainguoidung;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStripButton btn_thoat;
        private System.Windows.Forms.ToolStripButton btn_timkiem;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.ToolStripButton btn_xoa;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.LinkLabel link_nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn loainguoidung;
    }
}