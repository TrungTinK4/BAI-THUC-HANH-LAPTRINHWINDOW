using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Nhap ba so nguyen a, b, c:");
                int a, b, c;

                // Nhập giá trị a, b và c từ người dùng
                Console.Write("Nhap a: ");
                while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.Write("Vui long nhap lai a (so nguyen duong): ");
                }

                Console.Write("Nhap b: ");
                while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.Write("Vui long nhap lai b (so nguyen duong): ");
                }

                Console.Write("Nhap c: ");
                while (!int.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.Write("Vui long nhap lai c (so nguyen duong): ");
                }

                // Kiểm tra xem ba số a, b, c có phải là ba cạnh của tam giác không
                if (IsTriangle(a, b, c))
                {
                    double p = (a + b + c) / 2.0; // Tính nửa chu vi
                    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Tính diện tích

                    Console.WriteLine($"Ba so {a}, {b}, {c} la ba canh caa mot tam giac.");
                    Console.WriteLine($"Chu vi caa tam giac la: {2 * p}");
                    Console.WriteLine($"Dien tich caa tam giac la: {area}");
                Console.ReadKey();

            }
                else
                {
                    Console.WriteLine($"Ba so {a}, {b}, {c} khong the tao thanh mot tam giac.");
                Console.ReadKey();
            }
            }

            // Hàm kiểm tra ba số nguyên có phải là ba cạnh của tam giác
            static bool IsTriangle(int a, int b, int c)
            {
                return a + b > c && a + c > b && b + c > a;
            }
        }

    }

