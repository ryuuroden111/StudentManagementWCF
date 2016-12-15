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
            public int Add(MonHocBDO MonHoc)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spEditMonHoc", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Insert);
                        command.Parameters.AddWithValue("@Mamh", MonHoc.MaMH);
                        command.Parameters.AddWithValue("@Tenmh", MonHoc.TenMH);
                        command.Parameters.AddWithValue("@sotiet", MonHoc.SoTiet);
                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }

            public int Update(MonHocBDO MonHoc)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spEditMonHoc", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Update);
                        command.Parameters.AddWithValue("@Mamh", MonHoc.MaMH);
                        command.Parameters.AddWithValue("@Tenmh", MonHoc.TenMH);
                        command.Parameters.AddWithValue("@sotiet", MonHoc.SoTiet);

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }

            public int Delete(string MaMonHoc)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spEditMonHoc", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Delete);
                        command.Parameters.AddWithValue("@Mamh", MaMonHoc);

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }

            public MonHocBDO GetMonHocByID(string MaMonHoc)
            {
                MonHocBDO MonHoc = new MonHocBDO();

                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spGetMonHoc", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Mamh", MaMonHoc);

                        connection.Open();
                        SqlDataAdapter MonHocAdapter = new SqlDataAdapter();
                        DataTable MonHocTable = new DataTable();
                        MonHocAdapter.SelectCommand = command;
                        MonHocAdapter.Fill(MonHocTable);
                        if (MonHocTable.Rows.Count > 0)
                        {
                            MonHoc.MaMH = (string)MonHocTable.Rows[0]["Mamh"];
                            MonHoc.TenMH = (string)MonHocTable.Rows[0]["Tenmh"];
                            MonHoc.SoTiet = (int)MonHocTable.Rows[0]["sotiet"];
                        }
                    }
                }

                return MonHoc;
            }

            public List<MonHocBDO> GetAllKhoa()
            {
                List<MonHocBDO> ListMonHoc = new List<MonHocBDO>();

                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spGetMonHoc", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataAdapter MonHocAdapter = new SqlDataAdapter();
                        DataTable MonHocTable = new DataTable();
                        MonHocAdapter.SelectCommand = command;
                        MonHocAdapter.Fill(MonHocTable);
                        if (MonHocTable.Rows.Count > 0)
                        {
                            for (int i = 0; i < MonHocTable.Rows.Count; i++)
                            {
                                MonHocBDO MonHoc = new MonHocBDO();
                                MonHoc.MaMH = (string)MonHocTable.Rows[i]["Mamh"];
                                MonHoc.TenMH = (string)MonHocTable.Rows[i]["Tenmh"];
                                MonHoc.SoTiet = (int)MonHocTable.Rows[i]["sotiet"];

                                ListMonHoc.Add(MonHoc);
                            }
                        }
                    }
                }
                return ListMonHoc;
            }
        }
    }
}
