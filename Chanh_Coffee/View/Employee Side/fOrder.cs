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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chanh_Coffee.View
{
    public partial class fOrder : Form
    {
        private Account CurrentSession;
        private List<Promotion> listPromo;

        public fOrder(Account session)
        {
            InitializeComponent();
            CurrentSession = session;
            string currentSessionUserDisplay = AccountDAO.Instance.GetNameFromID(CurrentSession.IdEmployee);
            txtSessionUser.Text = currentSessionUserDisplay;
            flowLayoutPanelFoodMenu.Controls.Clear();
            Thread.CurrentThread.CurrentCulture = (new CultureInfo("vi-VN"));

            listPromo = PromotionDAO.Instance.GetListPromotionAvailable();
            listPromo.Insert(0, new Promotion("Không", new DateTime(1990, 01, 01), new DateTime(1990, 01, 02), "Không áp dụng giảm giá", 0));
            cbxPromo.DataSource = listPromo;
            cbxPromo.DisplayMember = "idPromo";
            flowLayoutPanelFoodMenu.Controls.Clear();
            loadAllFood();

        }

        void loadAllFood()
        {
            List<Food> AllFood = FoodDAO.Instance.GetListFood();
            foreach (Food item in AllFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;

            }
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
            ButtonCalculateChange_Click(sender,e);
            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;
            if(controlsarr.Count ==0)
            {
                MessageBox.Show("Order trống!", "Thông báo", MessageBoxButtons.OKCancel);

            }
            else
            {
                if (MessageBox.Show("Bạn muốn thanh toán và xuất hoá đơn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);
                    temp = temp.Replace(".", string.Empty);
                    string discount = PromoAmount.Text.Replace("-", string.Empty);
                    decimal changeMon = CustomerPayment.Value - (decimal)Int32.Parse(temp) + (decimal)Int32.Parse(discount);
                    if (changeMon < 0)
                    {
                        MessageBox.Show("Tiền trả nhỏ hơn lượng cần thanh toán!");
                        LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
                    }
                    else
                    {
                        List<Order> listConfirmed = new List<Order>();

                        int price;
                        if((CustomerPayment.Value - changeMon) < 0){
                            price = 0;
                        }
                        else
                        {
                            price = Int32.Parse((CustomerPayment.Value - changeMon).ToString());
                        }
                        

                        BillDAO.Instance.InsertBill(CurrentSession.IdEmployee, listPromo[cbxPromo.SelectedIndex].IdPromo.ToString(), price);

                        foreach (Control t in controlsarr)
                        {
                            ItemStandbyOrder StandbyOrder = (t as ItemStandbyOrder);

                            BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), StandbyOrder.item.ID, Int32.Parse(StandbyOrder.txtAmount.Text));

                            listConfirmed.Add(new Order(StandbyOrder.item.Name, StandbyOrder.item.Price, Int32.Parse(StandbyOrder.txtAmount.Text)));

                        }


                        fProcessOrder fPO = new fProcessOrder(listConfirmed, CurrentSession.IdEmployee, CustomerPayment.Value.ToString("c", new CultureInfo("vi-VN")), LabelChange.Text.ToString(), BillDAO.Instance.GetTimebyIDBill(BillDAO.Instance.GetMaxIDBill()), PromoAmount.Text, listPromo[cbxPromo.SelectedIndex].IdPromo.ToString());
                        fPO.ShowDialog();

                    }
                }
            }
            
            
            
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
            cbxPromo.SelectedIndex = 0;
            flowLayoutPanelFoodMenu.Controls.Clear();
            loadAllFood();
        }

        private void ButtonCalculateChange_Click(object sender, EventArgs e)
        {
            string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);
            temp = temp.Replace(".", string.Empty);
            string discount = PromoAmount.Text.Replace("-", string.Empty);
            decimal changeMon =  CustomerPayment.Value - (decimal)Int32.Parse(temp) + (decimal)Int32.Parse(discount);
            if ((decimal)Int32.Parse(temp) < (decimal)Int32.Parse(discount))
            {
                LabelChange.Text = CustomerPayment.Value.ToString("c", new CultureInfo("vi-VN"));
                return;
            }
            if (changeMon < 0)
            {
                MessageBox.Show("Tiền trả nhỏ hơn lượng cần thanh toán!");
                LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
            }
            else
            {
                LabelChange.Text = changeMon.ToString("c", new CultureInfo("vi-VN"));
            }
            
        }

        private void cbxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PromoAmount.Text = "-"+ listPromo[cbxPromo.SelectedIndex].PricePromo.ToString();
            PromoDes.Text = listPromo[cbxPromo.SelectedIndex].Des.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fChangePassword fcp = new fChangePassword(CurrentSession);
            fcp.ShowDialog();

        }

        private void flowLayoutPanelFoodMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
