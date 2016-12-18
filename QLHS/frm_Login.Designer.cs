namespace QLHS
{
    partial class frm_Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pic_LogIn = new System.Windows.Forms.PictureBox();
            this.pic_Pass = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_Password.Location = new System.Drawing.Point(140, 91);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(229, 38);
            this.txt_Password.TabIndex = 13;
            // 
            // txt_Account
            // 
            this.txt_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_Account.Location = new System.Drawing.Point(140, 22);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(229, 38);
            this.txt_Account.TabIndex = 12;
            // 
            // pic_Exit
            // 
            this.pic_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_Exit.Image")));
            this.pic_Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_Exit.Location = new System.Drawing.Point(262, 158);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(107, 40);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Exit.TabIndex = 17;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.MouseLeave += new System.EventHandler(this.pic_Exit_MouseLeave);
            this.pic_Exit.MouseHover += new System.EventHandler(this.pic_Exit_MouseHover);
            // 
            // pic_LogIn
            // 
            this.pic_LogIn.Image = global::QLHS.Properties.Resources.dangnhap1;
            this.pic_LogIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_LogIn.Location = new System.Drawing.Point(7, 158);
            this.pic_LogIn.Name = "pic_LogIn";
            this.pic_LogIn.Size = new System.Drawing.Size(110, 40);
            this.pic_LogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_LogIn.TabIndex = 16;
            this.pic_LogIn.TabStop = false;
            this.pic_LogIn.Click += new System.EventHandler(this.pic_LogIn_Click);
            this.pic_LogIn.MouseLeave += new System.EventHandler(this.pic_LogIn_MouseLeave);
            this.pic_LogIn.MouseHover += new System.EventHandler(this.pic_LogIn_MouseHover);
            // 
            // pic_Pass
            // 
            this.pic_Pass.Image = ((System.Drawing.Image)(resources.GetObject("pic_Pass.Image")));
            this.pic_Pass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_Pass.Location = new System.Drawing.Point(7, 98);
            this.pic_Pass.Name = "pic_Pass";
            this.pic_Pass.Size = new System.Drawing.Size(119, 23);
            this.pic_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Pass.TabIndex = 15;
            this.pic_Pass.TabStop = false;
            // 
            // pic_Account
            // 
            this.pic_Account.Image = ((System.Drawing.Image)(resources.GetObject("pic_Account.Image")));
            this.pic_Account.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_Account.Location = new System.Drawing.Point(37, 11);
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.Size = new System.Drawing.Size(59, 53);
            this.pic_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Account.TabIndex = 14;
            this.pic_Account.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 211);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.pic_LogIn);
            this.Controls.Add(this.pic_Pass);
            this.Controls.Add(this.pic_Account);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Account);
            this.Name = "frm_Login";
            this.Text = "frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Exit;
        private System.Windows.Forms.PictureBox pic_LogIn;
        private System.Windows.Forms.PictureBox pic_Pass;
        private System.Windows.Forms.PictureBox pic_Account;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Account;
    }
}