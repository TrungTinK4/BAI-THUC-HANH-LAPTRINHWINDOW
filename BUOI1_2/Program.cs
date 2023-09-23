using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI1_2

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thang (1-12): ");
            int thang = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            int soNgay = TinhSoNgayTrongThang(thang, nam);
            Console.WriteLine($"So ngay trong thang {thang}/{nam} là: {soNgay}");
            Console.ReadKey();

        }

        static int BUOI1_2(int thang, int nam)
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return CheckNamNhuan(nam) ? 29 : 28;
                default:
                    return -1; 
            }
        }

        static bool CheckNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }
    }
}

       