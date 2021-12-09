using Chanh_Coffee.Control;
using Chanh_Coffee.Models;
using Chanh_Coffee.View.Employee_Side;
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
    public partial class fOrder : Form
    {
        public fOrder(Account session)
        {
            InitializeComponent();
            string currentSessionUserDisplay = AccountDAO.Instance.GetNameFromID(session.IdEmployee);
            txtSessionUser.Text = currentSessionUserDisplay;
        }

        private void formOrderPanel1_Load(object sender, EventArgs e)
        {
           
        }

        private void ButtonProccess_Click(object sender, EventArgs e)
        {
            fProcessOrder fPO = new fProcessOrder();
            fPO.ShowDialog();
        }
    }
}
