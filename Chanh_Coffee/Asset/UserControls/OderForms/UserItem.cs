using Chanh_Coffee.Models;
using Chanh_Coffee.View;
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
    public partial class UserItem : UserControl
    {
        private Account current;
        public UserItem(Account item)
        {
            InitializeComponent();
            current = item;
            itemUserName.Text = item.UserName;
            itemType.Text = item.Type;

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            fUpdateInf fUI = new fUpdateInf(current);
            fUI.ShowDialog();
        }
    }
}
