using Chanh_Coffee.Asset.UserControls.OderForms;
using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Chanh_Coffee.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";

            load();

        }

        void load()
        {
            ItemOrder t = new ItemOrder(new Food(1, "Trà sữa", 1, 120000, "Tra_sua.jpg"));
            flowLayoutPanel1.Controls.Add(t);

            ItemOrder t1 = new ItemOrder(new Food(1, "Trà", 1, 140000, "Tra_sua.jpg"));
            flowLayoutPanel1.Controls.Add(t1);
            t1.btnAdd.Click += new EventHandler(order_Click);
        }

        void order_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Thêm thành công");
           
        }
    }
}
