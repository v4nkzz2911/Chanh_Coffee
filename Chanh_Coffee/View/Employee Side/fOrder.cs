using Chanh_Coffee.Asset.UserControls.OderForms;
using Chanh_Coffee.Controls;
using Chanh_Coffee.Models;
using Chanh_Coffee.View.Employee_Side;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            flowLayoutPanelFoodMenu.Controls.Clear();
            
            
        }

        void order_Click(object sender, EventArgs e)
        {
            ItemStandbyOrder t = new ItemStandbyOrder((sender as Button).Tag as Food);
            int id = ((sender as Button).Tag as Food).ID;
            t.Name = "OrderOf"+id.ToString();
            t.btnDown.Click += new EventHandler(calcTotalPay);
            t.btnUp.Click += new EventHandler(calcTotalPay);

            if (!flowLayoutPanelOrderList.Controls.ContainsKey(t.Name))
            {
                flowLayoutPanelOrderList.Controls.Add(t);
                calcTotalPay(sender, e);
            }
            
            

        }

        private void calcTotalPay(object sender, EventArgs e)
        {
            float pay = 0;
            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;
            foreach (Control t in controlsarr)
            {
                pay += Int32.Parse((t as ItemStandbyOrder).txtAmount.Text) * Int32.Parse((t as ItemStandbyOrder).itemPrice.Text);
                
            }
            this.LabelTotal.Text = pay.ToString("c",new CultureInfo("vi-VN"));
        }

        private void ButtonProccess_Click(object sender, EventArgs e)
        {
            fProcessOrder fPO = new fProcessOrder();
            fPO.ShowDialog();
        }

        #region handleFoodLoad
        
        

        private void btnTea_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnTea.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
                
            }
        }

        private void btnCake_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCake.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCoffee.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btnCanDrink_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCanDrink.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnPackages.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }
        #endregion

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;
            int i = 0;
            foreach (Control t in controlsarr)
            {
                if ((t as ItemStandbyOrder).orderSelect.Checked)
                {

                    flowLayoutPanelOrderList.Controls.Remove(t);
                    

                }
                
                    
                
            }

            
            calcTotalPay(sender,e);
        }

        private void ButtonNewOrder_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOrderList.Controls.Clear();
            calcTotalPay(sender, e);
            CustomerPayment.Value = 0;
            LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
        }

        private void ButtonCalculateChange_Click(object sender, EventArgs e)
        {
            string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);
            temp = temp.Replace(".", string.Empty);
            decimal changeMon =  CustomerPayment.Value - (decimal)Int32.Parse(temp);
            if (changeMon < 0)
            {
                MessageBox.Show("Tiền trả nhỏ hơn lượng cần thanh toán!");
                
            }
            else
            {
                LabelChange.Text = changeMon.ToString("c", new CultureInfo("vi-VN"));
            }
            
        }
    }
}
