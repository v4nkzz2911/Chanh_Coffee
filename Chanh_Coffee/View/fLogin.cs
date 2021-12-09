using Chanh_Coffee.Control;
using Chanh_Coffee.Models;
using Chanh_Coffee.View;
using Chanh_Coffee.View.Admin_Side;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chanh_Coffee
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            
            if (Login(userName, passWord))
            {
                Account session = AccountDAO.Instance.GetAccountByUserName(userName);
                if (session.Type.Equals("NhanVien"))
                {
                    fOrder f = new fOrder(session);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fAdminPanel f = new fAdminPanel(session);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName,passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
