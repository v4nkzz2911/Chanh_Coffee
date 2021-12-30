using Chanh_Coffee.Asset.UserControls.OderForms;
using Chanh_Coffee.Controls;
using Chanh_Coffee.Models;
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

namespace Chanh_Coffee.View.AdminForms
{
    public partial class FormUsers : UserControl
    {
        
        public FormUsers()
        {
            InitializeComponent();
            flowLayoutPanelUserList.Controls.Clear();
            loadAllUser();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            fAddNewUser fANU = new fAddNewUser();
            fANU.ShowDialog();
        }


        void loadAllUser()
        {
            List<Account> AllUser = AccountDAO.Instance.GetListAccount();
            foreach (Account item in AllUser)
            {
                UserItem t = new UserItem(item);
                flowLayoutPanelUserList.Controls.Add(t);


            }
        }


        private void loadListUser(object sender, EventArgs e)
        {

        }
    }
}
