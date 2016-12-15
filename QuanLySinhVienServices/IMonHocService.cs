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
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMonHocService" in both code and config file together.
        [ServiceContract]
        public interface IMonHocService
        {
            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Add(MonHocBDO monhoc);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Update(MonHocBDO monhoc);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            bool Delete(string mamh);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            MonHocBDO GetMonHoc(string mamh);

            [OperationContract]
            [FaultContract(typeof(Exception))]
            List<MonHocBDO> GetAllMonHoc();
        }
    }
}
