using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void pic_LogIn_MouseHover(object sender, EventArgs e)
        {
            pic_LogIn.Image = Properties.Resources.dangnhap2;
        }
        private void pic_LogIn_MouseLeave(object sender, EventArgs e)
        {
            pic_LogIn.Image = Properties.Resources.dangnhap1;
        }

        private void pic_Exit_MouseHover(object sender, EventArgs e)
        {
            pic_Exit.Image = Properties.Resources.thoat2;
        }
        private void pic_Exit_MouseLeave(object sender, EventArgs e)
        {
            pic_Exit.Image = Properties.Resources.thoat1;
        }
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_LogIn_Click(object sender, EventArgs e)
        {
            if ((txt_Account.Text == "admin") & (txt_Password.Text == "admin"))
            {
                Form1 main = new Form1(true);
                main.Show();
                this.Hide();
            }
            if ((txt_Account.Text == "user") & (txt_Password.Text == "user"))
            {
                Form1 main = new Form1(false);
                main.Show();
                this.Hide();
            }
        }
    }
}
