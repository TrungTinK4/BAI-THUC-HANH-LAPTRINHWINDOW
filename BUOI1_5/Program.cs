using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Nhap so luong sinh vien: ");
                int n;

                // Nhập số lượng sinh viên từ người dùng
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Write("Vui long nhap lai so luong sinh vien (so nguyen duog): ");
                }

                string[] dssinhvien = new string[n];

                // Nhập danh sách họ tên sinh viên
                NhapSV(dssinhvien, n);

                // Xuất danh sách sinh viên lên màn hình
                Console.WriteLine("Danh sach sinh vien:");
                XuatSV(dssinhvien, n);
            Console.ReadKey();
        }

            // Hàm nhập danh sách họ tên sinh viên
            static void NhapSV(string[] dssinhvien, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap ho ten của sinh vien {i + 1}: ");
                    dssinhvien[i] = Console.ReadLine();


            }
        }

            // Hàm xuất danh sách sinh viên
            static void XuatSV(string[] dssinhvien, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Sinh vien {i + 1}: {dssinhvien[i]}");
                Console.ReadKey();
            }
        }
            }
        }

    }

