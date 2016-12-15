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
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KhoaService" in both code and config file together.
        public class KhoaService : IKhoaService
        {
            private KhoaBUS khoaBUS = new KhoaBUS();
            public bool Add(KhoaBDO khoa)
            {
                try
                {
                    khoaBUS.Add(khoa);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Delete(string makhoa)
            {
                try
                {
                    khoaBUS.Delete(makhoa);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public List<KhoaBDO> GetAllKhoa()
            {
                try
                {
                    return khoaBUS.GetAll();
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public KhoaBDO GetKhoa(string makhoa)
            {
                try
                {
                    return khoaBUS.GetByID(makhoa);
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Update(KhoaBDO khoa)
            {
                try
                {
                    khoaBUS.Update(khoa);
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
