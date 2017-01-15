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
        public class MonHocDAL
        {
            QLSVEntities db = new QLSVEntities();
            public int Add(MonHocBDO MonHoc)
            {
                return db.spEditMonHoc(ConnectionInformation.Insert, MonHoc.MaMH, MonHoc.TenMH, MonHoc.SoTiet);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditMonHoc", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Insert);
                //        command.Parameters.AddWithValue("@Mamh", MonHoc.MaMH);
                //        command.Parameters.AddWithValue("@Tenmh", MonHoc.TenMH);
                //        command.Parameters.AddWithValue("@sotiet", MonHoc.SoTiet);
                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public int Update(MonHocBDO MonHoc)
            {
                return db.spEditMonHoc(ConnectionInformation.Update, MonHoc.MaMH, MonHoc.TenMH, MonHoc.SoTiet);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditMonHoc", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Update);
                //        command.Parameters.AddWithValue("@Mamh", MonHoc.MaMH);
                //        command.Parameters.AddWithValue("@Tenmh", MonHoc.TenMH);
                //        command.Parameters.AddWithValue("@sotiet", MonHoc.SoTiet);

                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public int Delete(string MaMonHoc)
            {
                return db.spEditMonHoc(ConnectionInformation.Delete, MaMonHoc, null, null);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditMonHoc", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Delete);
                //        command.Parameters.AddWithValue("@Mamh", MaMonHoc);

                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public MonHocBDO GetMonHocByID(string MaMonHoc)
            {
                MonHocBDO MonHoc = new MonHocBDO();
                var k = db.spGetMonHoc(MaMonHoc, "");
                foreach (spGetMonHoc_Result kq in k)
                {
                    MonHoc.MaMH = kq.Mamh;
                    MonHoc.TenMH = kq.Tenmh;
                    MonHoc.SoTiet = kq.sotiet.Value;
                }


                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spGetMonHoc", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@Mamh", MaMonHoc);

                //        connection.Open();
                //        SqlDataAdapter MonHocAdapter = new SqlDataAdapter();
                //        DataTable MonHocTable = new DataTable();
                //        MonHocAdapter.SelectCommand = command;
                //        MonHocAdapter.Fill(MonHocTable);
                //        if (MonHocTable.Rows.Count > 0)
                //        {
                //            MonHoc.MaMH = (string)MonHocTable.Rows[0]["Mamh"];
                //            MonHoc.TenMH = (string)MonHocTable.Rows[0]["Tenmh"];
                //            MonHoc.SoTiet = (int)MonHocTable.Rows[0]["sotiet"];
                //        }
                //    }
                //}

                return MonHoc;
            }

            public List<MonHocBDO> GetAllKhoa()
            {
                List<MonHocBDO> ListMonHoc = new List<MonHocBDO>();
                var k = db.spGetMonHoc("", "");
                foreach (spGetMonHoc_Result kq in k)
                {
                    MonHocBDO mh = new MonHocBDO();
                    mh.MaMH = kq.Mamh;
                    mh.TenMH = kq.Tenmh;
                    mh.SoTiet = kq.sotiet.Value;
                    ListMonHoc.Add(mh);
                }

                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spGetMonHoc", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        connection.Open();
                //        SqlDataAdapter MonHocAdapter = new SqlDataAdapter();
                //        DataTable MonHocTable = new DataTable();
                //        MonHocAdapter.SelectCommand = command;
                //        MonHocAdapter.Fill(MonHocTable);
                //        if (MonHocTable.Rows.Count > 0)
                //        {
                //            for (int i = 0; i < MonHocTable.Rows.Count; i++)
                //            {
                //                MonHocBDO MonHoc = new MonHocBDO();
                //                MonHoc.MaMH = (string)MonHocTable.Rows[i]["Mamh"];
                //                MonHoc.TenMH = (string)MonHocTable.Rows[i]["Tenmh"];
                //                MonHoc.SoTiet = (int)MonHocTable.Rows[i]["sotiet"];

                //                ListMonHoc.Add(MonHoc);
                //            }
                //        }
                //    }
                //}
                return ListMonHoc;
            }
        }
    }
}
