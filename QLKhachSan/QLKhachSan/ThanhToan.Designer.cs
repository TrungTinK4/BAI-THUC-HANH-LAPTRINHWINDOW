﻿
namespace QLKhachSan
{

    partial class frmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthotenTT = new System.Windows.Forms.TextBox();
            this.btnTKTMKH = new System.Windows.Forms.Button();
            this.cbmaKH = new System.Windows.Forms.ComboBox();
            this.tblkhachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLKhachSan.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXemHD = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lbNgayTT = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTongTienTT = new System.Windows.Forms.Label();
            this.lbSoNgayO = new System.Windows.Forms.Label();
            this.lbPhongSo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTinhTienTT = new System.Windows.Forms.Button();
            this.btnThoatTT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listThanhToan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.tblphongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblphongTableAdapter = new QLKhachSan.DataSet1TableAdapters.tblphongTableAdapter();
            this.tblkhachhangTableAdapter = new QLKhachSan.DataSet1TableAdapters.tblkhachhangTableAdapter();
            this.quanLyKSDataSet = new QLKhachSan.QuanLyKSDataSet();
            this.tblkhachhangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblkhachhangTableAdapter1 = new QLKhachSan.QuanLyKSDataSetTableAdapters.tblkhachhangTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txthotenTT);
            this.groupBox1.Controls.Add(this.btnTKTMKH);
            this.groupBox1.Controls.Add(this.cbmaKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên:";
            // 
            // txthotenTT
            // 
            this.txthotenTT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthotenTT.Location = new System.Drawing.Point(184, 102);
            this.txthotenTT.Name = "txthotenTT";
            this.txthotenTT.Size = new System.Drawing.Size(257, 22);
            this.txthotenTT.TabIndex = 3;
            this.txthotenTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTKTMKH
            // 
            this.btnTKTMKH.Location = new System.Drawing.Point(352, 26);
            this.btnTKTMKH.Name = "btnTKTMKH";
            this.btnTKTMKH.Size = new System.Drawing.Size(211, 23);
            this.btnTKTMKH.TabIndex = 2;
            this.btnTKTMKH.Text = "Tìm kiếm theo mã khách hàng";
            this.btnTKTMKH.UseVisualStyleBackColor = true;
            this.btnTKTMKH.Click += new System.EventHandler(this.btnTKTMKH_Click);
            // 
            // cbmaKH
            // 
            this.cbmaKH.DataSource = this.tblkhachhangBindingSource1;
            this.cbmaKH.DisplayMember = "makh";
            this.cbmaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmaKH.FormattingEnabled = true;
            this.cbmaKH.Location = new System.Drawing.Point(102, 28);
            this.cbmaKH.Name = "cbmaKH";
            this.cbmaKH.Size = new System.Drawing.Size(182, 23);
            this.cbmaKH.TabIndex = 1;
            // 
            // tblkhachhangBindingSource
            // 
            this.tblkhachhangBindingSource.DataMember = "tblkhachhang";
            this.tblkhachhangBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.btnXemHD);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.lbNgayTT);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnThemHoaDon);
            this.groupBox2.Controls.Add(this.lbMaKH);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbTenKH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbTongTienTT);
            this.groupBox2.Controls.Add(this.lbSoNgayO);
            this.groupBox2.Controls.Add(this.lbPhongSo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTinhTienTT);
            this.groupBox2.Controls.Add(this.btnThoatTT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(474, 57);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(89, 23);
            this.btnInHoaDon.TabIndex = 23;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXemHD
            // 
            this.btnXemHD.Location = new System.Drawing.Point(458, 172);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(105, 23);
            this.btnXemHD.TabIndex = 22;
            this.btnXemHD.Text = "Xem DS Hóa Đơn";
            this.btnXemHD.UseVisualStyleBackColor = true;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(246, 175);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(92, 22);
            this.txtMaHD.TabIndex = 5;
            this.txtMaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // lbNgayTT
            // 
            this.lbNgayTT.AutoSize = true;
            this.lbNgayTT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTT.Location = new System.Drawing.Point(138, 106);
            this.lbNgayTT.Name = "lbNgayTT";
            this.lbNgayTT.Size = new System.Drawing.Size(22, 15);
            this.lbNgayTT.TabIndex = 21;
            this.lbNgayTT.Text = ".....";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Ngày thanh toán:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mã hóa đơn:";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(352, 172);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(89, 23);
            this.btnThemHoaDon.TabIndex = 17;
            this.btnThemHoaDon.Text = "Thêm Hóa Đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(138, 41);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(22, 15);
            this.lbMaKH.TabIndex = 16;
            this.lbMaKH.Text = ".....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã khách hàng:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(138, 74);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(22, 15);
            this.lbTenKH.TabIndex = 14;
            this.lbTenKH.Text = ".....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khách hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "VND";
            // 
            // lbTongTienTT
            // 
            this.lbTongTienTT.AutoSize = true;
            this.lbTongTienTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTienTT.Location = new System.Drawing.Point(317, 140);
            this.lbTongTienTT.Name = "lbTongTienTT";
            this.lbTongTienTT.Size = new System.Drawing.Size(29, 19);
            this.lbTongTienTT.TabIndex = 11;
            this.lbTongTienTT.Text = ".....";
            // 
            // lbSoNgayO
            // 
            this.lbSoNgayO.AutoSize = true;
            this.lbSoNgayO.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNgayO.Location = new System.Drawing.Point(382, 43);
            this.lbSoNgayO.Name = "lbSoNgayO";
            this.lbSoNgayO.Size = new System.Drawing.Size(25, 15);
            this.lbSoNgayO.TabIndex = 10;
            this.lbSoNgayO.Text = "......";
            // 
            // lbPhongSo
            // 
            this.lbPhongSo.AutoSize = true;
            this.lbPhongSo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongSo.Location = new System.Drawing.Point(382, 75);
            this.lbPhongSo.Name = "lbPhongSo";
            this.lbPhongSo.Size = new System.Drawing.Size(22, 15);
            this.lbPhongSo.TabIndex = 9;
            this.lbPhongSo.Text = ".....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền Phải Thanh Toán:";
            // 
            // btnTinhTienTT
            // 
            this.btnTinhTienTT.Location = new System.Drawing.Point(474, 31);
            this.btnTinhTienTT.Name = "btnTinhTienTT";
            this.btnTinhTienTT.Size = new System.Drawing.Size(89, 23);
            this.btnTinhTienTT.TabIndex = 6;
            this.btnTinhTienTT.Text = "Tính Tiền";
            this.btnTinhTienTT.UseVisualStyleBackColor = true;
            this.btnTinhTienTT.Click += new System.EventHandler(this.btnTinhTienTT_Click);
            // 
            // btnThoatTT
            // 
            this.btnThoatTT.Location = new System.Drawing.Point(474, 106);
            this.btnThoatTT.Name = "btnThoatTT";
            this.btnThoatTT.Size = new System.Drawing.Size(89, 23);
            this.btnThoatTT.TabIndex = 7;
            this.btnThoatTT.Text = "Thoát";
            this.btnThoatTT.UseVisualStyleBackColor = true;
            this.btnThoatTT.Click += new System.EventHandler(this.btnThoatTT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Ngày Ở:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listThanhToan);
            this.groupBox3.Location = new System.Drawing.Point(27, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 223);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Khách Hàng Thanh Toán";
            // 
            // listThanhToan
            // 
            this.listThanhToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listThanhToan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listThanhToan.HideSelection = false;
            this.listThanhToan.Location = new System.Drawing.Point(6, 29);
            this.listThanhToan.Name = "listThanhToan";
            this.listThanhToan.Size = new System.Drawing.Size(571, 188);
            this.listThanhToan.TabIndex = 0;
            this.listThanhToan.UseCompatibleStateImageBehavior = false;
            this.listThanhToan.View = System.Windows.Forms.View.Details;
            this.listThanhToan.Click += new System.EventHandler(this.listThanhToan_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã KH";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên KH";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số CMND/ PassPort";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số điện thoại";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(258, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "THANH TOÁN";
            // 
            // tblphongBindingSource
            // 
            this.tblphongBindingSource.DataMember = "tblphong";
            this.tblphongBindingSource.DataSource = this.dataSet1;
            // 
            // tblphongTableAdapter
            // 
            this.tblphongTableAdapter.ClearBeforeFill = true;
            // 
            // tblkhachhangTableAdapter
            // 
            this.tblkhachhangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyKSDataSet
            // 
            this.quanLyKSDataSet.DataSetName = "QuanLyKSDataSet";
            this.quanLyKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblkhachhangBindingSource1
            // 
            this.tblkhachhangBindingSource1.DataMember = "tblkhachhang";
            this.tblkhachhangBindingSource1.DataSource = this.quanLyKSDataSet;
            // 
            // tblkhachhangTableAdapter1
            // 
            this.tblkhachhangTableAdapter1.ClearBeforeFill = true;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 644);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTKTMKH;
        private System.Windows.Forms.ComboBox cbmaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTinhTienTT;
        private System.Windows.Forms.Button btnThoatTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listThanhToan;
        private System.Windows.Forms.Label label6;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblphongBindingSource;
        private DataSet1TableAdapters.tblphongTableAdapter tblphongTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.BindingSource tblkhachhangBindingSource;
        private DataSet1TableAdapters.tblkhachhangTableAdapter tblkhachhangTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTongTienTT;
        private System.Windows.Forms.Label lbSoNgayO;
        private System.Windows.Forms.Label lbPhongSo;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthotenTT;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Label lbNgayTT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnXemHD;
        private System.Windows.Forms.Button btnInHoaDon;
        private QuanLyKSDataSet quanLyKSDataSet;
        private System.Windows.Forms.BindingSource tblkhachhangBindingSource1;
        private QuanLyKSDataSetTableAdapters.tblkhachhangTableAdapter tblkhachhangTableAdapter1;
    }
}