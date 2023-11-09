using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhachSan
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = @"Data Source=DESKTOP-ARJSDIE\SQLTRUNGTIN;Initial Catalog=QLKhachSan;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void FormTTKhachHang_Load(object sender, EventArgs e)
        {
           
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        public void hienthi()
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = @"Select makh, tenkh, gioitinh, ngaysinh, cmnd, diachi, sdt, ghichu From tblkhachhang";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listThongThinKH.Items.Add(docdulieu[0].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[1].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[2].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[3].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[4].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[5].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = @"Select makh, tenkh, gioitinh, ngaysinh, cmnd, diachi, sdt, ghichu From tblkhachhang Where(makh like'%" + cbMaKH.Text + "%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listThongThinKH.Items.Add(docdulieu[0].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[1].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[2].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[3].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[4].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[5].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void listThongThinKH_Click(object sender, EventArgs e)
        {
            txtMkh.Text = listThongThinKH.SelectedItems[0].SubItems[0].Text;
            txtTenkh.Text = listThongThinKH.SelectedItems[0].SubItems[1].Text;
            cbGioiTinh.Text = listThongThinKH.SelectedItems[0].SubItems[2].Text;
            txtNgaysinh.Text = listThongThinKH.SelectedItems[0].SubItems[3].Text;
            txtCmnd.Text = listThongThinKH.SelectedItems[0].SubItems[4].Text;
            txtDiachi.Text = listThongThinKH.SelectedItems[0].SubItems[5].Text;
            txtSodt.Text = listThongThinKH.SelectedItems[0].SubItems[6].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = @"Insert Into tblkhachhang(makh, tenkh, gioitinh, ngaysinh, cmnd, diachi, sdt, ghichu)    VALUES  (N'" + txtMkh.Text + @"',N'" + txtTenkh.Text + @"',N'" + cbGioiTinh.Text + @"',N'" + txtNgaysinh.Text + @"',N'" + txtCmnd.Text + @"',N'" + txtDiachi.Text + @"',N'" + txtSodt.Text + @"',N'" + txtGhichu.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            try
            {

                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            ketnoi.Close();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE tblkhachhang SET makh = N'" + txtMkh.Text + @"', tenkh = N'" + txtTenkh.Text + @"', gioitinh = N'" + cbGioiTinh.Text + @"', ngaysinh = N'" + txtNgaysinh.Text + @"', cmnd = N'" + txtCmnd.Text + @"', diachi = N'" + txtDiachi.Text + @"', sdt = N'" + txtSodt.Text + @"', ghichu = N'" + txtGhichu.Text + "'    WHERE   (makh = N'" + txtMkh.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            try
            {

                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Sửa Thông Tinh Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            ketnoi.Close();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = "Delete From tblkhachhang  WHERE   (makh=N'" + txtMkh.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            try
            {

                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Xóa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            ketnoi.Close();
            hienthi();
        }

    }
}
