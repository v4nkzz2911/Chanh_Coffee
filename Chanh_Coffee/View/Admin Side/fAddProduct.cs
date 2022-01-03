using Chanh_Coffee.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chanh_Coffee.View.Admin_Side
{
    public partial class fAddProduct : Form
    {
        private string selectedImage;
        public fAddProduct()
        {
            InitializeComponent();
            cbType.DataSource = CategoryDAO.Instance.GetListCategory();
            cbType.DisplayMember = "GroupName";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";          
            File.Copy(selectedImage, filepath + Path.GetFileName(selectedImage));
            FoodDAO.Instance.InsertFood(txtName.Text, cbType.SelectedIndex + 1, (int)txtPrice.Value, Path.GetFileName(selectedImage));
            MessageBox.Show("Thêm thành công");
            this.Close();
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                itemImage.Image = new Bitmap(open.FileName);
                // image file path  
                itemImage.ImageLocation = open.FileName;
                selectedImage = open.FileName;

            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Value = 0;
            cbType.SelectedIndex = 0;
            itemImage.ImageLocation = "";
        }
    }
}
