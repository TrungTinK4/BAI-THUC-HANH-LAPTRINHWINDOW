namespace BUOI4_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cbKhoa = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtMaSV = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvDanhSach = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            masv = new DataGridViewTextBoxColumn();
            hoten = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            khoa = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbKhoa);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(671, 93);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(300, 33);
            cbKhoa.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(671, 35);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(300, 33);
            dtpNgaySinh.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(163, 93);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(322, 33);
            txtHoTen.TabIndex = 5;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(163, 35);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(322, 33);
            txtMaSV.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 101);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 3;
            label5.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 43);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 2;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 101);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 1;
            label3.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 43);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(34, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(992, 95);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(825, 41);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(553, 41);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(287, 41);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 34);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhập";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(38, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDanhSach);
            groupBox3.Location = new Point(34, 376);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(992, 211);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { masv, hoten, ngaysinh, khoa });
            dgvDanhSach.Location = new Point(38, 32);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 62;
            dgvDanhSach.RowTemplate.Height = 35;
            dgvDanhSach.Size = new Size(932, 162);
            dgvDanhSach.TabIndex = 0;
            dgvDanhSach.CellContentClick += dgvDanhSach_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(310, 29);
            label1.Name = "label1";
            label1.Size = new Size(473, 54);
            label1.TabIndex = 4;
            label1.Text = "THÔNG TIN SINH VIÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // masv
            // 
            masv.HeaderText = "Mã SV";
            masv.MinimumWidth = 8;
            masv.Name = "masv";
            masv.Width = 150;
            // 
            // hoten
            // 
            hoten.HeaderText = "Họ tên";
            hoten.MinimumWidth = 8;
            hoten.Name = "hoten";
            hoten.Width = 150;
            // 
            // ngaysinh
            // 
            ngaysinh.HeaderText = "Ngày sinh";
            ngaysinh.MinimumWidth = 8;
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Width = 150;
            // 
            // khoa
            // 
            khoa.HeaderText = "Khoa";
            khoa.MinimumWidth = 8;
            khoa.Name = "khoa";
            khoa.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 617);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private ComboBox cbKhoa;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private MaskedTextBox txtMaSV;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private DataGridView dgvDanhSach;
        private DataGridViewTextBoxColumn masv;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn khoa;
    }
}