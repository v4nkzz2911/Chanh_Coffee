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

namespace Chanh_Coffee.Asset.UserControls.AdminForms
{
    public partial class FormPromotion : UserControl
    {
        public FormPromotion()
        {
            InitializeComponent();
            flowLayoutPanelPromotion.Controls.Clear();
            LoadAllPromo();
        }

        private void ReloadAction(object sender, EventArgs e)
        {
            flowLayoutPanelPromotion.Controls.Clear();
            LoadAllPromo();
        }

        private void LoadAllPromo()
        {
            List<Promotion> listPromo = PromotionDAO.Instance.GetListPromotion();
            foreach(Promotion item in listPromo)
            {
                PromotionItem t = new PromotionItem(item);
                flowLayoutPanelPromotion.Controls.Add(t);
                t.ButtonUpdate.Click += new EventHandler(ReloadAction);
                t.ButtonRemove.Click += new EventHandler(ReloadAction);
            }
        }

        private void ButtonAddPromo_Click(object sender, EventArgs e)
        {
            fAddPromo fAP = new fAddPromo();
            fAP.ButtonSave.Click += new EventHandler(ReloadAction);
            fAP.ShowDialog();
        }
    }
}
