namespace QLHS
{
    partial class uc_QLMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLMonHoc));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.txt_SoTiet = new System.Windows.Forms.NumericUpDown();
            this.lb_SoTiet = new System.Windows.Forms.Label();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenMonHoc = new System.Windows.Forms.TextBox();
            this.lb_TenMonHoc = new System.Windows.Forms.Label();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MaMonHoc = new System.Windows.Forms.TextBox();
            this.lb_MaMonHoc = new System.Windows.Forms.Label();
            this.dgv_DsMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gv_DsMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pn_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.txt_SoTiet);
            this.pn_Nav.Controls.Add(this.lb_SoTiet);
            this.pn_Nav.Controls.Add(this.btn_TimKiem);
            this.pn_Nav.Controls.Add(this.txt_TenMonHoc);
            this.pn_Nav.Controls.Add(this.lb_TenMonHoc);
            this.pn_Nav.Controls.Add(this.btn_CapNhat);
            this.pn_Nav.Controls.Add(this.txt_MaMonHoc);
            this.pn_Nav.Controls.Add(this.lb_MaMonHoc);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(216, 343);
            this.pn_Nav.TabIndex = 2;
            // 
            // txt_SoTiet
            // 
            this.txt_SoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoTiet.Location = new System.Drawing.Point(3, 145);
            this.txt_SoTiet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_SoTiet.Name = "txt_SoTiet";
            this.txt_SoTiet.Size = new System.Drawing.Size(59, 26);
            this.txt_SoTiet.TabIndex = 7;
            this.txt_SoTiet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_SoTiet
            // 
            this.lb_SoTiet.AutoSize = true;
            this.lb_SoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SoTiet.Location = new System.Drawing.Point(3, 122);
            this.lb_SoTiet.Name = "lb_SoTiet";
            this.lb_SoTiet.Size = new System.Drawing.Size(59, 20);
            this.lb_SoTiet.TabIndex = 6;
            this.lb_SoTiet.Text = "Số Tiết";
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
            // txt_TenMonHoc
            // 
            this.txt_TenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenMonHoc.Location = new System.Drawing.Point(3, 93);
            this.txt_TenMonHoc.Name = "txt_TenMonHoc";
            this.txt_TenMonHoc.Size = new System.Drawing.Size(207, 26);
            this.txt_TenMonHoc.TabIndex = 4;
            // 
            // lb_TenMonHoc
            // 
            this.lb_TenMonHoc.AutoSize = true;
            this.lb_TenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenMonHoc.Location = new System.Drawing.Point(3, 70);
            this.lb_TenMonHoc.Name = "lb_TenMonHoc";
            this.lb_TenMonHoc.Size = new System.Drawing.Size(104, 20);
            this.lb_TenMonHoc.TabIndex = 3;
            this.lb_TenMonHoc.Text = "Tên Môn Học";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(101, 190);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(109, 36);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_MaMonHoc
            // 
            this.txt_MaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaMonHoc.Location = new System.Drawing.Point(3, 41);
            this.txt_MaMonHoc.Name = "txt_MaMonHoc";
            this.txt_MaMonHoc.Size = new System.Drawing.Size(161, 26);
            this.txt_MaMonHoc.TabIndex = 1;
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
            // dgv_DsMonHoc
            // 
            this.dgv_DsMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgv_DsMonHoc.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_DsMonHoc.Location = new System.Drawing.Point(216, 0);
            this.dgv_DsMonHoc.MainView = this.gv_DsMonHoc;
            this.dgv_DsMonHoc.Name = "dgv_DsMonHoc";
            this.dgv_DsMonHoc.Size = new System.Drawing.Size(617, 343);
            this.dgv_DsMonHoc.TabIndex = 3;
            this.dgv_DsMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DsMonHoc});
            // 
            // gv_DsMonHoc
            // 
            this.gv_DsMonHoc.GridControl = this.dgv_DsMonHoc;
            this.gv_DsMonHoc.Name = "gv_DsMonHoc";
            this.gv_DsMonHoc.OptionsBehavior.ReadOnly = true;
            this.gv_DsMonHoc.OptionsCustomization.AllowColumnMoving = false;
            this.gv_DsMonHoc.OptionsPrint.AutoWidth = false;
            this.gv_DsMonHoc.OptionsView.ColumnAutoWidth = false;
            // 
            // uc_QLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DsMonHoc);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_QLMonHoc";
            this.Size = new System.Drawing.Size(833, 343);
            this.Load += new System.EventHandler(this.uc_QLMonHoc_Load);
            this.pn_Nav.ResumeLayout(false);
            this.pn_Nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Nav;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TenMonHoc;
        private System.Windows.Forms.Label lb_TenMonHoc;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private System.Windows.Forms.TextBox txt_MaMonHoc;
        private System.Windows.Forms.Label lb_MaMonHoc;
        private DevExpress.XtraGrid.GridControl dgv_DsMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DsMonHoc;
        private System.Windows.Forms.Label lb_SoTiet;
        private System.Windows.Forms.NumericUpDown txt_SoTiet;
    }
}
