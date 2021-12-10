
namespace Chanh_Coffee.Asset.UserControls.OderForms
{
    partial class ItemStandbyOrder
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
            this.itemName = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDown = new Guna.UI2.WinForms.Guna2Button();
            this.btnUp = new Guna.UI2.WinForms.Guna2Button();
            this.txtAmount = new System.Windows.Forms.Label();
            this.orderSelect = new System.Windows.Forms.CheckBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(3, 14);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(155, 30);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "Customer Oder";
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.Green;
            this.itemPrice.Location = new System.Drawing.Point(309, 11);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(87, 33);
            this.itemPrice.TabIndex = 3;
            this.itemPrice.Text = "gia";
            this.itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnDown);
            this.guna2Panel1.Controls.Add(this.btnUp);
            this.guna2Panel1.Controls.Add(this.txtAmount);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(185, 13);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(118, 31);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDown
            // 
            this.btnDown.CheckedState.Parent = this.btnDown;
            this.btnDown.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnDown.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnDown.CustomImages.Parent = this.btnDown;
            this.btnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDown.DisabledState.Parent = this.btnDown;
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDown.FillColor = System.Drawing.Color.White;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.Black;
            this.btnDown.HoverState.Parent = this.btnDown;
            this.btnDown.Location = new System.Drawing.Point(0, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.ShadowDecoration.Parent = this.btnDown;
            this.btnDown.Size = new System.Drawing.Size(37, 31);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "-";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.CheckedState.Parent = this.btnUp;
            this.btnUp.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnUp.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnUp.CustomImages.Parent = this.btnUp;
            this.btnUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUp.DisabledState.Parent = this.btnUp;
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUp.FillColor = System.Drawing.Color.White;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.Black;
            this.btnUp.HoverState.Parent = this.btnUp;
            this.btnUp.Location = new System.Drawing.Point(81, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.ShadowDecoration.Parent = this.btnUp;
            this.btnUp.Size = new System.Drawing.Size(37, 31);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "+";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(0, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(118, 31);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "1";
            this.txtAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderSelect
            // 
            this.orderSelect.AutoSize = true;
            this.orderSelect.Location = new System.Drawing.Point(164, 25);
            this.orderSelect.Name = "orderSelect";
            this.orderSelect.Size = new System.Drawing.Size(15, 14);
            this.orderSelect.TabIndex = 4;
            this.orderSelect.UseVisualStyleBackColor = true;
            // 
            // ItemStandbyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderSelect);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.itemName);
            this.Name = "ItemStandbyOrder";
            this.Size = new System.Drawing.Size(399, 55);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label txtAmount;
        public System.Windows.Forms.Label itemPrice;
        public System.Windows.Forms.CheckBox orderSelect;
        public Guna.UI2.WinForms.Guna2Button btnDown;
        public Guna.UI2.WinForms.Guna2Button btnUp;
    }
}
