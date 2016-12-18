using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.KhoaService;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace QLHS
{
    public partial class uc_QLKhoa : UserControl
    {
        string statement = "";
        public uc_QLKhoa()
        {
            InitializeComponent();
            lb_TenKhoa.Visible = true;
            btn_TimKiem.Visible = false;
            txt_TenKhoa.Visible = true;
            btn_CapNhat.Visible = true;
            txt_MaKhoa.Width = 207;
            txt_MaKhoa.Enabled = false;
        }

        public uc_QLKhoa(string StatementType)
        {
            InitializeComponent();
            if (StatementType == "TimKhoa")
            {
                lb_TenKhoa.Visible = false;
                btn_TimKiem.Visible = true;
                txt_TenKhoa.Visible = false;
                btn_CapNhat.Visible = false;
                txt_MaKhoa.Width = 161;
            }
            else
            {
                lb_TenKhoa.Visible = true;
                btn_TimKiem.Visible = false;
                txt_TenKhoa.Visible = true;
                btn_CapNhat.Visible = true;
                txt_MaKhoa.Width = 207;
                txt_MaKhoa.Enabled = true;
                statement = "Insert";
            }
        }

        private void uc_QLKhoa_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ data
            KhoaServiceClient client = new KhoaServiceClient();
            dgv_DsKhoa.DataSource = client.GetAllKhoa();
            //Thay đổi tên cột
            gv_DsKhoa.Columns["MaKhoa"].Caption = "Mã khoa";
            gv_DsKhoa.Columns["MaKhoa"].Width = 100;
            gv_DsKhoa.Columns["MaKhoa"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            gv_DsKhoa.Columns["TenKhoa"].Caption = "Tên khoa";
            gv_DsKhoa.Columns["TenKhoa"].AppearanceCell.Font = new Font("Arial", 14, FontStyle.Bold);
            //Thêm button sửa
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddCol("EditButton", "btn_Edit", "Sửa", 0, Properties.Resources.savepagesetup_32x32);
            gv_DsKhoa.Columns["EditButton"].Width = 80;
            //Thêm button xoá
            AddCol("DeleteButton", "btn_Delete", "Xoá", 0, Properties.Resources.delete_32x32);
            gv_DsKhoa.Columns["DeleteButton"].Width = 80;

            gv_DsKhoa.Columns["TenKhoa"].Width = dgv_DsKhoa.Width - 260;
        }

        private void ReLoadData()
        {
            //Load dữ liệu từ data
            KhoaServiceClient client = new KhoaServiceClient();
            dgv_DsKhoa.DataSource = client.GetAllKhoa();
            //Thay đổi tên cột
            gv_DsKhoa.Columns["MaKhoa"].Caption = "Mã khoa";
            gv_DsKhoa.Columns["MaKhoa"].Width = 100;
            gv_DsKhoa.Columns["TenKhoa"].Caption = "Tên khoa";
            gv_DsKhoa.Columns["EditButton"].Width = 80;
            gv_DsKhoa.Columns["DeleteButton"].Width = 80;
            gv_DsKhoa.Columns["TenKhoa"].Width = dgv_DsKhoa.Width - 260;
        }

        private void AddCol(string fieldName, string buttonName, string Caption, int index,Image imagebutton)
        {
            GridColumn col = gv_DsKhoa.Columns.AddVisible(fieldName, Caption);
            gv_DsKhoa.Columns[fieldName].VisibleIndex = index;
            col.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            RepositoryItemButtonEdit repButton = new RepositoryItemButtonEdit();
            repButton.Name = buttonName;
            repButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            repButton.Buttons[0].Image = imagebutton;
            repButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //Add event click
            if(buttonName == "btn_Edit")
                repButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Edit_Click);
            else if (buttonName == "btn_Delete")
                repButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Delete_Click);
            dgv_DsKhoa.RepositoryItems.Add(repButton);
            col.ColumnEdit = repButton;
            col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
        }
        private void btn_Delete_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string TenKhoa = gv_DsKhoa.GetRowCellValue(gv_DsKhoa.FocusedRowHandle,"TenKhoa").ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xoá khoa " + TenKhoa, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KhoaService.KhoaServiceClient client = new KhoaServiceClient();
                string MaKhoa = gv_DsKhoa.GetRowCellValue(gv_DsKhoa.FocusedRowHandle, "MaKhoa").ToString();
                if (client.Delete(MaKhoa))
                {
                    MessageBox.Show("Xoá khoa " + TenKhoa + " thành công");
                    ReLoadData();
                }
                else
                    MessageBox.Show("Xoá khoa " + TenKhoa + " thất bại");
            }
        }

        private void btn_Edit_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txt_MaKhoa.Text = gv_DsKhoa.GetRowCellValue(gv_DsKhoa.FocusedRowHandle, "MaKhoa").ToString();
            txt_MaKhoa.Enabled = false;
            txt_TenKhoa.Text = gv_DsKhoa.GetRowCellValue(gv_DsKhoa.FocusedRowHandle, "TenKhoa").ToString();
            statement = "Update";
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaKhoa.Text.Trim()) && !string.IsNullOrEmpty(txt_TenKhoa.Text.Trim()))
            {
                KhoaService.KhoaServiceClient client = new KhoaServiceClient();
                KhoaService.KhoaBDO khoa = new KhoaBDO();
                khoa.MaKhoa = txt_MaKhoa.Text;
                khoa.TenKhoa = txt_TenKhoa.Text;
                if (statement == "Insert")
                {
                    //Thêm khoa mới
                    if (client.Add(khoa))
                    {
                        MessageBox.Show("Thêm khoa " + khoa.TenKhoa + " thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Thêm khoa thất bại");
                }
                else if (statement == "Update")
                {
                    //Cập nhật khoa
                    if (client.Update(khoa))
                    {
                        MessageBox.Show("Sửa khoa " + khoa.TenKhoa + " thành công");
                        ReLoadData();
                    }
                    else
                        MessageBox.Show("Thêm khoa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thiếu mã khoa hoặc tên khoa. Xin kiểm tra lại");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //Load dữ liệu từ data
            KhoaServiceClient client = new KhoaServiceClient();
            KhoaBDO khoa = client.GetKhoa(txt_MaKhoa.Text);
            KhoaBDO[] khoalist = new KhoaBDO[1];
            khoalist[0] = khoa;
            dgv_DsKhoa.DataSource = khoalist;
            //Thay đổi tên cột
            gv_DsKhoa.Columns["MaKhoa"].Caption = "Mã khoa";
            gv_DsKhoa.Columns["MaKhoa"].Width = 100 ;
            gv_DsKhoa.Columns["TenKhoa"].Caption = "Tên khoa";
        }
    }
}
