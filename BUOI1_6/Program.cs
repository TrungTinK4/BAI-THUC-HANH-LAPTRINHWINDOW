using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac hai ax^2 + bx + c = 0");

            // Nhap cac he so a, b, c tu nguoi dung
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap he so b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap he so c: ");
            double c = double.Parse(Console.ReadLine());

            // Goi ham de giai phuong trinh va hien thi ket qua
            GiaiPhuongTrinhBacHai(a, b, c);

            Console.ReadKey();
        }
        static void GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            // Tinh delta
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                // Hai nghiem phan biet
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co hai nghiem phan biet:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (delta == 0)
            {
                // Nghiem kep
                double x = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                // Khong co nghiem thuc
                Console.WriteLine("Phuong trinh khong co nghiem thuc.");
            }
        }
    }
}
