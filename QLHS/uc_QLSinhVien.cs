using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.SinhVienService;
using QLHS.KhoaService;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace QLHS
{
    public partial class uc_QLSinhVien : UserControl
    {
        string statement = "";
        public uc_QLSinhVien()
        {
            InitializeComponent();
            btn_TimKiem.Visible = false;
            lb_HoSinhVien.Visible = true;
            txt_HoSinhVien.Visible = true;
            lb_TenSinhVien.Visible = true;
            txt_TenSinhVien.Visible = true;
            lb_GioiTinh.Visible = true;
            cbo_GioiTinh.Visible = true;
            lb_NgaySinh.Visible = true;
            dtp_NgaySinh.Visible = true;
            lb_NoiSinh.Visible = true;
            txt_NoiSinh.Visible = true;
            lb_Khoa.Visible = true;
            cbo_Khoa.Visible = true;
            lb_HocBong.Visible = true;
            txt_HocBong.Visible = true;
            btn_CapNhat.Visible = true;
            txt_MaSinhVien.Width = 207;
            txt_MaSinhVien.Enabled = false;
        }
        public uc_QLSinhVien(string StatementType)
        {
            InitializeComponent();
            if (StatementType == "TimSinhVien")
            {
                btn_TimKiem.Visible = true;
                lb_HoSinhVien.Visible = false;
                txt_HoSinhVien.Visible = false;
                lb_TenSinhVien.Visible = false;
                txt_TenSinhVien.Visible = false;
                lb_GioiTinh.Visible = false;
                cbo_GioiTinh.Visible = false;
                lb_NgaySinh.Visible = false;
                dtp_NgaySinh.Visible = false;
                lb_NoiSinh.Visible = false;
                txt_NoiSinh.Visible = false;
                lb_Khoa.Visible = false;
                cbo_Khoa.Visible = false;
                lb_HocBong.Visible = false;
                txt_HocBong.Visible = false;
                btn_CapNhat.Visible = false;
                txt_MaSinhVien.Width = 161;
            }
            else
            {
                btn_TimKiem.Visible = false;
                lb_HoSinhVien.Visible = true;
                txt_HoSinhVien.Visible = true;
                lb_TenSinhVien.Visible = true;
                txt_TenSinhVien.Visible = true;
                lb_GioiTinh.Visible = true;
                cbo_GioiTinh.Visible = true;
                lb_NgaySinh.Visible = true;
                dtp_NgaySinh.Visible = true;
                lb_NoiSinh.Visible = true;
                txt_NoiSinh.Visible = true;
                lb_Khoa.Visible = true;
                cbo_Khoa.Visible = true;
                lb_HocBong.Visible = true;
                txt_HocBong.Visible = true;
                btn_CapNhat.Visible = true;
                txt_MaSinhVien.Width = 207;
                txt_MaSinhVien.Enabled = true;
                statement = "Insert";
            }
        }

        private void uc_QLSinhVien_Load(object sender, EventArgs e)
        {
            //Load dữ liệu combobox Khoa
            KhoaServiceClient khoaclient = new KhoaServiceClient();
            cbo_Khoa.DataSource = khoaclient.GetAllKhoa();
            cbo_Khoa.ValueMember = "MaKhoa";
            cbo_Khoa.DisplayMember = "TenKhoa";
            //Load dữ liệu từ data
            SinhVienServiceClient client = new SinhVienServiceClient();
            dgv_DsSinhVien.DataSource = client.GetAllSinhVien();
            //Thay đổi tên cột
            gv_DsSinhVien.Columns["MaSV"].Caption = "Mã sinh viên";
            gv_DsSinhVien.Columns["MaSV"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsSinhVien.Columns["HoSV"].Caption = "Họ sinh viên";
            gv_DsSinhVien.Columns["HoSV"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsSinhVien.Columns["TenSV"].Caption = "Tên sinh viên";
            gv_DsSinhVien.Columns["TenSV"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsSinhVien.Columns["GioiTinh"].Caption = "Giới tính";
            gv_DsSinhVien.Columns["GioiTinh"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsSinhVien.Columns["NgaySinh"].Caption = "Ngày sinh";
            gv_DsSinhVien.Columns["NgaySinh"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsSinhVien.Columns["NoiSinh"].Caption = "Nơi sinh";
            gv_DsSinhVien.Columns["NoiSinh"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsSinhVien.Columns["MaKhoa"].Caption = "Mã khoa";
            gv_DsSinhVien.Columns["MaKhoa"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsSinhVien.Columns["HocBong"].Caption = "Học bổng";
            gv_DsSinhVien.Columns["HocBong"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            //Thêm button sửa
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddCol("EditButton", "btn_Edit", "Sửa", 0, Properties.Resources.savepagesetup_32x32);
            gv_DsSinhVien.Columns["EditButton"].Width = 80;
            //Thêm button xoá
            AddCol("DeleteButton", "btn_Delete", "Xoá", 0, Properties.Resources.delete_32x32);
            gv_DsSinhVien.Columns["DeleteButton"].Width = 80;

        }
        private void ReLoadData()
        {
            //Load dữ liệu từ data
            SinhVienServiceClient client = new SinhVienServiceClient();
            dgv_DsSinhVien.DataSource = client.GetAllSinhVien();
            //Thay đổi tên cột
            gv_DsSinhVien.Columns["MaSV"].Caption = "Mã sinh viên";
            gv_DsSinhVien.Columns["HoSV"].Caption = "Họ sinh viên";
            gv_DsSinhVien.Columns["TenSV"].Caption = "Tên sinh viên";
            gv_DsSinhVien.Columns["GioiTinh"].Caption = "Giới tính";
            gv_DsSinhVien.Columns["NgaySinh"].Caption = "Ngày sinh";
            gv_DsSinhVien.Columns["NoiSinh"].Caption = "Nơi sinh";
            gv_DsSinhVien.Columns["MaKhoa"].Caption = "Mã khoa";
            gv_DsSinhVien.Columns["HocBong"].Caption = "Học bổng";
            //Thêm button sửa
            gv_DsSinhVien.Columns["EditButton"].Width = 80;
            gv_DsSinhVien.Columns["DeleteButton"].Width = 80;
        }
        private void AddCol(string fieldName, string buttonName, string Caption, int index, Image imagebutton)
        {
            GridColumn col = gv_DsSinhVien.Columns.AddVisible(fieldName, Caption);
            gv_DsSinhVien.Columns[fieldName].VisibleIndex = index;
            col.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            RepositoryItemButtonEdit repButton = new RepositoryItemButtonEdit();
            repButton.Name = buttonName;
            repButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            repButton.Buttons[0].Image = imagebutton;
            repButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //Add event click
            if (buttonName == "btn_Edit")
                repButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Edit_Click);
            else if (buttonName == "btn_Delete")
                repButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Delete_Click);
            dgv_DsSinhVien.RepositoryItems.Add(repButton);
            col.ColumnEdit = repButton;
            col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
        }

        private void btn_Delete_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string HoTenSinhVien = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "HoSV").ToString().Trim() + " " + gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "TenSV").ToString().Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xoá sinh viên " + HoTenSinhVien, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SinhVienServiceClient client = new SinhVienServiceClient();
                string MaSinhVien = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "MaSV").ToString();
                if (client.Delete(MaSinhVien))
                {
                    MessageBox.Show("Xoá sing viên " + HoTenSinhVien + " thành công");
                    ReLoadData();
                }
                else
                    MessageBox.Show("Xoá sinh viên " + HoTenSinhVien + " thất bại");
            }
        }
        private void btn_Edit_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txt_MaSinhVien.Text = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "MaSV").ToString();
            txt_MaSinhVien.Enabled = false;
            txt_HoSinhVien.Text = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "HoSV").ToString();
            txt_TenSinhVien.Text = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "TenSV").ToString();
            if (Convert.ToBoolean(gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "GioiTinh")))
            {
                cbo_GioiTinh.Text = "Nam";
            }
            else
                cbo_GioiTinh.Text = "Nữ";
            dtp_NgaySinh.Value = Convert.ToDateTime(gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "NgaySinh"));
            txt_NoiSinh.Text = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "NoiSinh").ToString();
            cbo_Khoa.SelectedValue = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "MaKhoa").ToString();
            txt_HocBong.Text = gv_DsSinhVien.GetRowCellValue(gv_DsSinhVien.FocusedRowHandle, "HocBong").ToString();
            statement = "Update";
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaSinhVien.Text.Trim()) && !string.IsNullOrEmpty(txt_HoSinhVien.Text.Trim()) && !string.IsNullOrEmpty(txt_TenSinhVien.Text.Trim()))
            {
                SinhVienServiceClient client = new SinhVienServiceClient();
                SinhVienBDO sinhvien = new SinhVienBDO();
                sinhvien.MaSV = txt_MaSinhVien.Text;
                sinhvien.HoSV = txt_HoSinhVien.Text;
                sinhvien.TenSV = txt_TenSinhVien.Text;
                if (cbo_GioiTinh.Text == "Nam")
                    sinhvien.GioiTinh = true;
                else
                    sinhvien.GioiTinh = false;
                sinhvien.NgaySinh = dtp_NgaySinh.Value;
                sinhvien.NoiSinh = txt_NoiSinh.Text;
                sinhvien.MaKhoa = cbo_Khoa.SelectedValue.ToString();
                sinhvien.HocBong = Convert.ToInt32(txt_HocBong.Text);
                if (statement == "Insert")
                {
                    //Thêm môn mới
                    if (client.Add(sinhvien))
                    {
                        MessageBox.Show("Thêm sinh viên " + sinhvien.HoSV+" "+sinhvien.TenSV + " thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Thêm sinh viên thất bại");
                }
                else if (statement == "Update")
                {
                    //Cập nhật môn
                    if (client.Update(sinhvien))
                    {
                        MessageBox.Show("Sửa sinh viên " + sinhvien.HoSV + " " + sinhvien.TenSV + " thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Sửa sinh viên thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thiếu mã sinh viên hoặc tên sinh viên. Xin kiểm tra lại");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //Load dữ liệu từ data
            SinhVienServiceClient client = new SinhVienServiceClient();
            SinhVienBDO sinhvien = client.GetSinhVien(txt_MaSinhVien.Text);
            SinhVienBDO[] sinhvienlist = new SinhVienBDO[1];
            sinhvienlist[0] = sinhvien;
            dgv_DsSinhVien.DataSource = sinhvienlist;
            //Thay đổi tên cột
            gv_DsSinhVien.Columns["MaSV"].Caption = "Mã sinh viên";
            gv_DsSinhVien.Columns["HoSV"].Caption = "Họ sinh viên";
            gv_DsSinhVien.Columns["TenSV"].Caption = "Tên sinh viên";
            gv_DsSinhVien.Columns["GioiTinh"].Caption = "Giới tính";
            gv_DsSinhVien.Columns["NgaySinh"].Caption = "Ngày sinh";
            gv_DsSinhVien.Columns["NoiSinh"].Caption = "Nơi sinh";
            gv_DsSinhVien.Columns["MaKhoa"].Caption = "Mã khoa";
            gv_DsSinhVien.Columns["HocBong"].Caption = "Học bổng";
        }

    }
}
