using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienBDO
    {
        [DataContract]
        public class MonHocBDO
        {
            [DataMember]
            public string MaMH { get; set; }
            [DataMember]
            public string TenMH { get; set; }
            [DataMember]
            public int SoTiet { get; set; }
        }
    }
}
