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
        public class KetQuaBDO
        {
            [DataMember]
            public string MaSV { get; set; }
            [DataMember]
            public string MaMH { get; set; }
            [DataMember]
            public float Diem { get; set; }
        }
    }
}
