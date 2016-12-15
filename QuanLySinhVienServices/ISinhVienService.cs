using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QuanLySinhVienWCF.QuanLySinhVienBDO;

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienServices
    {
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISinhVienService" in both code and config file together.
        [ServiceContract]
        public interface ISinhVienService
        {
            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Add(SinhVienBDO sv);
           
            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Update(SinhVienBDO sv);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Delete(string masv);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            SinhVienBDO GetSinhVien(string Ma);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            List<SinhVienBDO> GetAllSinhVien();
        }
    }
}
