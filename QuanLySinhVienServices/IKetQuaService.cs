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
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKetQuaService" in both code and config file together.
        [ServiceContract]
        public interface IKetQuaService
        {
            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Add(KetQuaBDO khoa);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Update(KetQuaBDO khoa);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Delete(string masv, string mamh);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            KetQuaBDO GetKetQua(string masv, string mamh);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            List<KetQuaBDO> GetAllKetQua();
        }
    }
}
