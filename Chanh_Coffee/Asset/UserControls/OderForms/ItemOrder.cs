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
    public partial class ItemOrder : UserControl
    {
        public ItemOrder(Food item)
        {
            InitializeComponent();
            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";
            itemImage.ImageLocation = filepath + item.Image;
            itemName.Text = item.Name;
            itemPrice.Text = item.Price.ToString();
        }

        private void btnAdd2_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.SeaGreen;
        }

        private void btnAdd2_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Gray;
        }
    }
}
