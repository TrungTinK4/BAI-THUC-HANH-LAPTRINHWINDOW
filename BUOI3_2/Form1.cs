using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUOI3_2
{
    public partial class Form1 : Form
    {
        private int stt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("H9 ten sinh vien kh8ng de rOng");
                }
                string hoten = txtHoTen.Text;
                string masv = mtxtMaSV.Text;
                string ngaysinh = mtxtNgaySinh.Text;
                string gioitinh =   "Nam";
                string sothich = null;
                if (chbDuLich.Checked)
                {
                    sothich += "Du Lich";
                }
                if (chbTheThao.Checked)
                {
                    sothich += "The Thao";
                }
                if (chbMuaSam.Checked)
                {
                    sothich += "Mua Sam";
                }
                if (sothich != null)
                {
                    sothich = " Sd thich: " + sothich;
                }
                txtDanhSach.Text += stt + ". Họ tên: " + hoten + " Ngày sinh: " + ngaysinh + " Giới tính: " + gioitinh + sothich + "\r\n";
                stt++;
            }
            catch (Exception ex)
            {
                lblTBB.Text = ex.Message;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
