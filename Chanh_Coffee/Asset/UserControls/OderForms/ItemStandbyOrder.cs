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

namespace Chanh_Coffee.Asset.UserControls.OderForms
{
    public partial class ItemStandbyOrder : UserControl
    {
        public ItemStandbyOrder(Food item)
        {
            InitializeComponent();
            itemName.Text = item.Name;
            itemPrice.Text = item.Price.ToString();

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string t = txtAmount.Text;
            if (Int32.Parse(t)>0)
            {
                
                txtAmount.Text = (Int32.Parse(t) - 1).ToString();
            }
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string t = txtAmount.Text;
            txtAmount.Text = (Int32.Parse(t) + 1).ToString();
        }
    }
}
