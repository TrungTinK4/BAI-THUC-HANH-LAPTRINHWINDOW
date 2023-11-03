using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai canh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh c: ");
            int c = int.Parse(Console.ReadLine());

            if (LaTamGiac(a, b, c))
            {
                double chuVi = TinhChuVi(a, b, c);
                double dienTich = TinhDienTich(a, b, c);

                Console.WriteLine($"Ba so {a}, {b}, và {c} la do dai ba canh cua mot tam giac.");
                Console.WriteLine($"Chu vi cua tam giac la: {chuVi}");
                Console.WriteLine($"Dien tich cua tam giac la: {dienTich}");
            }
            else
            {
                Console.WriteLine($"Ba so {a}, {b}, va {c} khong phai la do dai ban canh cua mot tam giac.");
            }
            Console.ReadKey();
        }

        static bool LaTamGiac(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static double TinhChuVi(int a, int b, int c)
        {
            return a + b + c;
        }

        static double TinhDienTich(int a, int b, int c)
        {
            double p = TinhChuVi(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
