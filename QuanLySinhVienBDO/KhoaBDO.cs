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
        public class KhoaBDO
        {
            [DataMember]
            public string MaKhoa { get; set; }
            [DataMember]
            public string TenKhoa { get; set; }
        }
    }
}
