using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLySinhVienWCF.QuanLySinhVienBDO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienDAL
    {
        public class KhoaDAL
        {
            QLSVEntities db = new QLSVEntities();
            public int Add(KhoaBDO khoa)
            {
                return db.spEditKhoa(ConnectionInformation.Insert, khoa.MaKhoa, khoa.TenKhoa);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditKhoa", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Insert);
                //        command.Parameters.AddWithValue("@Makhoa", khoa.MaKhoa);
                //        command.Parameters.AddWithValue("@Tenkhoa", khoa.TenKhoa);                       
                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public int Update(KhoaBDO khoa)
            {
                return db.spEditKhoa(ConnectionInformation.Update, khoa.MaKhoa, khoa.TenKhoa);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditKhoa", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Update);
                //        command.Parameters.AddWithValue("@Makhoa", khoa.MaKhoa);
                //        command.Parameters.AddWithValue("@Tenkhoa", khoa.TenKhoa);

                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public int Delete(string MaKhoa)
            {
                return db.spEditKhoa(ConnectionInformation.Delete, MaKhoa, null);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditKhoa", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Delete);
                //        command.Parameters.AddWithValue("@Makhoa", MaKhoa);

                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public KhoaBDO GetKhoaByID(string MaKhoa)
            {
                KhoaBDO Khoa = new KhoaBDO();
                var k = db.spGetKhoa(MaKhoa, "");
                foreach (spGetKhoa_Result kq in k)
                {
                    Khoa.MaKhoa = kq.Makhoa;
                    Khoa.TenKhoa = kq.Tenkhoa;
                }

                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spGetKhoa", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@Makhoa", MaKhoa);
                //        connection.Open();
                //        SqlDataAdapter KhoaAdapter = new SqlDataAdapter();
                //        DataTable KhoaTable = new DataTable();
                //        KhoaAdapter.SelectCommand = command;
                //        KhoaAdapter.Fill(KhoaTable);
                //        if (KhoaTable.Rows.Count > 0)
                //        {
                //            Khoa.MaKhoa = (string)KhoaTable.Rows[0]["Makhoa"];
                //            Khoa.TenKhoa = (string)KhoaTable.Rows[0]["Tenkhoa"];
                //        }
                //    }
                //}

                return Khoa;
            }

            public List<KhoaBDO> GetAllKhoa()
            {
                List<KhoaBDO> ListKhoa = new List<KhoaBDO>();
                var k = db.spGetKhoa("", "");
                foreach (spGetKhoa_Result kq in k)
                {
                    KhoaBDO khoa = new KhoaBDO();
                    khoa.MaKhoa = kq.Makhoa;
                    khoa.TenKhoa = kq.Tenkhoa;
                    ListKhoa.Add(khoa);
                }

                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spGetKhoa", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        connection.Open();
                //        SqlDataAdapter KhoaAdapter = new SqlDataAdapter();
                //        DataTable KhoaTable = new DataTable();
                //        KhoaAdapter.SelectCommand = command;
                //        KhoaAdapter.Fill(KhoaTable);
                //        if (KhoaTable.Rows.Count > 0)
                //        {
                //            for (int i = 0; i < KhoaTable.Rows.Count; i++)
                //            {
                //                KhoaBDO Khoa = new KhoaBDO();
                //                Khoa.MaKhoa = (string)KhoaTable.Rows[i]["Makhoa"];
                //                Khoa.TenKhoa = (string)KhoaTable.Rows[i]["Tenkhoa"];

                //                ListKhoa.Add(Khoa);
                //            }
                //        }
                //    }
                //}
                return ListKhoa;
            }
        }
    }
}
