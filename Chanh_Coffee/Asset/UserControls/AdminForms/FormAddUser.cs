﻿using System;
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
    public partial class FormAddUser : UserControl
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
