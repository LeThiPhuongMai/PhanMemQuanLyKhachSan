namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    partial class Frm_LoaiPhong
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
            System.Windows.Forms.Label mALOAIPLabel;
            System.Windows.Forms.Label tENLOAIPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoaiPhong));
            this.lOAIPHONGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dtgridview_loaiphong = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_tenloaiphong = new System.Windows.Forms.TextBox();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mALOAIPLabel = new System.Windows.Forms.Label();
            tENLOAIPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGBindingNavigator)).BeginInit();
            this.lOAIPHONGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_loaiphong)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOAIPLabel
            // 
            mALOAIPLabel.AutoSize = true;
            mALOAIPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOAIPLabel.ForeColor = System.Drawing.Color.Blue;
            mALOAIPLabel.Location = new System.Drawing.Point(152, 78);
            mALOAIPLabel.Name = "mALOAIPLabel";
            mALOAIPLabel.Size = new System.Drawing.Size(117, 19);
            mALOAIPLabel.TabIndex = 3;
            mALOAIPLabel.Text = "Mã Loại Phòng:";
            // 
            // tENLOAIPLabel
            // 
            tENLOAIPLabel.AutoSize = true;
            tENLOAIPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOAIPLabel.ForeColor = System.Drawing.Color.Blue;
            tENLOAIPLabel.Location = new System.Drawing.Point(152, 112);
            tENLOAIPLabel.Name = "tENLOAIPLabel";
            tENLOAIPLabel.Size = new System.Drawing.Size(119, 19);
            tENLOAIPLabel.TabIndex = 5;
            tENLOAIPLabel.Text = "Tên Loại Phòng:";
            // 
            // lOAIPHONGBindingNavigator
            // 
            this.lOAIPHONGBindingNavigator.AddNewItem = null;
            this.lOAIPHONGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOAIPHONGBindingNavigator.DeleteItem = null;
            this.lOAIPHONGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOAIPHONGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lOAIPHONGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOAIPHONGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOAIPHONGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOAIPHONGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOAIPHONGBindingNavigator.Name = "lOAIPHONGBindingNavigator";
            this.lOAIPHONGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOAIPHONGBindingNavigator.Size = new System.Drawing.Size(586, 28);
            this.lOAIPHONGBindingNavigator.TabIndex = 0;
            this.lOAIPHONGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 25);
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
            // dtgridview_loaiphong
            // 
            this.dtgridview_loaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridview_loaiphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgridview_loaiphong.Location = new System.Drawing.Point(12, 146);
            this.dtgridview_loaiphong.Name = "dtgridview_loaiphong";
            this.dtgridview_loaiphong.Size = new System.Drawing.Size(562, 176);
            this.dtgridview_loaiphong.TabIndex = 1;
            this.dtgridview_loaiphong.SelectionChanged += new System.EventHandler(this.dtgridview_loaiphong_SelectionChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelX1.Location = new System.Drawing.Point(244, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(160, 38);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "LOẠI PHÒNG";
            // 
            // txt_tenloaiphong
            // 
            this.txt_tenloaiphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenloaiphong.Location = new System.Drawing.Point(281, 112);
            this.txt_tenloaiphong.Name = "txt_tenloaiphong";
            this.txt_tenloaiphong.Size = new System.Drawing.Size(184, 26);
            this.txt_tenloaiphong.TabIndex = 8;
            // 
            // txt_maloai
            // 
            this.txt_maloai.Enabled = false;
            this.txt_maloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maloai.Location = new System.Drawing.Point(281, 71);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(184, 26);
            this.txt_maloai.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAIP";
            this.Column1.HeaderText = "Mã loại phòng";
            this.Column1.Name = "Column1";
            this.Column1.Width = 220;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOAIP";
            this.Column2.HeaderText = "Tên loại phòng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Frm_LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 333);
            this.Controls.Add(this.txt_maloai);
            this.Controls.Add(this.txt_tenloaiphong);
            this.Controls.Add(tENLOAIPLabel);
            this.Controls.Add(mALOAIPLabel);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtgridview_loaiphong);
            this.Controls.Add(this.lOAIPHONGBindingNavigator);
            this.Name = "Frm_LoaiPhong";
            this.Text = "Frm_LoaiPhong";
            this.Load += new System.EventHandler(this.Frm_LoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGBindingNavigator)).EndInit();
            this.lOAIPHONGBindingNavigator.ResumeLayout(false);
            this.lOAIPHONGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_loaiphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator lOAIPHONGBindingNavigator;
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
        private System.Windows.Forms.DataGridView dtgridview_loaiphong;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStripButton btn_thoat;
        private System.Windows.Forms.ToolStripButton btn_timkiem;
        private System.Windows.Forms.TextBox txt_tenloaiphong;
        private System.Windows.Forms.TextBox txt_maloai;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.ToolStripButton btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}