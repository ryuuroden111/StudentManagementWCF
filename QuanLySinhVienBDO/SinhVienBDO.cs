using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienBDO
    {
        [DataContract]
        public class SinhVienBDO
        {
            [DataMember]
            public string MaSV { get; set; }
            [DataMember]
            public string HoSV { get; set; }
            [DataMember]
            public string TenSV { get; set; }
            [DataMember]
            public bool GioiTinh { get; set; }
            [DataMember]
            public DateTime NgaySinh { get; set; }
            [DataMember]
            public string NoiSinh { get; set; }
            [DataMember]
            public string MaKhoa { get; set; }
            [DataMember]
            public int HocBong { get; set; }
        }
    }
}
