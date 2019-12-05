namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    partial class Frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoaDon));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hOADONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_in = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.hOADONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_hoat = new System.Windows.Forms.ToolStripButton();
            this.btn_tk = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).BeginInit();
            this.hOADONBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelX1.Location = new System.Drawing.Point(276, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(130, 32);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "HOÁ ĐƠN";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 29);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // hOADONBindingNavigator
            // 
            this.hOADONBindingNavigator.AddNewItem = null;
            this.hOADONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hOADONBindingNavigator.DeleteItem = this.btn_in;
            this.hOADONBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOADONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btn_in,
            this.hOADONBindingNavigatorSaveItem,
            this.btn_hoat,
            this.btn_tk});
            this.hOADONBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hOADONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hOADONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hOADONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hOADONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hOADONBindingNavigator.Name = "hOADONBindingNavigator";
            this.hOADONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hOADONBindingNavigator.Size = new System.Drawing.Size(657, 32);
            this.hOADONBindingNavigator.TabIndex = 0;
            this.hOADONBindingNavigator.Text = "bindingNavigator1";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_hoadon.Location = new System.Drawing.Point(13, 83);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.Size = new System.Drawing.Size(632, 264);
            this.dgv_hoadon.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENKH";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MAP";
            this.Column4.HeaderText = "Mã phòng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYLAP";
            this.Column5.HeaderText = "Ngày lập";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TONGTIEN";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.Name = "Column6";
            // 
            // btn_in
            // 
            this.btn_in.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources._in;
            this.btn_in.Name = "btn_in";
            this.btn_in.RightToLeftAutoMirrorImage = true;
            this.btn_in.Size = new System.Drawing.Size(48, 29);
            this.btn_in.Text = "In";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // btn_them
            // 
            this.btn_them.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.add;
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 29);
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // hOADONBindingNavigatorSaveItem
            // 
            this.hOADONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hOADONBindingNavigatorSaveItem.Image")));
            this.hOADONBindingNavigatorSaveItem.Name = "hOADONBindingNavigatorSaveItem";
            this.hOADONBindingNavigatorSaveItem.Size = new System.Drawing.Size(63, 29);
            this.hOADONBindingNavigatorSaveItem.Text = "Lưu";
            this.hOADONBindingNavigatorSaveItem.Click += new System.EventHandler(this.hOADONBindingNavigatorSaveItem_Click);
            // 
            // btn_hoat
            // 
            this.btn_hoat.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.thoat;
            this.btn_hoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_hoat.Name = "btn_hoat";
            this.btn_hoat.Size = new System.Drawing.Size(80, 29);
            this.btn_hoat.Text = "Thoát";
            this.btn_hoat.Click += new System.EventHandler(this.btn_hoat_Click);
            // 
            // btn_tk
            // 
            this.btn_tk.Image = global::Phan_Mem_QL_Khach_San.Properties.Resources.find;
            this.btn_tk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(108, 29);
            this.btn_tk.Text = "Tìm kiếm";
            // 
            // Frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 369);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.hOADONBindingNavigator);
            this.Name = "Frm_HoaDon";
            this.Text = "Frm_HoaDon";
            this.Load += new System.EventHandler(this.Frm_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).EndInit();
            this.hOADONBindingNavigator.ResumeLayout(false);
            this.hOADONBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private ql_khachsanDataSet ql_khachsanDataSet;
        //private ql_khachsanDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        //private ql_khachsanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_in;
        private System.Windows.Forms.ToolStripButton hOADONBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btn_hoat;
        private System.Windows.Forms.ToolStripButton btn_tk;
        private System.Windows.Forms.BindingNavigator hOADONBindingNavigator;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}