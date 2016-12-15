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
        public class KhoaBUS
        {
            private KhoaDAL khoaDAL = new KhoaDAL();

            public bool Add(KhoaBDO khoa)
            {
                if (khoa != null)
                {
                    if (khoa.MaKhoa != null && khoa.MaKhoa != String.Empty)
                    {
                        khoaDAL.Add(khoa);
                        return true;
                    }
                }
                return false;
            }

            public bool Update(KhoaBDO khoa)
            {
                if (khoa != null)
                {
                    if (khoa.MaKhoa != null && khoa.MaKhoa != String.Empty)
                    {
                        khoaDAL.Update(khoa);
                        return true;
                    }
                }
                return false;
            }

            public bool Delete(string MaKhoa)
            {
                if (MaKhoa != null && MaKhoa != String.Empty)
                {
                    khoaDAL.Delete(MaKhoa);
                    return true;
                }
                return false;
            }

            public KhoaBDO GetByID(string MaKhoa)
            {
                if (MaKhoa == null)
                {
                    return null;
                }
                else if (MaKhoa == String.Empty)
                {
                    return new KhoaBDO()
                    {
                        MaKhoa = "n/a",
                        TenKhoa = "n/a"
                    };
                }
                else
                {
                    return khoaDAL.GetKhoaByID(MaKhoa);
                }
            }

            public List<KhoaBDO> GetAll()
            {
                return khoaDAL.GetAllKhoa();
            }
        }
    }
}
