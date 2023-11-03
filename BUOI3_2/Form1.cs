using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_2
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string listSV = "";
        int stt = 1;

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên không được để trống");
                }
                string hoten = txtHoTen.Text;
                string masv = txtMaSV.Text;
                string ngaysinh = txtNgaySinh.Text;
                string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
                string sothich = null;
                if(cbTheThao.Checked)
                {
                    sothich += "Thể thao";
                }
                if (cbDuLich.Checked)
                {
                    sothich += "Du lịch";
                }
                if (cbMuaSam.Checked)
                {
                    sothich += "Mua sắm";
                }
                stt += 1;
                listSV += stt.ToString() + ". Họ tên: " + hoten + " Ngày sinh: " + ngaysinh + " Giới tính: " + gioitinh + " Sở thích: " + sothich + "\r\n";
                txtDS.Text = listSV;
                txtHoTen.Text = null;
                txtMaSV.Text = null;
                txtNgaySinh.Text = null;
                cbDuLich.Checked = false;
                cbMuaSam.Checked = false;
                cbTheThao.Checked = false;
                lblThongBao.Text = null;
            }
            catch (Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDS.Text = null;
            listSV = null;
        }
    }
}
