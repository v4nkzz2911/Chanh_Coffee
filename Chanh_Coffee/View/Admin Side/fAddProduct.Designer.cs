
namespace Chanh_Coffee.View.Admin_Side
{
    partial class fAddProduct
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
            this.formAddProduct1 = new Chanh_Coffee.View.AdminForms.FormAddProduct();
            this.SuspendLayout();
            // 
            // formAddProduct1
            // 
            this.formAddProduct1.BackColor = System.Drawing.Color.White;
            this.formAddProduct1.Location = new System.Drawing.Point(2, 2);
            this.formAddProduct1.Name = "formAddProduct1";
            this.formAddProduct1.Size = new System.Drawing.Size(798, 552);
            this.formAddProduct1.TabIndex = 0;
            // 
            // fAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 557);
            this.Controls.Add(this.formAddProduct1);
            this.Name = "fAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món ";
            this.ResumeLayout(false);

        }

        #endregion

        private AdminForms.FormAddProduct formAddProduct1;
    }
}