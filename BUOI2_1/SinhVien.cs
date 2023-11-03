using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_1
{
    internal class SinhVien
    {
        private string _MaSV;
        private string _HoTen;
        private double _DiemTB;
        private string _Khoa;
        public SinhVien() { }
        public SinhVien(string masv, string hoten, double dtb, string khoa)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.DiemTB = dtb;
            this.Khoa = khoa;
        }
        public SinhVien(SinhVien sv)
        {
            this.MaSV = sv._MaSV;
            this.HoTen = sv._HoTen;
            this.DiemTB = sv._DiemTB;
            this.Khoa = sv._Khoa;
        }
        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        public double DiemTB
        {
            get { return _DiemTB; }
            set { _DiemTB = value; }
        }

        public string Khoa
        {
            get { return _Khoa; }
            set { _Khoa = value; }
        }

        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV:{0} \t HoTen:{1} \t DiemTB:{2} \t Khoa:{3}", MaSV, HoTen, DiemTB, Khoa);
        }
    }

}
