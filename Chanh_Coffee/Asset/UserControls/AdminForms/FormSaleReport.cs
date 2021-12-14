using Chanh_Coffee.Controls;
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

namespace Chanh_Coffee.View.AdminForms
{
    public partial class FormSaleReport : UserControl
    {
        public FormSaleReport()
        {
            InitializeComponent();
            
        }

        
        private void btnGetStat_Click(object sender, EventArgs e)
        {
            dataGridViewStat.DataSource = BillDAO.Instance.GetBillListByDateRange(DateTimeStart.Value.ToString("yyyy-MM-dd"), DateTimeEnd.Value.ToString("yyyy-MM-dd"));
            
            
        }
    }
}
