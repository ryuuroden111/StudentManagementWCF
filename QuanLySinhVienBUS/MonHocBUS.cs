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
        public class MonHocBUS
        {
            private MonHocDAL MonHocDAL = new MonHocDAL();

            public bool Add(MonHocBDO MonHoc)
            {
                if (MonHoc != null)
                {
                    if (MonHoc.MaMH != null && MonHoc.MaMH != string.Empty)
                    {
                        MonHocDAL.Add(MonHoc);
                        return true;
                    }
                }
                return false;
            }

            public bool Update(MonHocBDO MonHoc)
            {
                if (MonHoc != null)
                {
                    if (MonHoc.MaMH != null && MonHoc.MaMH != string.Empty)
                    {
                        MonHocDAL.Update(MonHoc);
                        return true;
                    }
                }
                return false;
            }

            public bool Delete(string MaMH)
            {
                if (MaMH != null && MaMH != String.Empty)
                {
                    MonHocDAL.Delete(MaMH);
                    return true;
                }
                return false;
            }

            public MonHocBDO GetMonHocByID(string MaMH)
            {
                if (MaMH != null)
                {
                    return MonHocDAL.GetMonHocByID(MaMH);
                }
                return null;
            }

            public List<MonHocBDO> GetAll()
            {
                return MonHocDAL.GetAllKhoa();
            }
        }
    }
}
