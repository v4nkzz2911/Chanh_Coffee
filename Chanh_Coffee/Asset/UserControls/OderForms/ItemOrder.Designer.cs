﻿
namespace Chanh_Coffee.Asset.UserControls.OderForms
{
    partial class ItemOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.itemPrice = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.itemImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.itemPrice);
            this.guna2Panel1.Controls.Add(this.itemName);
            this.guna2Panel1.Controls.Add(this.itemImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(265, 140);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(18, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd2_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd2_MouseHover);
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.Green;
            this.itemPrice.Location = new System.Drawing.Point(100, 62);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(100, 33);
            this.itemPrice.TabIndex = 2;
            this.itemPrice.Text = "giá";
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(98, 15);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(129, 47);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "tên";
            // 
            // itemImage
            // 
            this.itemImage.ImageRotate = 0F;
            this.itemImage.Location = new System.Drawing.Point(18, 15);
            this.itemImage.Name = "itemImage";
            this.itemImage.ShadowDecoration.Parent = this.itemImage;
            this.itemImage.Size = new System.Drawing.Size(70, 70);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage.TabIndex = 0;
            this.itemImage.TabStop = false;
            // 
            // ItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ItemOrder";
            this.Size = new System.Drawing.Size(265, 140);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label itemName;
        private Guna.UI2.WinForms.Guna2PictureBox itemImage;
        private System.Windows.Forms.Label itemPrice;
        public System.Windows.Forms.Button btnAdd;
    }
}
