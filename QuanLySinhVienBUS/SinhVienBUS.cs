using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVienWCF.QuanLySinhVienBDO;
using QuanLySinhVienWCF.QuanLySinhVienDAL;

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienBUS
    {
        public class SinhVienBUS
        {
            private SinhVienDAL sinhvienDAL = new SinhVienDAL();

            public bool Add(SinhVienBDO sv)
            {
                if (sv != null)
                {
                    if (sv.MaSV != null && sv.MaKhoa != null)
                    {
                        sinhvienDAL.Add(sv);
                        return true;
                    }
                }
                return false;
            }

            public bool Update(SinhVienBDO sv)
            {
                if (sv != null)
                {
                    if (sv.MaSV != null && sv.MaKhoa != null)
                    {
                        sinhvienDAL.Update(sv);
                        return true;
                    }
                }
                return false;
            }

            public bool Delete(string MaSV)
            {
                if (MaSV != null && MaSV != String.Empty)
                {
                    SinhVienBDO sv = new SinhVienBDO();
                    sv.MaSV = MaSV;
                    sv.HoSV = "";
                    sv.TenSV = "";
                    sv.GioiTinh = true; //demo nen de dai gia tri
                    sv.NgaySinh = DateTime.Now; //demo nen cho dai gia tri
                    sv.NoiSinh = "";
                    sv.MaKhoa = ""; //Theo khoa ngoai thi  cho nay khong null nhung ma day la demo nen khong check ki~.
                    sv.HocBong = 1; //demo nen cho dai gia tri.

                    sinhvienDAL.Delete(sv);
                    return true;
                }
                return false;
            }

            public SinhVienBDO GetSinhVienByID(string MaSV)
            {
                if (MaSV != null)
                {
                    return sinhvienDAL.GetSinhVienByID(MaSV);
                }
                return null;
            }

            public List<SinhVienBDO> GetAll()
            {
                return sinhvienDAL.GetAllSinhVien();
            }
        }
    }
}
