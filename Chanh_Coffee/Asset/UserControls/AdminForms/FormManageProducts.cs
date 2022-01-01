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
    public partial class FormManageProducts : UserControl
    {
        public FormManageProducts()
        {
            InitializeComponent();
            flowLayoutPanelFoodList.Controls.Clear();
            loadAllFood();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            fAddProduct f = new fAddProduct();
            f.ShowDialog();
        }

        private void UpdateAction(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            loadAllFood();
        }

        void loadAllFood()
        {
            List<Food> AllFood = FoodDAO.Instance.GetListFood();
            foreach (Food item in AllFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);
                
            }
        }

        #region HandleFoodLoad
        private void btnTea_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnTea.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                flowLayoutPanelFoodList.Controls.Add(t);                       
            }
        }

        private void btnCake_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCake.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                flowLayoutPanelFoodList.Controls.Add(t);
            }
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCafe.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                flowLayoutPanelFoodList.Controls.Add(t);
            }
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnDrink.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                flowLayoutPanelFoodList.Controls.Add(t);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            loadAllFood();
        }

        #endregion
    }
}
