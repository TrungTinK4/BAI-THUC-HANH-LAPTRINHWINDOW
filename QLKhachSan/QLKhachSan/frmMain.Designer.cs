namespace QLKhachSan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnHeThong = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadonTableAdapter1 = new QLKhachSan.qlksDataSetTableAdapters.hoadonTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnstripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripQLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThongTinKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnHeThong
            // 
            this.mnHeThong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnstripHeThong,
            this.mnstripQLKhachHang,
            this.mnstripQLPhong});
            this.mnHeThong.Location = new System.Drawing.Point(0, 0);
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(1327, 30);
            this.mnHeThong.TabIndex = 0;
            this.mnHeThong.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 26);
            // 
            // hoadonTableAdapter1
            // 
            this.hoadonTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2560, 1312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mnstripHeThong
            // 
            this.mnstripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemDoiMK,
            this.mnitemDangXuat,
            this.mnitemThoat});
            this.mnstripHeThong.Name = "mnstripHeThong";
            this.mnstripHeThong.Size = new System.Drawing.Size(108, 26);
            this.mnstripHeThong.Text = "Hệ Thống";
            this.mnstripHeThong.Click += new System.EventHandler(this.mnstripHeThong_Click);
            // 
            // mnitemDoiMK
            // 
            this.mnitemDoiMK.Name = "mnitemDoiMK";
            this.mnitemDoiMK.Size = new System.Drawing.Size(183, 26);
            this.mnitemDoiMK.Text = "Đổi Mật Khẩu";
            this.mnitemDoiMK.Click += new System.EventHandler(this.mnitemDoiMK_Click);
            // 
            // mnitemDangXuat
            // 
            this.mnitemDangXuat.Name = "mnitemDangXuat";
            this.mnitemDangXuat.Size = new System.Drawing.Size(183, 26);
            this.mnitemDangXuat.Text = "Đăng Xuất";
            this.mnitemDangXuat.Click += new System.EventHandler(this.mnitemDangXuat_Click);
            // 
            // mnitemThoat
            // 
            this.mnitemThoat.Name = "mnitemThoat";
            this.mnitemThoat.Size = new System.Drawing.Size(183, 26);
            this.mnitemThoat.Text = "Thoát";
            this.mnitemThoat.Click += new System.EventHandler(this.mnitemThoat_Click);
            // 
            // mnstripQLKhachHang
            // 
            this.mnstripQLKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemThongTinKH,
            this.mnitemThanhToan});
            this.mnstripQLKhachHang.Name = "mnstripQLKhachHang";
            this.mnstripQLKhachHang.Size = new System.Drawing.Size(179, 26);
            this.mnstripQLKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // mnitemThongTinKH
            // 
            this.mnitemThongTinKH.Name = "mnitemThongTinKH";
            this.mnitemThongTinKH.Size = new System.Drawing.Size(242, 26);
            this.mnitemThongTinKH.Text = "Thông Tin Khách Hàng";
            this.mnitemThongTinKH.Click += new System.EventHandler(this.mnitemThongTinKH_Click);
            // 
            // mnitemThanhToan
            // 
            this.mnitemThanhToan.Name = "mnitemThanhToan";
            this.mnitemThanhToan.Size = new System.Drawing.Size(242, 26);
            this.mnitemThanhToan.Text = "Thanh Toán";
            this.mnitemThanhToan.Click += new System.EventHandler(this.mnitemThanhToan_Click);
            // 
            // mnstripQLPhong
            // 
            this.mnstripQLPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemDatPhong,
            this.mnitemThuePhong,
            this.mnitemPhong,
            this.mnitemHoaDon});
            this.mnstripQLPhong.Name = "mnstripQLPhong";
            this.mnstripQLPhong.Size = new System.Drawing.Size(141, 26);
            this.mnstripQLPhong.Text = "Quản Lý Phòng";
            // 
            // mnitemDatPhong
            // 
            this.mnitemDatPhong.Name = "mnitemDatPhong";
            this.mnitemDatPhong.Size = new System.Drawing.Size(170, 26);
            this.mnitemDatPhong.Text = "Đặt Phòng";
            this.mnitemDatPhong.Click += new System.EventHandler(this.mnitemDatPhong_Click);
            // 
            // mnitemThuePhong
            // 
            this.mnitemThuePhong.Name = "mnitemThuePhong";
            this.mnitemThuePhong.Size = new System.Drawing.Size(170, 26);
            this.mnitemThuePhong.Text = "Thuê Phòng";
            this.mnitemThuePhong.Click += new System.EventHandler(this.mnitemThuePhong_Click);
            // 
            // mnitemPhong
            // 
            this.mnitemPhong.Name = "mnitemPhong";
            this.mnitemPhong.Size = new System.Drawing.Size(170, 26);
            this.mnitemPhong.Text = "Phòng";
            this.mnitemPhong.Click += new System.EventHandler(this.mnitemPhong_Click);
            // 
            // mnitemHoaDon
            // 
            this.mnitemHoaDon.Name = "mnitemHoaDon";
            this.mnitemHoaDon.Size = new System.Drawing.Size(170, 26);
            this.mnitemHoaDon.Text = "Hóa Đơn";
            this.mnitemHoaDon.Click += new System.EventHandler(this.mnitemHoaDon_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnHeThong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnHeThong;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.mnHeThong.ResumeLayout(false);
            this.mnHeThong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnstripHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnstripQLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnstripQLPhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemDoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnitemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnitemThoat;
        private System.Windows.Forms.ToolStripMenuItem mnitemThongTinKH;
        private System.Windows.Forms.ToolStripMenuItem mnitemThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnitemDatPhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemThuePhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemPhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemHoaDon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private qlksDataSetTableAdapters.hoadonTableAdapter hoadonTableAdapter1;
    }
}