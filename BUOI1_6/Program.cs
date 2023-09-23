using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
        
        
            
                Console.WriteLine("Giai phuong trinh ax^2 + bx + c = 0");

                // Nhập các hệ số a, b và c từ người dùng
                Console.Write("Nhap he so a: ");
                double a;
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Vui long nhap lai he so a: ");
                }

                Console.Write("Nhap he so b: ");
                double b;
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Vui long nhap lai he so b: ");
                }

                Console.Write("Nhap he so c: ");
                double c;
                while (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.Write("Vui long nhap lai he so c: ");
                }

                // Gọi hàm để giải phương trình và hiển thị kết quả
                SolveQuadraticEquation(a, b, c);
            }

            // Hàm giải phương trình bậc hai
            static void SolveQuadraticEquation(double a, double b, double c)
            {
                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"Phuog trinh có hai nghiem phân biet:");
                    Console.WriteLine($"x1 = {root1}");
                    Console.WriteLine($"x2 = {root2}");
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    Console.WriteLine($"Phương trinh co mot nghiem kep:");
                    Console.WriteLine($"x = {root}");
                }
                else
                {
                    Console.WriteLine("Phuong trinh khong có nghiemm thuc.");
                Console.ReadKey();
            }
            }
        }

    }
