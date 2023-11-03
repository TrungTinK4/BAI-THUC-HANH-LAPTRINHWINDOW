using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_baitapvenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string listSach = "";
        int stt = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSach.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sách không được để trống");
                }
                string masach = txtMaSach.Text;
                string tensach = txtTenSach.Text;
                string gia = txtGia.Text;
                string soluong = txtSoLuong.Text;
                stt += 1;
                listSach += stt.ToString() + ". Tên sách: " + tensach + ", Mã sách: " + masach + ", Giá: " + gia + ", Số lượng: " + soluong + "\r\n";
                txtDS.Text = listSach;
                txtMaSach.Text = null;
                txtTenSach.Text = null;
                txtGia.Text = null;
                txtSoLuong.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDS.Text = null;
            listSach = null;
            stt = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
