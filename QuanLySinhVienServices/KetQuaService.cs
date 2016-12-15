using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QuanLySinhVienWCF.QuanLySinhVienBDO;
using QuanLySinhVienWCF.QuanLySinhVienBUS;

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienServices
    {
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KetQuaService" in both code and config file together.
        public class KetQuaService : IKetQuaService
        {
            private KetQuaBUS ketquaBUS = new KetQuaBUS();
            public bool Add(KetQuaBDO ketqua)
            {
                try
                {
                    ketquaBUS.Add(ketqua);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Delete(string masv, string mamh)
            {
                try
                {
                    ketquaBUS.Delete(masv, mamh);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public List<KetQuaBDO> GetAllKetQua()
            {
                try
                {
                    return ketquaBUS.GetAll();
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public KetQuaBDO GetKetQua(string masv, string mamh)
            {
                try
                {
                    return ketquaBUS.GetKetQuaByID(masv, mamh);
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Update(KetQuaBDO ketqua)
            {
                try
                {
                    ketquaBUS.Update(ketqua);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }
        }
    }
}
