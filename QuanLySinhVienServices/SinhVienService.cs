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
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SinhVienService" in both code and config file together.
        public class SinhVienService : ISinhVienService
        {
            private SinhVienBUS sinhvienBUS = new SinhVienBUS();
            public bool Add(SinhVienBDO sv)
            {
                try
                {
                    sinhvienBUS.Add(sv);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Delete(string masv)
            {
                try
                {
                    sinhvienBUS.Delete(masv);
                    return true;
                }
                catch(FaultException)
                {
                    throw;
                }
            }

            public List<SinhVienBDO> GetAllSinhVien()
            {
                try
                {
                    return sinhvienBUS.GetAll();
                }
                catch(FaultException)
                {
                    throw;
                }
            }

            public SinhVienBDO GetSinhVien(string Ma)
            {
                try
                {
                    return sinhvienBUS.GetSinhVienByID(Ma);
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Update(SinhVienBDO sv)
            {
                try
                {
                    sinhvienBUS.Update(sv);
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
