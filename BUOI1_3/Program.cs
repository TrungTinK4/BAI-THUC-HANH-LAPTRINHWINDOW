using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Nhap so nguyen duong n: ");
                int n;

                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Write("Vui long nhập lai so nguyen duong n: ");
                }

              
                int sum = 0;
                for (int i = 1; i <= 2 * n - 1; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine($"Tong cac so le từ 1 đen {2 * n - 1} là: {sum}");
                Console.ReadKey();
            }
        }

    }
