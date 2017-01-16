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
        public class SinhVienDAL
        {
            QLSVEntities db = new QLSVEntities();
            public int Add(SinhVienBDO sv)
            {
                return db.spEditSinhVien(ConnectionInformation.Insert, sv.MaSV, sv.HoSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh, sv.NoiSinh, sv.MaKhoa, sv.HocBong);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditSinhVien", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Insert);
                //        command.Parameters.AddWithValue("@Masv", sv.MaSV);
                //        command.Parameters.AddWithValue("@Hosv", sv.HoSV);
                //        command.Parameters.AddWithValue("@tensv", sv.TenSV);
                //        command.Parameters.AddWithValue("@phai", sv.GioiTinh);
                //        command.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
                //        command.Parameters.AddWithValue("@noisinh", sv.NoiSinh);
                //        command.Parameters.AddWithValue("@MaKhoa", sv.MaKhoa);
                //        command.Parameters.AddWithValue("@Hocbong", sv.HocBong);

                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public int Update(SinhVienBDO sv)
            {
                return db.spEditSinhVien(ConnectionInformation.Update, sv.MaSV, sv.HoSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh, sv.NoiSinh, sv.MaKhoa, sv.HocBong);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditSinhVien", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Update);
                //        command.Parameters.AddWithValue("@Masv", sv.MaSV);
                //        command.Parameters.AddWithValue("@Hosv", sv.HoSV);
                //        command.Parameters.AddWithValue("@tensv", sv.TenSV);
                //        command.Parameters.AddWithValue("@phai", sv.GioiTinh);
                //        command.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
                //        command.Parameters.AddWithValue("@noisinh", sv.NoiSinh);
                //        command.Parameters.AddWithValue("@MaKhoa", sv.MaKhoa);
                //        command.Parameters.AddWithValue("@Hocbong", sv.HocBong);

                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public int Delete(SinhVienBDO sv)
            {
                return db.spEditSinhVien(ConnectionInformation.Delete, sv.MaSV, sv.HoSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh, sv.NoiSinh, sv.MaKhoa, sv.HocBong);
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spEditSinhVien", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@StatementType", ConnectionInformation.Delete);
                //        command.Parameters.AddWithValue("@Masv", sv.MaSV);
                //        command.Parameters.AddWithValue("@Hosv", sv.HoSV);
                //        command.Parameters.AddWithValue("@tensv", sv.TenSV);
                //        command.Parameters.AddWithValue("@phai", sv.GioiTinh);
                //        command.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
                //        command.Parameters.AddWithValue("@noisinh", sv.NoiSinh);
                //        command.Parameters.AddWithValue("@MaKhoa", sv.MaKhoa);
                //        command.Parameters.AddWithValue("@Hocbong", sv.HocBong);

                //        connection.Open();
                //        return command.ExecuteNonQuery();
                //    }
                //}
            }

            public SinhVienBDO GetSinhVienByID(string id)
            {
                SinhVienBDO SinhVien = new SinhVienBDO();
                var k = db.spGetSinhVien(id, "");
                foreach (spGetSinhVien_Result kq in k)
                {
                    SinhVien.MaSV = kq.Masv;
                    SinhVien.HoSV = kq.Hosv;
                    SinhVien.TenSV = kq.tensv;
                    SinhVien.GioiTinh = kq.phai.Value;
                    SinhVien.NgaySinh = kq.ngaysinh.Value;
                    SinhVien.NoiSinh = kq.noisinh;
                    SinhVien.MaKhoa = kq.Makhoa;
                    SinhVien.HocBong = kq.Hocbong.Value;
                }
                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spGetSinhVien", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        command.Parameters.AddWithValue("@Masv", id);
                //        connection.Open();
                //        SqlDataAdapter SinhVienAdapter = new SqlDataAdapter();
                //        DataTable SinhVienTable = new DataTable();
                //        SinhVienAdapter.SelectCommand = command;
                //        SinhVienAdapter.Fill(SinhVienTable);
                //        if (SinhVienTable.Rows.Count > 0)
                //        {
                //            SinhVien.MaSV = (string)SinhVienTable.Rows[0]["Masv"];
                //            SinhVien.HoSV = (string)SinhVienTable.Rows[0]["Hosv"];
                //            SinhVien.TenSV = (string)SinhVienTable.Rows[0]["tensv"];
                //            SinhVien.GioiTinh = (bool)SinhVienTable.Rows[0]["phai"];
                //            SinhVien.NgaySinh = (DateTime)SinhVienTable.Rows[0]["ngaysinh"];
                //            SinhVien.NoiSinh = (string)SinhVienTable.Rows[0]["noisinh"];
                //            SinhVien.MaKhoa = (string)SinhVienTable.Rows[0]["Makhoa"];
                //            SinhVien.HocBong = (int)SinhVienTable.Rows[0]["Hocbong"];
                //        }
                //    }
                //}

                return SinhVien;
            }

            public List<SinhVienBDO> GetAllSinhVien()
            {
                List<SinhVienBDO> ListSinhVien = new List<SinhVienBDO>();
                var k = db.spGetSinhVien("", "");
                foreach (spGetSinhVien_Result kq in k)
                {
                    SinhVienBDO SinhVien = new SinhVienBDO();
                    SinhVien.MaSV = kq.Masv;
                    SinhVien.HoSV = kq.Hosv;
                    SinhVien.TenSV = kq.tensv;
                    SinhVien.GioiTinh = kq.phai.Value;
                    SinhVien.NgaySinh = kq.ngaysinh.Value;
                    SinhVien.NoiSinh = kq.noisinh;
                    SinhVien.MaKhoa = kq.Makhoa;
                    SinhVien.HocBong = kq.Hocbong.Value;

                    ListSinhVien.Add(SinhVien);
                }

                //using (SqlConnection connection = new SqlConnection(ConnectionInformation.ConnectionString))
                //{
                //    using (SqlCommand command = new SqlCommand("spGetSinhVien", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;
                //        connection.Open();
                //        SqlDataAdapter SinhVienAdapter = new SqlDataAdapter();
                //        DataTable SinhVienTable = new DataTable();
                //        SinhVienAdapter.SelectCommand = command;
                //        SinhVienAdapter.Fill(SinhVienTable);
                //        if (SinhVienTable.Rows.Count > 0)
                //        {
                //            for (int i = 0; i < SinhVienTable.Rows.Count; i++)
                //            {
                //                SinhVienBDO SinhVien = new SinhVienBDO();
                //                SinhVien.MaSV = (string)SinhVienTable.Rows[i]["Masv"];
                //                SinhVien.HoSV = (string)SinhVienTable.Rows[i]["Hosv"];
                //                SinhVien.TenSV = (string)SinhVienTable.Rows[i]["tensv"];
                //                SinhVien.GioiTinh = (bool)SinhVienTable.Rows[i]["phai"];
                //                SinhVien.NgaySinh = (DateTime)SinhVienTable.Rows[i]["ngaysinh"];
                //                SinhVien.NoiSinh = (string)SinhVienTable.Rows[i]["noisinh"];
                //                SinhVien.MaKhoa = (string)SinhVienTable.Rows[i]["Makhoa"];
                //                SinhVien.HocBong = (int)SinhVienTable.Rows[i]["Hocbong"];

                //                ListSinhVien.Add(SinhVien);
                //            }
                //        }
                //    }
                //}
                return ListSinhVien;
            }
        }
    }
}
//test git lan 2
