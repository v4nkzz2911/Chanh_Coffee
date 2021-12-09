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
    public partial class FormManageProducts : UserControl
    {
        public FormManageProducts()
        {
            InitializeComponent();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            fAddProduct f = new fAddProduct();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
