using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            
                Console.Write("Nhap so nguyen duong n: ");
                int n;


                // Kiểm tra và đảm bảo n là một số nguyên dương
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Write("Vui long nhap lai so nguyen duong n: ");
                }

                Console.WriteLine("Cac so nguyen to từ 1 đến {n}:");
                for (int i = 2; i <= n; i++)
                

            {
                if (IsPrime(i))
                    {
                        Console.WriteLine(i);
                    Console.ReadKey();
                }
                }
            }

            // Hàm kiểm tra xem một số có phải là số nguyên tố hay không
            static bool IsPrime(int number)
            {
                if (number <= 1)
                {
                    return false;
                }

                if (number == 2)
                {
                    return true;
                }

                if (number % 2 == 0)
                {
                    return false;
                }

                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

    }
