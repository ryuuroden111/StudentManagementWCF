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
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKhoaService" in both code and config file together.
        [ServiceContract]
        public interface IKhoaService
        {
            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Add(KhoaBDO khoa);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Update(KhoaBDO khoa);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Delete(string makhoa);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            KhoaBDO GetKhoa(string makhoa);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            List<KhoaBDO> GetAllKhoa();
        }
    }
}
