using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<SinhVien> listSinhVien = NhapDSSV();
            XuatDSSV(listSinhVien);

            //1.1
            Console.WriteLine("SinhVien CNTT");
            DSSVCNTT(listSinhVien);
            //1.2
            Console.WriteLine("SinhVien DiemTB>=5");
            DSSVCNTTDiemTB5(listSinhVien);
            //1.3
            Console.WriteLine("SinhVien SapXep");
            DSSVSapXep(listSinhVien);
            //1.4
            Console.WriteLine("SinhVien CNTT va DiemTB>=5");
            DSSVCNTTDiemTB5(listSinhVien);
            //1.5
            Console.WriteLine("SinhVien DiemTB LonNhat");
            DiemCaoNhat(listSinhVien);


            Console.ReadKey();
        }

        private static List<SinhVien> NhapDSSV()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.Write("Nhap tong so sinh vien N = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("===== Nhap danh sach sinh vien ===== ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }

        private static void XuatDSSV(List<SinhVien> listSV)
        {
            Console.WriteLine("===== Xuat danh sach sinh vien ===== ");
            foreach (SinhVien sinhVien in listSV)
            {
                sinhVien.XuatSV();
            }
        }

        //Danh sach sinh vien CNTT
        private static void DSSVCNTT(List<SinhVien> listSV)
        {
            List<SinhVien> ds = listSV.Where(sv => sv.Khoa == "CNTT").ToList();
            if(ds.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien khoa CNTT.");
            }
            else
            {
                XuatDSSV(ds);
            }
        }

        //Danh sach sinh vien diem trung binh lon hon hoac bang 5
        private static void DSSVDiemTB5(List<SinhVien> listSV)
        {
            List<SinhVien> ds = listSV.Where(sv => sv.DiemTB >= 5).ToList();
            if (ds.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien co DienTB >= 5.");
            }
            else
            {
                XuatDSSV(ds);
            }
        }

        //Sap xep danh sach sinh vien
        private static void DSSVSapXep(List<SinhVien> listSV)
        {
            List<SinhVien> ds = listSV.OrderBy(sv => sv.DiemTB).ToList();
            XuatDSSV(ds);
        }

        //danh sach sinh vien cntt co diem trung binh lon hon hoac bang 5
        private static void DSSVCNTTDiemTB5(List<SinhVien> listSV)
        {
            List<SinhVien> ds = listSV.Where(sv => sv.Khoa == "CNTT" && sv.DiemTB >= 5).ToList();
            if (ds.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien khoa CNTT.");
            }
            else
            {
                XuatDSSV(ds);
            }
        }

        //danh sach sinh vien CNTT co diem trung binh cao nhat
        private static void DiemCaoNhat(List<SinhVien> listSV)
        {
            SinhVien svbest = listSV.OrderByDescending(sv => sv.DiemTB).FirstOrDefault();
            svbest.XuatSV();
        }
    }
}
