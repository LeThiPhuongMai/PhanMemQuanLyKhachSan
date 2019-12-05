namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.btn_dongy = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_huy = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelX1.Location = new System.Drawing.Point(150, -3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(409, 102);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(278, 160);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(239, 29);
            this.txt_pass.TabIndex = 16;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(278, 105);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(239, 29);
            this.txt_user.TabIndex = 15;
            // 
            // lb_pass
            // 
            this.lb_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.Black;
            this.lb_pass.Location = new System.Drawing.Point(157, 150);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(120, 47);
            this.lb_pass.TabIndex = 14;
            this.lb_pass.Text = "PASSWORD: ";
            this.lb_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_user
            // 
            this.lb_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.Black;
            this.lb_user.Location = new System.Drawing.Point(157, 102);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(82, 40);
            this.lb_user.TabIndex = 13;
            this.lb_user.Text = "USER:  ";
            this.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dongy
            // 
            this.btn_dongy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dongy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dongy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dongy.Image = ((System.Drawing.Image)(resources.GetObject("btn_dongy.Image")));
            this.btn_dongy.ImageTextSpacing = 5;
            this.btn_dongy.Location = new System.Drawing.Point(240, 232);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.Size = new System.Drawing.Size(104, 38);
            this.btn_dongy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dongy.TabIndex = 17;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 151);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.ImageTextSpacing = 5;
            this.btn_huy.Location = new System.Drawing.Point(392, 232);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(103, 38);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huy.TabIndex = 20;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(571, 302);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Name = "Frm_DangNhap";
            this.Text = "Frm_DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void btn_huy_Click(object sender, System.EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        //private void btn_dongy_Click(object sender, System.EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_user;
        private DevComponents.DotNetBar.ButtonX btn_dongy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btn_huy;
    }
}

