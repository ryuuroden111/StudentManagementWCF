using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.MonHocService;
using QLHS.SinhVienService;
using QLHS.KetQuaService;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace QLHS
{
    public partial class uc_QLKetQua : UserControl
    {
        string statement = "";
        public uc_QLKetQua()
        {
            InitializeComponent();
            btn_TimKiem.Visible = false;
            lb_MaMonHoc.Visible = true;
            cbo_MaMonHoc.Visible = true;
            lb_MaSinhVien.Visible = true;
            cbo_MaSinhVien.Visible = true;
            lb_SoDiem.Visible = true;
            txt_SoDiem.Visible = true;
            btn_CapNhat.Visible = true;
            cbo_MaMonHoc.Enabled = false;
            cbo_MaSinhVien.Enabled = false;
        }
        public uc_QLKetQua(string StatementType)
        {
            InitializeComponent();
            if (StatementType == "TimKetQua")
            {
                btn_TimKiem.Visible = true;
                lb_SoDiem.Visible = false;
                txt_SoDiem.Visible = false;
                btn_CapNhat.Visible = false;
            }
            else
            {
                btn_TimKiem.Visible = false;
                lb_SoDiem.Visible = true;
                txt_SoDiem.Visible = true;
                btn_CapNhat.Visible = true;
                cbo_MaMonHoc.Enabled = true;
                cbo_MaSinhVien.Enabled = true;
                statement = "Insert";
            }
        }

        private void uc_QLKetQua_Load(object sender, EventArgs e)
        {
            //Load dữ liệu combobox 
            MonHocServiceClient monhocclient = new MonHocServiceClient();
            cbo_MaMonHoc.DataSource = monhocclient.GetAllMonHoc();
            cbo_MaMonHoc.ValueMember = "MaMH";
            cbo_MaMonHoc.DisplayMember = "MaMH";

            SinhVienServiceClient sinhvienclient = new SinhVienServiceClient();
            cbo_MaSinhVien.DataSource = sinhvienclient.GetAllSinhVien();
            cbo_MaSinhVien.ValueMember = "MaSV";
            cbo_MaSinhVien.DisplayMember = "MaSV";
            //Load dữ liệu từ data
            KetQuaServiceClient client = new KetQuaServiceClient();
            dgv_DsKetQua.DataSource = client.GetAllKetQua();
            //Thay đổi tên cột
            gv_DsKetQua.Columns["MaSV"].Caption = "Mã sinh viên";
            gv_DsKetQua.Columns["MaSV"].Width = 100;
            gv_DsKetQua.Columns["MaSV"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsKetQua.Columns["MaMH"].Caption = "Mã môn học";
            gv_DsKetQua.Columns["MaMH"].Width = 100;
            gv_DsKetQua.Columns["MaMH"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsKetQua.Columns["Diem"].Caption = "Số điểm";
            gv_DsKetQua.Columns["Diem"].Width = 100;
            gv_DsKetQua.Columns["Diem"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            //Thêm button sửa
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddCol("EditButton", "btn_Edit", "Sửa", 0, Properties.Resources.savepagesetup_32x32);
            gv_DsKetQua.Columns["EditButton"].Width = 80;
            //Thêm button xoá
            AddCol("DeleteButton", "btn_Delete", "Xoá", 0, Properties.Resources.delete_32x32);
            gv_DsKetQua.Columns["DeleteButton"].Width = 80;
        }
        private void ReLoadData()
        {
            //Load dữ liệu từ data
            KetQuaServiceClient client = new KetQuaServiceClient();
            dgv_DsKetQua.DataSource = client.GetAllKetQua();
            //Thay đổi tên cột
            gv_DsKetQua.Columns["MaSV"].Caption = "Mã sinh viên";
            gv_DsKetQua.Columns["MaSV"].Width = 100;
            gv_DsKetQua.Columns["MaSV"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsKetQua.Columns["MaMH"].Caption = "Mã môn học";
            gv_DsKetQua.Columns["MaMH"].Width = 100;
            gv_DsKetQua.Columns["MaMH"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsKetQua.Columns["Diem"].Caption = "Số điểm";
            gv_DsKetQua.Columns["Diem"].Width = 100;
            gv_DsKetQua.Columns["Diem"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsKetQua.Columns["EditButton"].Width = 80;
            gv_DsKetQua.Columns["DeleteButton"].Width = 80;
        }
        private void AddCol(string fieldName, string buttonName, string Caption, int index, Image imagebutton)
        {
            GridColumn col = gv_DsKetQua.Columns.AddVisible(fieldName, Caption);
            gv_DsKetQua.Columns[fieldName].VisibleIndex = index;
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
            dgv_DsKetQua.RepositoryItems.Add(repButton);
            col.ColumnEdit = repButton;
            col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
        }

        private void btn_Delete_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá kết quả này", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KetQuaServiceClient client = new KetQuaServiceClient();
                string MaMonHoc = gv_DsKetQua.GetRowCellValue(gv_DsKetQua.FocusedRowHandle, "MaMH").ToString();
                string MaSinhVien = gv_DsKetQua.GetRowCellValue(gv_DsKetQua.FocusedRowHandle, "MaSV").ToString();
                if (client.Delete(MaSinhVien,MaMonHoc))
                {
                    MessageBox.Show("Xoá kết quả thành công");
                    ReLoadData();
                }
                else
                    MessageBox.Show("Xoá kết quả thất bại");
            }
        }
        private void btn_Edit_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            cbo_MaMonHoc.SelectedValue = gv_DsKetQua.GetRowCellValue(gv_DsKetQua.FocusedRowHandle, "MaMH").ToString();
            cbo_MaSinhVien.SelectedValue = gv_DsKetQua.GetRowCellValue(gv_DsKetQua.FocusedRowHandle, "MaSV").ToString();
            cbo_MaMonHoc.Enabled = false;
            cbo_MaSinhVien.Enabled = false;
            txt_SoDiem.Text = gv_DsKetQua.GetRowCellValue(gv_DsKetQua.FocusedRowHandle, "Diem").ToString();
            statement = "Update";
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_SoDiem.Text.Trim()))
            {
                KetQuaServiceClient client = new KetQuaServiceClient();
                KetQuaBDO ketqua = new KetQuaBDO();
                ketqua.MaMH = cbo_MaMonHoc.SelectedValue.ToString();
                ketqua.MaSV = cbo_MaSinhVien.SelectedValue.ToString();
                ketqua.Diem = float.Parse(txt_SoDiem.Text);
                if (statement == "Insert")
                {
                    //Thêm môn mới
                    if (client.Add(ketqua))
                    {
                        MessageBox.Show("Thêm kết quả thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Thêm kết quả thất bại");
                }
                else if (statement == "Update")
                {
                    //Cập nhật môn
                    if (client.Update(ketqua))
                    {
                        MessageBox.Show("Sửa kết quả thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Sửa kết quả thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thiếu mã môn hoặc mã sinh viên hoặc số điểm. Xin kiểm tra lại");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //Load dữ liệu từ data
            KetQuaServiceClient client = new KetQuaServiceClient();
            KetQuaBDO ketqua = client.GetKetQua(cbo_MaSinhVien.SelectedValue.ToString(), cbo_MaMonHoc.SelectedValue.ToString());
            KetQuaBDO[] ketqualist = new KetQuaBDO[1];
            ketqualist[0] = ketqua;
            dgv_DsKetQua.DataSource = ketqualist;
            //Thay đổi tên cột
            gv_DsKetQua.Columns["MaMH"].Caption = "Mã môn học";
            gv_DsKetQua.Columns["MaMH"].Width = 100;
            gv_DsKetQua.Columns["MaSV"].Caption = "Mã sinh viên";
            gv_DsKetQua.Columns["MaSV"].Width = 100;
            gv_DsKetQua.Columns["Diem"].Caption = "Số điểm";
            gv_DsKetQua.Columns["Diem"].Width = 100;
        }
    }
}
