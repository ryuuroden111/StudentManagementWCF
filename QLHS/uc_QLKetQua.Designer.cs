namespace QLHS
{
    partial class uc_QLKetQua
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLKetQua));
            this.dgv_DsKetQua = new DevExpress.XtraGrid.GridControl();
            this.gv_DsKetQua = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.lb_SoDiem = new System.Windows.Forms.Label();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.lb_MaSinhVien = new System.Windows.Forms.Label();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.lb_MaMonHoc = new System.Windows.Forms.Label();
            this.txt_SoDiem = new System.Windows.Forms.TextBox();
            this.cbo_MaMonHoc = new System.Windows.Forms.ComboBox();
            this.cbo_MaSinhVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsKetQua)).BeginInit();
            this.pn_Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DsKetQua
            // 
            this.dgv_DsKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgv_DsKetQua.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_DsKetQua.Location = new System.Drawing.Point(216, 0);
            this.dgv_DsKetQua.MainView = this.gv_DsKetQua;
            this.dgv_DsKetQua.Name = "dgv_DsKetQua";
            this.dgv_DsKetQua.Size = new System.Drawing.Size(649, 354);
            this.dgv_DsKetQua.TabIndex = 5;
            this.dgv_DsKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DsKetQua});
            // 
            // gv_DsKetQua
            // 
            this.gv_DsKetQua.GridControl = this.dgv_DsKetQua;
            this.gv_DsKetQua.Name = "gv_DsKetQua";
            this.gv_DsKetQua.OptionsBehavior.ReadOnly = true;
            this.gv_DsKetQua.OptionsCustomization.AllowColumnMoving = false;
            this.gv_DsKetQua.OptionsPrint.AutoWidth = false;
            this.gv_DsKetQua.OptionsView.ColumnAutoWidth = false;
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.txt_SoDiem);
            this.pn_Nav.Controls.Add(this.cbo_MaSinhVien);
            this.pn_Nav.Controls.Add(this.cbo_MaMonHoc);
            this.pn_Nav.Controls.Add(this.lb_SoDiem);
            this.pn_Nav.Controls.Add(this.btn_TimKiem);
            this.pn_Nav.Controls.Add(this.lb_MaSinhVien);
            this.pn_Nav.Controls.Add(this.btn_CapNhat);
            this.pn_Nav.Controls.Add(this.lb_MaMonHoc);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(216, 354);
            this.pn_Nav.TabIndex = 4;
            // 
            // lb_SoDiem
            // 
            this.lb_SoDiem.AutoSize = true;
            this.lb_SoDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SoDiem.Location = new System.Drawing.Point(3, 124);
            this.lb_SoDiem.Name = "lb_SoDiem";
            this.lb_SoDiem.Size = new System.Drawing.Size(70, 20);
            this.lb_SoDiem.TabIndex = 6;
            this.lb_SoDiem.Text = "Số Điểm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(170, 127);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(40, 36);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Cập nhật";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lb_MaSinhVien
            // 
            this.lb_MaSinhVien.AutoSize = true;
            this.lb_MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaSinhVien.Location = new System.Drawing.Point(3, 70);
            this.lb_MaSinhVien.Name = "lb_MaSinhVien";
            this.lb_MaSinhVien.Size = new System.Drawing.Size(103, 20);
            this.lb_MaSinhVien.TabIndex = 3;
            this.lb_MaSinhVien.Text = "Mã Sinh Viên";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(101, 179);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(109, 36);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // lb_MaMonHoc
            // 
            this.lb_MaMonHoc.AutoSize = true;
            this.lb_MaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaMonHoc.Location = new System.Drawing.Point(3, 18);
            this.lb_MaMonHoc.Name = "lb_MaMonHoc";
            this.lb_MaMonHoc.Size = new System.Drawing.Size(99, 20);
            this.lb_MaMonHoc.TabIndex = 0;
            this.lb_MaMonHoc.Text = "Mã Môn Học";
            // 
            // txt_SoDiem
            // 
            this.txt_SoDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoDiem.Location = new System.Drawing.Point(3, 147);
            this.txt_SoDiem.Name = "txt_SoDiem";
            this.txt_SoDiem.Size = new System.Drawing.Size(207, 26);
            this.txt_SoDiem.TabIndex = 4;
            // 
            // cbo_MaMonHoc
            // 
            this.cbo_MaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaMonHoc.FormattingEnabled = true;
            this.cbo_MaMonHoc.Location = new System.Drawing.Point(3, 41);
            this.cbo_MaMonHoc.Name = "cbo_MaMonHoc";
            this.cbo_MaMonHoc.Size = new System.Drawing.Size(207, 28);
            this.cbo_MaMonHoc.TabIndex = 7;
            // 
            // cbo_MaSinhVien
            // 
            this.cbo_MaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaSinhVien.FormattingEnabled = true;
            this.cbo_MaSinhVien.Location = new System.Drawing.Point(3, 93);
            this.cbo_MaSinhVien.Name = "cbo_MaSinhVien";
            this.cbo_MaSinhVien.Size = new System.Drawing.Size(207, 28);
            this.cbo_MaSinhVien.TabIndex = 8;
            // 
            // uc_QLKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DsKetQua);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_QLKetQua";
            this.Size = new System.Drawing.Size(865, 354);
            this.Load += new System.EventHandler(this.uc_QLKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsKetQua)).EndInit();
            this.pn_Nav.ResumeLayout(false);
            this.pn_Nav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgv_DsKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DsKetQua;
        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.Label lb_SoDiem;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private System.Windows.Forms.Label lb_MaSinhVien;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private System.Windows.Forms.Label lb_MaMonHoc;
        private System.Windows.Forms.TextBox txt_SoDiem;
        private System.Windows.Forms.ComboBox cbo_MaMonHoc;
        private System.Windows.Forms.ComboBox cbo_MaSinhVien;
    }
}
