using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_3
{
    internal class Teacher : Person
    {
        public string MaGV { get; set; }

        public string Khoa { get; set; }

        public string ChucVu { get; set; }

        public Teacher() { }

        public Teacher(string cmnd, string hoten, string diachi, string magv, string khoa, string chucvu)
            : base(cmnd, hoten, diachi)
        {
            MaGV = magv;
            Khoa = khoa;
            ChucVu = chucvu;
        }

        public Teacher(Teacher otherTeacher)
            : base(otherTeacher.CMND, otherTeacher.HoTen, otherTeacher.DiaChi)
        {
            MaGV = otherTeacher.MaGV;
            Khoa = otherTeacher.Khoa;
            ChucVu = otherTeacher.ChucVu;
        }

        public void Nhap()
        {
            Console.Write("Nhap MaGV: ");
            MaGV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiaChi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhap ChucVu: ");
            ChucVu = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("MaGV:{0} \t HoTen:{1} \t DiaChi:{2} \t Khoa:{3} \t ChucVu:{4}", MaGV, HoTen, DiaChi, Khoa, ChucVu);
        }
    }
}
