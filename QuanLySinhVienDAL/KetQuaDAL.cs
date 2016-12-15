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
        public class KetQuaDAL
        {
            public int Add(KetQuaBDO KetQua)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spEditKetQua", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Insert);
                        command.Parameters.AddWithValue("@masv", KetQua.MaSV);
                        command.Parameters.AddWithValue("@Mamh", KetQua.MaMH);
                        command.Parameters.AddWithValue("@Diem", KetQua.Diem);
                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }

            public int Update(KetQuaBDO KetQua)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spEditKetQua", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Update);
                        command.Parameters.AddWithValue("@masv", KetQua.MaSV);
                        command.Parameters.AddWithValue("@Mamh", KetQua.MaMH);
                        command.Parameters.AddWithValue("@Diem", KetQua.Diem);

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }

            public int Delete(string MaSV, string MaMH)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spEditKetQua", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Delete);
                        command.Parameters.AddWithValue("@masv", MaSV);
                        command.Parameters.AddWithValue("@Mamh", MaMH);

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }

            public List<KetQuaBDO> GetKetQuaByMaSV(string MaSV)
            {
                List<KetQuaBDO> ListKetQua = new List<KetQuaBDO>();

                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spGetKetQua", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Masv", MaSV);

                        connection.Open();
                        SqlDataAdapter KetQuaAdapter = new SqlDataAdapter();
                        DataTable KetQuaTable = new DataTable();
                        KetQuaAdapter.SelectCommand = command;
                        KetQuaAdapter.Fill(KetQuaTable);
                        if (KetQuaTable.Rows.Count > 0)
                        {
                            for (int i = 0; i < KetQuaTable.Rows.Count; i++)
                            {
                                KetQuaBDO KetQua = new KetQuaBDO();
                                KetQua.MaSV = (string)KetQuaTable.Rows[i]["masv"];
                                KetQua.MaMH = (string)KetQuaTable.Rows[i]["Mamh"];
                                KetQua.Diem = (int)KetQuaTable.Rows[i]["Diem"];

                                ListKetQua.Add(KetQua);
                            }
                        }
                    }
                }

                return ListKetQua;
            }

            public List<KetQuaBDO> GetKetQuaByMaMH(string MaMH)
            {
                List<KetQuaBDO> ListKetQua = new List<KetQuaBDO>();

                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spGetKetQua", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Mamh", MaMH);

                        connection.Open();
                        SqlDataAdapter KetQuaAdapter = new SqlDataAdapter();
                        DataTable KetQuaTable = new DataTable();
                        KetQuaAdapter.SelectCommand = command;
                        KetQuaAdapter.Fill(KetQuaTable);
                        if (KetQuaTable.Rows.Count > 0)
                        {
                            for (int i = 0; i < KetQuaTable.Rows.Count; i++)
                            {
                                KetQuaBDO KetQua = new KetQuaBDO();
                                KetQua.MaSV = (string)KetQuaTable.Rows[i]["masv"];
                                KetQua.MaMH = (string)KetQuaTable.Rows[i]["Mamh"];
                                KetQua.Diem = (float)KetQuaTable.Rows[i]["Diem"];

                                ListKetQua.Add(KetQua);
                            }
                        }
                    }
                }

                return ListKetQua;
            }

            public List<KetQuaBDO> GetAllKetQua()
            {
                List<KetQuaBDO> ListKetQua = new List<KetQuaBDO>();

                using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spGetKetQua", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataAdapter KetQuaAdapter = new SqlDataAdapter();
                        DataTable KetQuaTable = new DataTable();
                        KetQuaAdapter.SelectCommand = command;
                        KetQuaAdapter.Fill(KetQuaTable);
                        if (KetQuaTable.Rows.Count > 0)
                        {
                            for (int i = 0; i < KetQuaTable.Rows.Count; i++)
                            {
                                KetQuaBDO KetQua = new KetQuaBDO();
                                KetQua.MaSV = (string)KetQuaTable.Rows[i]["masv"];
                                KetQua.MaMH = (string)KetQuaTable.Rows[i]["Mamh"];
                                KetQua.Diem = (float)KetQuaTable.Rows[i]["Diem"];

                                ListKetQua.Add(KetQua);
                            }
                        }
                    }
                }
                return ListKetQua;
            }
        }
    }
}
