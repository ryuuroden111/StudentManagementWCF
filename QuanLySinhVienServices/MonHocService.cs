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
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MonHocService" in both code and config file together.
        public class MonHocService : IMonHocService
        {
            private MonHocBUS monhocBUS = new MonHocBUS();
            public bool Add(MonHocBDO monhoc)
            {
                try
                {
                    monhocBUS.Add(monhoc);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Delete(string mamh)
            {
                try
                {
                    monhocBUS.Delete(mamh);
                    return true;
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public List<MonHocBDO> GetAllMonHoc()
            {
                try
                {
                    return monhocBUS.GetAll();
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public MonHocBDO GetMonHoc(string mamh)
            {
                try
                {
                    return monhocBUS.GetMonHocByID(mamh);
                }
                catch (FaultException)
                {
                    throw;
                }
            }

            public bool Update(MonHocBDO monhoc)
            {
                try
                {
                    monhocBUS.Update(monhoc);
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
