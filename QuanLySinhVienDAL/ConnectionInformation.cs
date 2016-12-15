using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienDAL
    {
        public static class ConnectionInformation
        {
            //public static string ConnectionString = "server=DESKTOP-AD954QP;Integrated Security=SSPI; database=QuanlysinhvienWCF";
            public static string ConnectionString = ConfigurationManager.ConnectionStrings["QuanLySinhVien"].ConnectionString;
            public static string Insert = "Insert";
            public static string Update = "Update";
            public static string Delete = "Delete";
        }
    }
}
