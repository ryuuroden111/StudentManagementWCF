using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1(bool rule)
        {
            InitializeComponent();
            ribPg_AppManager.Visible = rule;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_DsKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLKhoa khoa = new uc_QLKhoa();
            khoa.Visible = true;
            khoa.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(khoa);
        }
        private void btn_ThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLKhoa khoa = new uc_QLKhoa("ThemKhoa");
            khoa.Visible = true;
            khoa.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(khoa);
        }
        private void btn_TimKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLKhoa khoa = new uc_QLKhoa("TimKhoa");
            khoa.Visible = true;
            khoa.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(khoa);
        }

        private void btn_DsMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLMonHoc monhoc = new uc_QLMonHoc();
            monhoc.Visible = true;
            monhoc.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(monhoc);
        }
        private void btn_ThemMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLMonHoc monhoc = new uc_QLMonHoc("ThemMonHoc");
            monhoc.Visible = true;
            monhoc.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(monhoc);
        }
        private void btn_TimMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLMonHoc monhoc = new uc_QLMonHoc("TimMonHoc");
            monhoc.Visible = true;
            monhoc.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(monhoc);
        }

        private void btn_DsSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLSinhVien sinhvien = new uc_QLSinhVien();
            sinhvien.Visible = true;
            sinhvien.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(sinhvien);
        }
        private void btn_ThemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLSinhVien sinhvien = new uc_QLSinhVien("ThemSinhVien");
            sinhvien.Visible = true;
            sinhvien.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(sinhvien);
        }
        private void btn_TimSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLSinhVien sinhvien = new uc_QLSinhVien("TimSinhVien");
            sinhvien.Visible = true;
            sinhvien.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(sinhvien);
        }

        private void btn_DsKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLKetQua KetQua = new uc_QLKetQua();
            KetQua.Visible = true;
            KetQua.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(KetQua);
        }
        private void btn_ThemKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLKetQua KetQua = new uc_QLKetQua("ThemKetQua");
            KetQua.Visible = true;
            KetQua.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(KetQua);
        }
        private void btn_TimKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLKetQua KetQua = new uc_QLKetQua("TimKetQua");
            KetQua.Visible = true;
            KetQua.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(KetQua);
        }
    }
}
