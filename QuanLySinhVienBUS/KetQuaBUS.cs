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
        public class KetQuaBUS
        {
            private KetQuaDAL ketquaDAL = new KetQuaDAL();

            public bool Add(KetQuaBDO kq)
            {
                if (kq != null)
                {
                    if (kq.MaSV != null && kq.MaSV != string.Empty && kq.MaMH != null && kq.MaMH != string.Empty)
                    {
                        ketquaDAL.Add(kq);
                        return true;
                    }
                }
                return false;
            }

            public bool Update(KetQuaBDO kq)
            {
                if (kq != null)
                {
                    if (kq.MaSV != null && kq.MaSV != string.Empty && kq.MaMH != null && kq.MaMH != string.Empty)
                    {
                        ketquaDAL.Update(kq);
                        return true;
                    }
                }
                return false;
            }

            public bool Delete(string MaSV,string MaMH)
            {
                if (MaSV != null && MaSV != string.Empty && MaMH != null && MaMH != string.Empty)
                {
                    ketquaDAL.Delete(MaSV, MaMH);
                    return true;
                }
                return false;
            }

            public KetQuaBDO GetKetQuaByID(string MaSV, string MaMH)
            {
                if (MaSV != null && MaSV != string.Empty && MaMH != null && MaMH != string.Empty)
                {
                    List<KetQuaBDO>.Enumerator KetQuaByMaMH = ketquaDAL.GetKetQuaByMaMH(MaMH).GetEnumerator();
                    while (KetQuaByMaMH.MoveNext())
                    {
                        if (KetQuaByMaMH.Current.MaSV == MaSV)
                        {
                            return KetQuaByMaMH.Current;
                        }
                    }
                }
                return null;
            }

            public List<KetQuaBDO> GetAll()
            {
                return ketquaDAL.GetAllKetQua();
            }
        }
    }
}