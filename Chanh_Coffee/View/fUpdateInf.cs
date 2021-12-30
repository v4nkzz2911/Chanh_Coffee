using Chanh_Coffee.Controls;
using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chanh_Coffee.View
{
    public partial class fUpdateInf : Form
    {
        private Account currentAccount;
        private User currentUser;
        public fUpdateInf(Account item)
        {
            InitializeComponent();
            currentAccount = item;
            currentUser = UserDAO.Instance.GetUserByID(currentAccount.IdEmployee);

            txtName.Text = currentUser.Name;
            txtPhone.Text = currentUser.Phone;
            txtAdd.Text = currentUser.Add;
            txtEmail.Text = currentUser.Email;
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            fChangePassword fCP = new fChangePassword(currentAccount);
            fCP.ShowDialog();
        }
    }
}
