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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace QLHS
{
    public partial class uc_QLMonHoc : UserControl
    {
        string statement = "";
        public uc_QLMonHoc()
        {
            InitializeComponent();
            btn_TimKiem.Visible = false;
            lb_TenMonHoc.Visible = true;
            txt_TenMonHoc.Visible = true;
            lb_SoTiet.Visible = true;
            txt_SoTiet.Visible = true;
            btn_CapNhat.Visible = true;
            txt_MaMonHoc.Width = 207;
            txt_MaMonHoc.Enabled = false;
        }
        public uc_QLMonHoc(string StatementType)
        {
            InitializeComponent();
            if (StatementType == "TimMonHoc")
            {
                btn_TimKiem.Visible = true;
                lb_TenMonHoc.Visible = false;
                txt_TenMonHoc.Visible = false;
                lb_SoTiet.Visible = false;
                txt_SoTiet.Visible = false;
                btn_CapNhat.Visible = false;
                txt_MaMonHoc.Width = 161;
            }
            else
            {
                btn_TimKiem.Visible = false;
                lb_TenMonHoc.Visible = true;
                txt_TenMonHoc.Visible = true;
                lb_SoTiet.Visible = true;
                txt_SoTiet.Visible = true;
                btn_CapNhat.Visible = true;
                txt_MaMonHoc.Width = 207;
                txt_MaMonHoc.Enabled = true;
                statement = "Insert";
            }
        }

        private void uc_QLMonHoc_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ data
            MonHocServiceClient client = new MonHocServiceClient();
            dgv_DsMonHoc.DataSource = client.GetAllMonHoc();
            //Thay đổi tên cột
            gv_DsMonHoc.Columns["MaMH"].Caption = "Mã môn học";
            gv_DsMonHoc.Columns["MaMH"].Width = 100;
            gv_DsMonHoc.Columns["MaMH"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsMonHoc.Columns["TenMH"].Caption = "Tên môn học";
            gv_DsMonHoc.Columns["TenMH"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsMonHoc.Columns["SoTiet"].Caption = "Số tiết";
            gv_DsMonHoc.Columns["SoTiet"].Width = 100;
            gv_DsMonHoc.Columns["SoTiet"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            //Thêm button sửa
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddCol("EditButton", "btn_Edit", "Sửa", 0, Properties.Resources.savepagesetup_32x32);
            gv_DsMonHoc.Columns["EditButton"].Width = 80;
            //Thêm button xoá
            AddCol("DeleteButton", "btn_Delete", "Xoá", 0, Properties.Resources.delete_32x32);
            gv_DsMonHoc.Columns["DeleteButton"].Width = 80;

            gv_DsMonHoc.Columns["TenMH"].Width = dgv_DsMonHoc.Width - 360;
        }
        private void ReLoadData()
        {
            //Load dữ liệu từ data
            MonHocServiceClient client = new MonHocServiceClient();
            dgv_DsMonHoc.DataSource = client.GetAllMonHoc();
            //Thay đổi tên cột
            gv_DsMonHoc.Columns["MaMH"].Caption = "Mã môn học";
            gv_DsMonHoc.Columns["MaMH"].Width = 100;
            gv_DsMonHoc.Columns["TenMH"].Caption = "Tên môn học";
            gv_DsMonHoc.Columns["SoTiet"].Caption = "Số tiết";
            gv_DsMonHoc.Columns["SoTiet"].Width = 100;
            gv_DsMonHoc.Columns["EditButton"].Width = 80;
            gv_DsMonHoc.Columns["DeleteButton"].Width = 80;
            gv_DsMonHoc.Columns["TenMH"].Width = dgv_DsMonHoc.Width - 360;
        }
        private void AddCol(string fieldName, string buttonName, string Caption, int index, Image imagebutton)
        {
            GridColumn col = gv_DsMonHoc.Columns.AddVisible(fieldName, Caption);
            gv_DsMonHoc.Columns[fieldName].VisibleIndex = index;
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
            dgv_DsMonHoc.RepositoryItems.Add(repButton);
            col.ColumnEdit = repButton;
            col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
        }

        private void btn_Delete_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string TenMonHoc = gv_DsMonHoc.GetRowCellValue(gv_DsMonHoc.FocusedRowHandle, "TenMH").ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xoá môn " + TenMonHoc, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MonHocServiceClient client = new MonHocServiceClient();
                string MaMonHoc = gv_DsMonHoc.GetRowCellValue(gv_DsMonHoc.FocusedRowHandle, "MaMH").ToString();
                if (client.Delete(MaMonHoc))
                {
                    MessageBox.Show("Xoá môn " + TenMonHoc + " thành công");
                    ReLoadData();
                }
                else
                    MessageBox.Show("Xoá môn " + TenMonHoc + " thất bại");
            }
        }
        private void btn_Edit_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txt_MaMonHoc.Text = gv_DsMonHoc.GetRowCellValue(gv_DsMonHoc.FocusedRowHandle, "MaMH").ToString();
            txt_MaMonHoc.Enabled = false;
            txt_TenMonHoc.Text = gv_DsMonHoc.GetRowCellValue(gv_DsMonHoc.FocusedRowHandle, "TenMH").ToString();
            txt_SoTiet.Value = Convert.ToDecimal(gv_DsMonHoc.GetRowCellValue(gv_DsMonHoc.FocusedRowHandle,"SoTiet"));
            statement = "Update";
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaMonHoc.Text.Trim()) && !string.IsNullOrEmpty(txt_TenMonHoc.Text.Trim()))
            {
                MonHocServiceClient client = new MonHocServiceClient();
                MonHocBDO monhoc = new MonHocBDO();
                monhoc.MaMH = txt_MaMonHoc.Text;
                monhoc.TenMH = txt_TenMonHoc.Text;
                monhoc.SoTiet = Convert.ToInt32(txt_SoTiet.Value);
                if (statement == "Insert")
                {
                    //Thêm môn mới
                    if (client.Add(monhoc))
                    {
                        MessageBox.Show("Thêm môn " + monhoc.TenMH + " thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Thêm môn thất bại");
                }
                else if (statement == "Update")
                {
                    //Cập nhật môn
                    if (client.Update(monhoc))
                    {
                        MessageBox.Show("Sửa môn " + monhoc.TenMH + " thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Sửa môn thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thiếu mã môn hoặc tên môn học. Xin kiểm tra lại");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //Load dữ liệu từ data
            MonHocServiceClient client = new MonHocServiceClient();
            MonHocBDO monhoc = client.GetMonHoc(txt_MaMonHoc.Text);
            MonHocBDO[] monhoclist = new MonHocBDO[1];
            monhoclist[0] = monhoc;
            dgv_DsMonHoc.DataSource = monhoclist;
            //Thay đổi tên cột
            gv_DsMonHoc.Columns["MaMH"].Caption = "Mã môn học";
            gv_DsMonHoc.Columns["MaMH"].Width = 100;
            gv_DsMonHoc.Columns["TenMH"].Caption = "Tên Môn Học";
            gv_DsMonHoc.Columns["SoTiet"].Caption = "Số tiết";
            gv_DsMonHoc.Columns["SoTiet"].Width = 100;
        }
    }
}
