using Chanh_Coffee.Control;
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

namespace Chanh_Coffee.View.Admin_Side
{
    public partial class fAdminPanel : Form
    {
        public fAdminPanel(Account session)
        {
            InitializeComponent();
            HideAllSubContent();
            
            string currentSessionUserDisplay = AccountDAO.Instance.GetNameFromID(session.IdEmployee);
            txtSessionUser.Text = currentSessionUserDisplay;
            
            
            
        }

        private void HideAllSubContent()
        {
            formSaleReport1.Hide();
            formManageProducts1.Hide();
            formUsers1.Hide();
            formTransactions1.Hide();
            formProductArchive1.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSales_Click(object sender, EventArgs e)
        {
            HideAllSubContent();
            formSaleReport1.Show();
        }

        private void ButtonManageProduct_Click(object sender, EventArgs e)
        {
            HideAllSubContent();
            formManageProducts1.Show();
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            HideAllSubContent();
            formUsers1.Show();
        }

        private void ButtonTransaction_Click(object sender, EventArgs e)
        {
            HideAllSubContent();
            formTransactions1.Show();
        }

        private void ButtonArchives_Click(object sender, EventArgs e)
        {
            HideAllSubContent();
            formProductArchive1.Show();
        }
    }
}
