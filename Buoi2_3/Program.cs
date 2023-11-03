using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            //Nhap Xuat SV và GV
            List<Student> danhSachSinhVien = NhapDanhSachSinhVien();
            List<Teacher> danhSachGiaoVien = NhapDanhSachGiaoVien();
            // In danh sách sinh viên
            Console.WriteLine("Danh sách sinh viên:");
            foreach (var sv in danhSachSinhVien)
            {
                sv.Xuat();
            }
            // In danh sách giáo viên
            Console.WriteLine("Danh sách giáo viên:");
            foreach (var gv in danhSachGiaoVien)
            {
                gv.Xuat();
            }

            //Tìm kiếm SV theo Khoa
            Console.WriteLine("Danh sách sinh viên thuộc khoa CNTT:");
            List<Student> sinhVienCNTT = TimSinhVienTheoKhoa(danhSachSinhVien, "CNTT");

            if (sinhVienCNTT.Count > 0)
            {
                foreach (var sv in sinhVienCNTT)
                {
                    sv.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên thuộc khoa CNTT.");
            }

            // Xuat Sinh Vien Co Diem Duoi 5 Va Khoa CNTT
            Console.WriteLine("Danh sách sinh viên có điểm trung bình < 5 và thuộc khoa CNTT:");
            XuatSinhVienCoDiemDuoi5VaKhoaCNTT(danhSachSinhVien);

            //4.	Xuất ra danh sách giáo viên có địa chỉ chứa thông tin "Quận 9" nếu có
            Console.WriteLine("Danh sách giáo viên có địa chỉ chứa thông tin 'Quận 9':");
            XuatGiaoVienCoDiaChiQuan9(danhSachGiaoVien);

            //5.	Tìm kiếm giáo viên có mã giảng viên là CHN060286. Xuất ra thông tin giáo viên tìm được nếu có.
            string maGiangVienCanTim = "CHN060286";
            Console.WriteLine($"Thông tin giáo viên có mã giảng viên '{maGiangVienCanTim}':");
            TimVaXuatGiaoVienTheoMa(danhSachGiaoVien, maGiangVienCanTim);

            //6.	Tìm danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"
            Console.WriteLine("Danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa CNTT:");
            TimVaXuatSinhVienCoDiemCaoNhatVaKhoaCNTT(danhSachSinhVien);

            Console.ReadKey();
        }

        // Hàm nhập danh sách sinh viên
        public static List<Student> NhapDanhSachSinhVien()
        {
            List<Student> danhSachSinhVien = new List<Student>();
            int soLuongSV;


            Console.Write("Nhập số lượng sinh viên: ");
            while (!int.TryParse(Console.ReadLine(), out soLuongSV) || soLuongSV <= 0)
            {
                Console.Write("Nhập số lượng hợp lệ (số nguyên dương): ");
            }

            for (int i = 0; i < soLuongSV; i++)
            {
                Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
                Student sinhVien = new Student();
                sinhVien.Nhap();
                danhSachSinhVien.Add(sinhVien);
            }

            return danhSachSinhVien;
        }

        // Hàm nhập danh sách giáo viên
        public static List<Teacher> NhapDanhSachGiaoVien()
        {
            List<Teacher> danhSachGiaoVien = new List<Teacher>();
            int soLuongGV;

            Console.Write("Nhập số lượng giáo viên: ");
            while (!int.TryParse(Console.ReadLine(), out soLuongGV) || soLuongGV <= 0)
            {
                Console.Write("Nhập số lượng hợp lệ (số nguyên dương): ");
            }

            for (int i = 0; i < soLuongGV; i++)
            {
                Console.WriteLine($"Nhập thông tin cho giáo viên thứ {i + 1}:");
                Teacher giaoVien = new Teacher();
                giaoVien.Nhap();
                danhSachGiaoVien.Add(giaoVien);
            }

            return danhSachGiaoVien;
        }

        // Hàm tìm sinh viên theo khoa
        static List<Student> TimSinhVienTheoKhoa(List<Student> danhSachSinhVien, string khoa)
        {
            return danhSachSinhVien.Where(sv => sv.Khoa == khoa).ToList();
        }

        //Xuat Sinh Vien Co Diem Duoi 5 Va Khoa CNTT
        static void XuatSinhVienCoDiemDuoi5VaKhoaCNTT(List<Student> danhSach)
        {
            var sinhVienCanXuat = danhSach.Where(sv => sv.Khoa == "CNTT" && sv.DiemTB < 5);

            if (sinhVienCanXuat.Any())
            {
                foreach (var sv in sinhVienCanXuat)
                {
                    sv.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên nào thỏa điều kiện.");
            }
        }

        // Hàm xuất danh sách giáo viên có địa chỉ chứa thông tin "Quận 9"
        static void XuatGiaoVienCoDiaChiQuan9(List<Teacher> danhSach)
        {
            var giaoVienCanXuat = danhSach.Where(gv => gv.DiaChi.Contains("Quận 9"));

            if (giaoVienCanXuat.Any())
            {
                foreach (var gv in giaoVienCanXuat)
                {
                    gv.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy giáo viên nào có địa chỉ chứa thông tin 'Quận 9'.");
            }
        }

        // Hàm tìm và xuất giáo viên theo mã giảng viên
        static void TimVaXuatGiaoVienTheoMa(List<Teacher> danhSach, string maGiangVien)
        {
            var giaoVienCanXuat = danhSach.FirstOrDefault(gv => gv.MaGV == maGiangVien);

            if (giaoVienCanXuat != null)
            {
                giaoVienCanXuat.Xuat();
            }
            else
            {
                Console.WriteLine($"Không tìm thấy giáo viên có mã giảng viên '{maGiangVien}'.");
            }
        }

        // Hàm tìm và xuất danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa CNTT
        static void TimVaXuatSinhVienCoDiemCaoNhatVaKhoaCNTT(List<Student> danhSach)
        {
            var sinhVienCNTT = danhSach.Where(sv => sv.Khoa == "CNTT");

            if (sinhVienCNTT.Any())
            {
                double diemCaoNhat = sinhVienCNTT.Max(sv => sv.DiemTB);

                var sinhVienCaoNhat = sinhVienCNTT.Where(sv => sv.DiemTB == diemCaoNhat);

                foreach (var sv in sinhVienCaoNhat)
                {
                    sv.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên nào thuộc khoa CNTT.");
            }
        }
    }
}
