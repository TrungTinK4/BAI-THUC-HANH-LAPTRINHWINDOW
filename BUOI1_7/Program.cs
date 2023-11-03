using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac so nguyen to tu 1 den " + n + " la:");
            for (int i = 1; i <= n; i++)
            {
                if (LaSoNguyenTo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
        static bool LaSoNguyenTo(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num <= 3)
            {
                return true;
            }
            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
