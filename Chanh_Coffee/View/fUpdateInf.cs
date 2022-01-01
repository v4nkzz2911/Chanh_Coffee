using Chanh_Coffee.Controls;
using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chanh_Coffee.View
{
    public partial class fUpdateInf : Form
    {
        private Account currentAccount;
        private User currentUser;
        public fUpdateInf(Account item)
        {
            InitializeComponent();
            currentAccount = item;
            currentUser = UserDAO.Instance.GetUserByID(currentAccount.IdEmployee);

            txtMNV.Text = currentUser.IdEmp;
            txtName.Text = currentUser.Name;
            txtGender.Text = currentUser.Gender;
            txtAdd.Text = currentUser.Add;
            txtPhone.Text = currentUser.Phone;        
            txtEmail.Text = currentUser.Email;
            txtSalary.Text = currentUser.Salary.ToString();
            dateTimePickerStart.Value = currentUser.Start;
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "dd/MM/yyyy";
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            fChangePassword fCP = new fChangePassword(currentAccount);
            fCP.ShowDialog();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                UserDAO.Instance.UpdateInfor(txtMNV.Text, txtName.Text, txtGender.Text, txtAdd.Text, txtPhone.Text, txtEmail.Text, Int32.Parse(txtSalary.Text), dateTimePickerStart.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Cập nhật thành công");
            }
            
            this.Close();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            txtMNV.Text = currentUser.IdEmp;
            txtName.Text = currentUser.Name;
            txtGender.Text = currentUser.Gender;
            txtAdd.Text = currentUser.Add;
            txtPhone.Text = currentUser.Phone;
            txtEmail.Text = currentUser.Email;
            txtSalary.Text = currentUser.Salary.ToString();
            dateTimePickerStart.Value = currentUser.Start;
        }
    }
}
