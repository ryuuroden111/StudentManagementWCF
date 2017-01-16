﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienDAL
    {
        using System;
        using System.Data.Entity;
        using System.Data.Entity.Infrastructure;
        using System.Data.Objects;
        using System.Data.Objects.DataClasses;
        using System.Linq;

        public partial class QLSVEntities : DbContext
        {
            public QLSVEntities()
                : base("name=QLSVEntities")
            {
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                throw new UnintentionalCodeFirstException();
            }

            public DbSet<KetQua> KetQuas { get; set; }
            public DbSet<Khoa> Khoas { get; set; }
            public DbSet<MonHoc> MonHocs { get; set; }
            public DbSet<Sinhvien> Sinhviens { get; set; }

            public virtual int spEditKetQua(string statementType, string masv, string mamh, Nullable<float> diem)
            {
                var statementTypeParameter = statementType != null ?
                    new ObjectParameter("StatementType", statementType) :
                    new ObjectParameter("StatementType", typeof(string));

                var masvParameter = masv != null ?
                    new ObjectParameter("masv", masv) :
                    new ObjectParameter("masv", typeof(string));

                var mamhParameter = mamh != null ?
                    new ObjectParameter("Mamh", mamh) :
                    new ObjectParameter("Mamh", typeof(string));

                var diemParameter = diem.HasValue ?
                    new ObjectParameter("Diem", diem) :
                    new ObjectParameter("Diem", typeof(float));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditKetQua", statementTypeParameter, masvParameter, mamhParameter, diemParameter);
            }

            public virtual int spEditKhoa(string statementType, string makhoa, string tenkhoa)
            {
                var statementTypeParameter = statementType != null ?
                    new ObjectParameter("StatementType", statementType) :
                    new ObjectParameter("StatementType", typeof(string));

                var makhoaParameter = makhoa != null ?
                    new ObjectParameter("Makhoa", makhoa) :
                    new ObjectParameter("Makhoa", typeof(string));

                var tenkhoaParameter = tenkhoa != null ?
                    new ObjectParameter("Tenkhoa", tenkhoa) :
                    new ObjectParameter("Tenkhoa", typeof(string));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditKhoa", statementTypeParameter, makhoaParameter, tenkhoaParameter);
            }

            public virtual int spEditMonHoc(string statementType, string mamh, string tenmh, Nullable<int> sotiet)
            {
                var statementTypeParameter = statementType != null ?
                    new ObjectParameter("StatementType", statementType) :
                    new ObjectParameter("StatementType", typeof(string));

                var mamhParameter = mamh != null ?
                    new ObjectParameter("Mamh", mamh) :
                    new ObjectParameter("Mamh", typeof(string));

                var tenmhParameter = tenmh != null ?
                    new ObjectParameter("Tenmh", tenmh) :
                    new ObjectParameter("Tenmh", typeof(string));

                var sotietParameter = sotiet.HasValue ?
                    new ObjectParameter("sotiet", sotiet) :
                    new ObjectParameter("sotiet", typeof(int));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditMonHoc", statementTypeParameter, mamhParameter, tenmhParameter, sotietParameter);
            }

            public virtual int spEditSinhVien(string statementType, string masv, string hosv, string tensv, Nullable<bool> phai, Nullable<System.DateTime> ngaysinh, string noisinh, string maKhoa, Nullable<int> hocbong)
            {
                var statementTypeParameter = statementType != null ?
                    new ObjectParameter("StatementType", statementType) :
                    new ObjectParameter("StatementType", typeof(string));

                var masvParameter = masv != null ?
                    new ObjectParameter("Masv", masv) :
                    new ObjectParameter("Masv", typeof(string));

                var hosvParameter = hosv != null ?
                    new ObjectParameter("Hosv", hosv) :
                    new ObjectParameter("Hosv", typeof(string));

                var tensvParameter = tensv != null ?
                    new ObjectParameter("tensv", tensv) :
                    new ObjectParameter("tensv", typeof(string));

                var phaiParameter = phai.HasValue ?
                    new ObjectParameter("phai", phai) :
                    new ObjectParameter("phai", typeof(bool));

                var ngaysinhParameter = ngaysinh.HasValue ?
                    new ObjectParameter("ngaysinh", ngaysinh) :
                    new ObjectParameter("ngaysinh", typeof(System.DateTime));

                var noisinhParameter = noisinh != null ?
                    new ObjectParameter("noisinh", noisinh) :
                    new ObjectParameter("noisinh", typeof(string));

                var maKhoaParameter = maKhoa != null ?
                    new ObjectParameter("MaKhoa", maKhoa) :
                    new ObjectParameter("MaKhoa", typeof(string));

                var hocbongParameter = hocbong.HasValue ?
                    new ObjectParameter("Hocbong", hocbong) :
                    new ObjectParameter("Hocbong", typeof(int));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditSinhVien", statementTypeParameter, masvParameter, hosvParameter, tensvParameter, phaiParameter, ngaysinhParameter, noisinhParameter, maKhoaParameter, hocbongParameter);
            }

            public virtual ObjectResult<spGetKetQua_Result> spGetKetQua(string masv, string mamh, string thongTinKhac)
            {
                var masvParameter = masv != null ?
                    new ObjectParameter("Masv", masv) :
                    new ObjectParameter("Masv", typeof(string));

                var mamhParameter = mamh != null ?
                    new ObjectParameter("Mamh", mamh) :
                    new ObjectParameter("Mamh", typeof(string));

                var thongTinKhacParameter = thongTinKhac != null ?
                    new ObjectParameter("ThongTinKhac", thongTinKhac) :
                    new ObjectParameter("ThongTinKhac", typeof(string));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetKetQua_Result>("spGetKetQua", masvParameter, mamhParameter, thongTinKhacParameter);
            }

            public virtual ObjectResult<spGetKhoa_Result> spGetKhoa(string makhoa, string thongTinKhac)
            {
                var makhoaParameter = makhoa != null ?
                    new ObjectParameter("Makhoa", makhoa) :
                    new ObjectParameter("Makhoa", typeof(string));

                var thongTinKhacParameter = thongTinKhac != null ?
                    new ObjectParameter("ThongTinKhac", thongTinKhac) :
                    new ObjectParameter("ThongTinKhac", typeof(string));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetKhoa_Result>("spGetKhoa", makhoaParameter, thongTinKhacParameter);
            }

            public virtual ObjectResult<spGetMonHoc_Result> spGetMonHoc(string mamh, string thongTinKhac)
            {
                var mamhParameter = mamh != null ?
                    new ObjectParameter("Mamh", mamh) :
                    new ObjectParameter("Mamh", typeof(string));

                var thongTinKhacParameter = thongTinKhac != null ?
                    new ObjectParameter("ThongTinKhac", thongTinKhac) :
                    new ObjectParameter("ThongTinKhac", typeof(string));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetMonHoc_Result>("spGetMonHoc", mamhParameter, thongTinKhacParameter);
            }

            public virtual ObjectResult<spGetSinhVien_Result> spGetSinhVien(string masv, string thongTinKhac)
            {
                var masvParameter = masv != null ?
                    new ObjectParameter("Masv", masv) :
                    new ObjectParameter("Masv", typeof(string));

                var thongTinKhacParameter = thongTinKhac != null ?
                    new ObjectParameter("ThongTinKhac", thongTinKhac) :
                    new ObjectParameter("ThongTinKhac", typeof(string));

                return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetSinhVien_Result>("spGetSinhVien", masvParameter, thongTinKhacParameter);
            }
        }
    }
}
