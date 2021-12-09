
namespace Chanh_Coffee.View.Admin_Side
{
    partial class fAddNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formAddUser1 = new Chanh_Coffee.View.AdminForms.FormAddUser();
            this.SuspendLayout();
            // 
            // formAddUser1
            // 
            this.formAddUser1.BackColor = System.Drawing.Color.White;
            this.formAddUser1.Location = new System.Drawing.Point(3, 2);
            this.formAddUser1.Name = "formAddUser1";
            this.formAddUser1.Size = new System.Drawing.Size(862, 671);
            this.formAddUser1.TabIndex = 0;
            this.formAddUser1.Load += new System.EventHandler(this.formAddUser1_Load);
            // 
            // fAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 653);
            this.Controls.Add(this.formAddUser1);
            this.Name = "fAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng";
            this.ResumeLayout(false);

        }

        #endregion

        private AdminForms.FormAddUser formAddUser1;
    }
}