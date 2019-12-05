namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    partial class Frm_Phong
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
            System.Windows.Forms.Label mAPLabel;
            System.Windows.Forms.Label gHICHULabel;
            System.Windows.Forms.Label mALOAIPLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Phong));
            this.dtgridview_phong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaimaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pHONGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.btn_timkiem = new System.Windows.Forms.ToolStripButton();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.cbo_maloaiphong = new System.Windows.Forms.ComboBox();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_giaphong = new ConTrols.NumbericTextBox();
            mAPLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            mALOAIPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingNavigator)).BeginInit();
            this.pHONGBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAPLabel
            // 
            mAPLabel.AutoSize = true;
            mAPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPLabel.ForeColor = System.Drawing.Color.Blue;
            mAPLabel.Location = new System.Drawing.Point(70, 75);
            mAPLabel.Name = "mAPLabel";
            mAPLabel.Size = new System.Drawing.Size(83, 19);
            mAPLabel.TabIndex = 1;
            mAPLabel.Text = "Mã Phòng:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gHICHULabel.ForeColor = System.Drawing.Color.Blue;
            gHICHULabel.Location = new System.Drawing.Point(70, 135);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(82, 19);
            gHICHULabel.TabIndex = 5;
            gHICHULabel.Text = "Giá phòng:";
            // 
            // mALOAIPLabel
            // 
            mALOAIPLabel.AutoSize = true;
            mALOAIPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOAIPLabel.ForeColor = System.Drawing.Color.Blue;
            mALOAIPLabel.Location = new System.Drawing.Point(70, 104);
            mALOAIPLabel.Name = "mALOAIPLabel";
            mALOAIPLabel.Size = new System.Drawing.Size(84, 19);
            mALOAIPLabel.TabIndex = 7;
            mALOAIPLabel.Text = "Tên phòng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(390, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 19);
            label1.TabIndex = 1;
            label1.Text = "Tình trạng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Blue;
            label2.Location = new System.Drawing.Point(390, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 19);
            label2.TabIndex = 5;
            label2.Text = "Ghi Chú:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(390, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 19);
            label3.TabIndex = 7;
            label3.Text = "Mã Loại Phòng:";
            // 
            // dtgridview_phong
            // 
            this.dtgridview_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridview_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.tenphong,
            this.giaphong,
            this.tinhtrang,
            this.loaimaphong,
            this.ghichu});
            this.dtgridview_phong.Location = new System.Drawing.Point(12, 177);
            this.dtgridview_phong.Name = "dtgridview_phong";
            this.dtgridview_phong.Size = new System.Drawing.Size(755, 207);
            this.dtgridview_phong.TabIndex = 7;
            this.dtgridview_phong.SelectionChanged += new System.EventHandler(this.dtgridview_phong_SelectionChanged);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "MAP";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "TENP";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.Name = "tenphong";
            // 
            // giaphong
            // 
            this.giaphong.DataPropertyName = "GIAPHONG";
            this.giaphong.HeaderText = "Giá phòng";
            this.giaphong.Name = "giaphong";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "TINHTRANG";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // loaimaphong
            // 
            this.loaimaphong.DataPropertyName = "MALOAIP";
            this.loaimaphong.HeaderText = "Loại mã phòng";
            this.loaimaphong.Name = "loaimaphong";
            this.loaimaphong.Width = 150;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "GHICHU";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 150;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelX1.Location = new System.Drawing.Point(346, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 29);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "PHÒNG";
            // 
            // pHONGBindingNavigator
            // 
            this.pHONGBindingNavigator.AddNewItem = null;
            this.pHONGBindingNavigator.CountItem = null;
            this.pHONGBindingNavigator.DeleteItem = null;
            this.pHONGBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHONGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton3,
            this.btn_them,
            this.btn_xoa,
            this.btn_luu,
            this.btn_timkiem,
            this.btn_thoat});
            this.pHONGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pHONGBindingNavigator.MoveFirstItem = null;
            this.pHONGBindingNavigator.MoveLastItem = null;
            this.pHONGBindingNavigator.MoveNextItem = null;
            this.pHONGBindingNavigator.MovePreviousItem = null;
            this.pHONGBindingNavigator.Name = "pHONGBindingNavigator";
            this.pHONGBindingNavigator.PositionItem = null;
            this.pHONGBindingNavigator.Size = new System.Drawing.Size(780, 32);
            this.pHONGBindingNavigator.TabIndex = 0;
            this.pHONGBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 29);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton3.Text = "Move first";
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_them.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.add;
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 29);
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_xoa.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.remove1;
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(64, 29);
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(63, 29);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_timkiem.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.find;
            this.btn_timkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(108, 29);
            this.btn_timkiem.Text = "Tìm kiếm";
            // 
            // btn_thoat
            // 
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_thoat.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.thoat;
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 29);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_maloaiphong
            // 
            this.cbo_maloaiphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_maloaiphong.FormattingEnabled = true;
            this.cbo_maloaiphong.Location = new System.Drawing.Point(518, 103);
            this.cbo_maloaiphong.Name = "cbo_maloaiphong";
            this.cbo_maloaiphong.Size = new System.Drawing.Size(195, 27);
            this.cbo_maloaiphong.TabIndex = 10;
            // 
            // txt_maphong
            // 
            this.txt_maphong.Enabled = false;
            this.txt_maphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_maphong.Location = new System.Drawing.Point(171, 68);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(195, 26);
            this.txt_maphong.TabIndex = 11;
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenphong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_tenphong.Location = new System.Drawing.Point(171, 101);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(195, 26);
            this.txt_tenphong.TabIndex = 11;
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tinhtrang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_tinhtrang.Location = new System.Drawing.Point(518, 68);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(195, 26);
            this.txt_tinhtrang.TabIndex = 11;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ghichu.Location = new System.Drawing.Point(518, 135);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(195, 26);
            this.txt_ghichu.TabIndex = 11;
            // 
            // txt_giaphong
            // 
            this.txt_giaphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaphong.Location = new System.Drawing.Point(171, 135);
            this.txt_giaphong.Name = "txt_giaphong";
            this.txt_giaphong.Size = new System.Drawing.Size(195, 26);
            this.txt_giaphong.TabIndex = 12;
            // 
            // Frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 396);
            this.Controls.Add(this.txt_giaphong);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.txt_tinhtrang);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.cbo_maloaiphong);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(label3);
            this.Controls.Add(mALOAIPLabel);
            this.Controls.Add(this.dtgridview_phong);
            this.Controls.Add(label2);
            this.Controls.Add(gHICHULabel);
            this.Controls.Add(label1);
            this.Controls.Add(mAPLabel);
            this.Controls.Add(this.pHONGBindingNavigator);
            this.Name = "Frm_Phong";
            this.Text = "Frm_Phong";
            this.Load += new System.EventHandler(this.Frm_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingNavigator)).EndInit();
            this.pHONGBindingNavigator.ResumeLayout(false);
            this.pHONGBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private ql_khachsanDataSetTableAdapters.PHONG_MALAOIPTableAdapter pHONG_MALAOIPTableAdapter;
        private System.Windows.Forms.DataGridView dtgridview_phong;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStripButton btn_luu;
        private System.Windows.Forms.ToolStripButton btn_thoat;
        private System.Windows.Forms.ToolStripButton btn_timkiem;
        private System.Windows.Forms.BindingNavigator pHONGBindingNavigator;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.ToolStripButton btn_xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ComboBox cbo_maloaiphong;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.TextBox txt_ghichu;
        private ConTrols.NumbericTextBox txt_giaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaimaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}