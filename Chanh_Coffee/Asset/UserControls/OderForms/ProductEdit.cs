﻿using Chanh_Coffee.Controls;
using Chanh_Coffee.Models;
using Chanh_Coffee.View.Admin_Side;
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

namespace Chanh_Coffee.Asset.UserControls.OderForms
{
    public partial class ProductEdit : UserControl
    {
        private Food current;
        public ProductEdit(Food item)
        {
            InitializeComponent();
            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";
            itemImage.ImageLocation = filepath + item.Image;
            itemName.Text = item.Name;
            itemPrice.Text = item.Price.ToString();
            current = item;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fUpdateProduct fUP = new fUpdateProduct(current);
            fUP.ShowDialog();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                FoodDAO.Instance.RemoveFood(current.ID.ToString());

                string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";

                if (File.Exists(filepath + current.Image))
                {
                    File.Delete(filepath + current.Image);
                }

                MessageBox.Show("Xóa thành công");
            }
        }
    }
}
