namespace QLHS
{
    partial class uc_QLSinhVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLSinhVien));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.lb_HoSinhVien = new System.Windows.Forms.Label();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.cbo_Khoa = new System.Windows.Forms.ComboBox();
            this.lb_Khoa = new System.Windows.Forms.Label();
            this.txt_NoiSinh = new System.Windows.Forms.TextBox();
            this.lb_NoiSinh = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.txt_TenSinhVien = new System.Windows.Forms.TextBox();
            this.lb_TenSinhVien = new System.Windows.Forms.Label();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_HoSinhVien = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
            this.lb_MaSinhVien = new System.Windows.Forms.Label();
            this.dgv_DsSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gv_DsSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lb_HocBong = new System.Windows.Forms.Label();
            this.txt_HocBong = new System.Windows.Forms.TextBox();
            this.pn_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_HoSinhVien
            // 
            this.lb_HoSinhVien.AutoSize = true;
            this.lb_HoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HoSinhVien.Location = new System.Drawing.Point(3, 70);
            this.lb_HoSinhVien.Name = "lb_HoSinhVien";
            this.lb_HoSinhVien.Size = new System.Drawing.Size(102, 20);
            this.lb_HoSinhVien.TabIndex = 3;
            this.lb_HoSinhVien.Text = "Họ Sinh Viên";
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.txt_HocBong);
            this.pn_Nav.Controls.Add(this.lb_HocBong);
            this.pn_Nav.Controls.Add(this.cbo_Khoa);
            this.pn_Nav.Controls.Add(this.lb_Khoa);
            this.pn_Nav.Controls.Add(this.txt_NoiSinh);
            this.pn_Nav.Controls.Add(this.lb_NoiSinh);
            this.pn_Nav.Controls.Add(this.dtp_NgaySinh);
            this.pn_Nav.Controls.Add(this.lb_NgaySinh);
            this.pn_Nav.Controls.Add(this.cbo_GioiTinh);
            this.pn_Nav.Controls.Add(this.lb_GioiTinh);
            this.pn_Nav.Controls.Add(this.txt_TenSinhVien);
            this.pn_Nav.Controls.Add(this.lb_TenSinhVien);
            this.pn_Nav.Controls.Add(this.btn_TimKiem);
            this.pn_Nav.Controls.Add(this.txt_HoSinhVien);
            this.pn_Nav.Controls.Add(this.lb_HoSinhVien);
            this.pn_Nav.Controls.Add(this.btn_CapNhat);
            this.pn_Nav.Controls.Add(this.txt_MaSinhVien);
            this.pn_Nav.Controls.Add(this.lb_MaSinhVien);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(216, 493);
            this.pn_Nav.TabIndex = 4;
            // 
            // cbo_Khoa
            // 
            this.cbo_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Khoa.FormattingEnabled = true;
            this.cbo_Khoa.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_Khoa.Location = new System.Drawing.Point(3, 355);
            this.cbo_Khoa.Name = "cbo_Khoa";
            this.cbo_Khoa.Size = new System.Drawing.Size(207, 28);
            this.cbo_Khoa.TabIndex = 15;
            // 
            // lb_Khoa
            // 
            this.lb_Khoa.AutoSize = true;
            this.lb_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Khoa.Location = new System.Drawing.Point(3, 332);
            this.lb_Khoa.Name = "lb_Khoa";
            this.lb_Khoa.Size = new System.Drawing.Size(46, 20);
            this.lb_Khoa.TabIndex = 14;
            this.lb_Khoa.Text = "Khoa";
            // 
            // txt_NoiSinh
            // 
            this.txt_NoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NoiSinh.Location = new System.Drawing.Point(3, 303);
            this.txt_NoiSinh.Name = "txt_NoiSinh";
            this.txt_NoiSinh.Size = new System.Drawing.Size(207, 26);
            this.txt_NoiSinh.TabIndex = 13;
            // 
            // lb_NoiSinh
            // 
            this.lb_NoiSinh.AutoSize = true;
            this.lb_NoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NoiSinh.Location = new System.Drawing.Point(3, 280);
            this.lb_NoiSinh.Name = "lb_NoiSinh";
            this.lb_NoiSinh.Size = new System.Drawing.Size(68, 20);
            this.lb_NoiSinh.TabIndex = 12;
            this.lb_NoiSinh.Text = "Nơi Sinh";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(3, 251);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(207, 26);
            this.dtp_NgaySinh.TabIndex = 11;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NgaySinh.Location = new System.Drawing.Point(3, 228);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lb_NgaySinh.TabIndex = 10;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_GioiTinh.Location = new System.Drawing.Point(3, 197);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(207, 28);
            this.cbo_GioiTinh.TabIndex = 9;
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_GioiTinh.Location = new System.Drawing.Point(3, 174);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lb_GioiTinh.TabIndex = 8;
            this.lb_GioiTinh.Text = "Giới Tính";
            // 
            // txt_TenSinhVien
            // 
            this.txt_TenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenSinhVien.Location = new System.Drawing.Point(3, 145);
            this.txt_TenSinhVien.Name = "txt_TenSinhVien";
            this.txt_TenSinhVien.Size = new System.Drawing.Size(207, 26);
            this.txt_TenSinhVien.TabIndex = 7;
            // 
            // lb_TenSinhVien
            // 
            this.lb_TenSinhVien.AutoSize = true;
            this.lb_TenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenSinhVien.Location = new System.Drawing.Point(3, 122);
            this.lb_TenSinhVien.Name = "lb_TenSinhVien";
            this.lb_TenSinhVien.Size = new System.Drawing.Size(108, 20);
            this.lb_TenSinhVien.TabIndex = 6;
            this.lb_TenSinhVien.Text = "Tên Sinh Viên";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(170, 38);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(40, 36);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Cập nhật";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_HoSinhVien
            // 
            this.txt_HoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HoSinhVien.Location = new System.Drawing.Point(3, 93);
            this.txt_HoSinhVien.Name = "txt_HoSinhVien";
            this.txt_HoSinhVien.Size = new System.Drawing.Size(207, 26);
            this.txt_HoSinhVien.TabIndex = 4;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(101, 441);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(109, 36);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_MaSinhVien
            // 
            this.txt_MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSinhVien.Location = new System.Drawing.Point(3, 41);
            this.txt_MaSinhVien.Name = "txt_MaSinhVien";
            this.txt_MaSinhVien.Size = new System.Drawing.Size(161, 26);
            this.txt_MaSinhVien.TabIndex = 1;
            // 
            // lb_MaSinhVien
            // 
            this.lb_MaSinhVien.AutoSize = true;
            this.lb_MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaSinhVien.Location = new System.Drawing.Point(3, 18);
            this.lb_MaSinhVien.Name = "lb_MaSinhVien";
            this.lb_MaSinhVien.Size = new System.Drawing.Size(103, 20);
            this.lb_MaSinhVien.TabIndex = 0;
            this.lb_MaSinhVien.Text = "Mã Sinh Viên";
            // 
            // dgv_DsSinhVien
            // 
            this.dgv_DsSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgv_DsSinhVien.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_DsSinhVien.Location = new System.Drawing.Point(216, 0);
            this.dgv_DsSinhVien.MainView = this.gv_DsSinhVien;
            this.dgv_DsSinhVien.Name = "dgv_DsSinhVien";
            this.dgv_DsSinhVien.Size = new System.Drawing.Size(622, 493);
            this.dgv_DsSinhVien.TabIndex = 5;
            this.dgv_DsSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DsSinhVien});
            // 
            // gv_DsSinhVien
            // 
            this.gv_DsSinhVien.GridControl = this.dgv_DsSinhVien;
            this.gv_DsSinhVien.Name = "gv_DsSinhVien";
            this.gv_DsSinhVien.OptionsBehavior.ReadOnly = true;
            this.gv_DsSinhVien.OptionsCustomization.AllowColumnMoving = false;
            this.gv_DsSinhVien.OptionsPrint.AutoWidth = false;
            this.gv_DsSinhVien.OptionsView.ColumnAutoWidth = false;
            // 
            // lb_HocBong
            // 
            this.lb_HocBong.AutoSize = true;
            this.lb_HocBong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HocBong.Location = new System.Drawing.Point(3, 386);
            this.lb_HocBong.Name = "lb_HocBong";
            this.lb_HocBong.Size = new System.Drawing.Size(80, 20);
            this.lb_HocBong.TabIndex = 16;
            this.lb_HocBong.Text = "Học Bổng";
            // 
            // txt_HocBong
            // 
            this.txt_HocBong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HocBong.Location = new System.Drawing.Point(3, 409);
            this.txt_HocBong.Name = "txt_HocBong";
            this.txt_HocBong.Size = new System.Drawing.Size(207, 26);
            this.txt_HocBong.TabIndex = 17;
            // 
            // uc_QLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DsSinhVien);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_QLSinhVien";
            this.Size = new System.Drawing.Size(838, 493);
            this.Load += new System.EventHandler(this.uc_QLSinhVien_Load);
            this.pn_Nav.ResumeLayout(false);
            this.pn_Nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_HoSinhVien;
        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.Label lb_TenSinhVien;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private System.Windows.Forms.TextBox txt_HoSinhVien;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private System.Windows.Forms.TextBox txt_MaSinhVien;
        private System.Windows.Forms.Label lb_MaSinhVien;
        private DevExpress.XtraGrid.GridControl dgv_DsSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DsSinhVien;
        private System.Windows.Forms.TextBox txt_TenSinhVien;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label lb_NoiSinh;
        private System.Windows.Forms.TextBox txt_NoiSinh;
        private System.Windows.Forms.Label lb_Khoa;
        private System.Windows.Forms.ComboBox cbo_Khoa;
        private System.Windows.Forms.Label lb_HocBong;
        private System.Windows.Forms.TextBox txt_HocBong;
    }
}
