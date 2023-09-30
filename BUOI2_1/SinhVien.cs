using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SinhVien
    {
        class SinhVien
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public double DiemTB { get; set; }
            public string TenKhoa { get; set; }

            public void NhapThongTin()
            {
                Console.Write("Nhap ma sinh vien: ");
                MaSV = Console.ReadLine();
                Console.Write("Nhap ho ten sinh vien: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhap diem trung binh: ");
                DiemTB = double.Parse(Console.ReadLine());
                Console.Write("Nhap ten khoa: ");
                TenKhoa = Console.ReadLine();
            }

            public void XuatThongTin()
            {
                Console.WriteLine($"Ma sinh vien: {MaSV}");
                Console.WriteLine($"Ho ten sinh vien: {HoTen}");
                Console.WriteLine($"Diem trung binh: {DiemTB}");
                Console.WriteLine($"Ten khoa: {TenKhoa}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Nhap tong so sinh vien: ");
                int n = int.Parse(Console.ReadLine());

                SinhVien[] arrSinhVien = new SinhVien[n];

                for (int i = 0; i < n; i++)
                {
                    arrSinhVien[i] = new SinhVien();
                    arrSinhVien[i].NhapThongTin();
                    Console.WriteLine();
                }

                for (int i = 0; i < n; i++)
                {
                    arrSinhVien[i].XuatThongTin();
                    Console.WriteLine();
                }
            }
        }
    }
}
}
