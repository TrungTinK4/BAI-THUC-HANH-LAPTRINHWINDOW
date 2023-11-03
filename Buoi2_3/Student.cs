using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_3
{
    internal class Student : Person
    {
        public string MaSV { get; set; }

        public double DiemTB { get; set; }

        public string Khoa { get; set; }

        public Student()
        {
        }

        public Student(string cmnd, string hoten, string diachi, string masv, double diemtb, string khoa)
            : base(cmnd, hoten, diachi) 
        {
            MaSV = masv;
            DiemTB = diemtb;
            Khoa = khoa;
        }

        public Student(Student otherStudent)
            : base(otherStudent.CMND, otherStudent.HoTen, otherStudent.DiaChi)
        {
            MaSV = otherStudent.MaSV;
            DiemTB = otherStudent.DiemTB;
            Khoa = otherStudent.Khoa;
        }

        public void Nhap()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiaChi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("MaSV:{0} \t HoTen:{1} \t DiaChi:{2} \t DiemTB:{3} \t Khoa:{4}", MaSV, HoTen, DiaChi, DiemTB, Khoa);
        }
    }
}
