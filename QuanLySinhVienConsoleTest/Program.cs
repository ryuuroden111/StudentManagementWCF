using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using QuanLySinhVienConsoleTest.SinhVienServiceRef;

namespace QuanLySinhVienConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVienServiceClient client = new SinhVienServiceClient();
            SinhVienBDO SinhVien = client.GetSinhVien("A01");
            List<SinhVienBDO> ListSinhVien = client.GetAllSinhVien().ToList();

            Console.WriteLine("\n---Test GetSinhVienByID(A01)---\n");
            Console.WriteLine(SinhVien.MaSV + " " + SinhVien.HoSV + " " + SinhVien.TenSV + " " + SinhVien.MaKhoa + " " + SinhVien.GioiTinh + " " + SinhVien.NgaySinh + " " + SinhVien.NoiSinh + " " + SinhVien.HocBong + "\n");
            Console.WriteLine("\n\n---Test GetAllSinhVien()---\n");
            for (int i = 0; i < ListSinhVien.Capacity; i++)
            {
                Console.WriteLine(ListSinhVien[i].MaSV + " " + ListSinhVien[i].HoSV + " " + ListSinhVien[i].TenSV + " " + ListSinhVien[i].MaKhoa + " " + ListSinhVien[i].GioiTinh + " " + ListSinhVien[i].NgaySinh + " " + ListSinhVien[i].NoiSinh + " " + ListSinhVien[i].HocBong + "\n");
            }
            Console.ReadLine();

        }
    }
}
