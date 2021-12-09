
namespace Chanh_Coffee.View.AdminForms
{
    partial class FormManageProducts
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
            this.ButtonAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.TextSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDesserts = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSmoothies = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDrinks = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCoffee = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonTea = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ButtonsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.AutoRoundedCorners = true;
            this.ButtonAddProduct.BorderRadius = 19;
            this.ButtonAddProduct.CheckedState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.CustomImages.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.DisabledState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonAddProduct.HoverState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonAddProduct.Location = new System.Drawing.Point(41, 153);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.ShadowDecoration.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.Size = new System.Drawing.Size(161, 40);
            this.ButtonAddProduct.TabIndex = 14;
            this.ButtonAddProduct.Text = "Thêm món";
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // TextSearch
            // 
            this.TextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSearch.Animated = true;
            this.TextSearch.AutoRoundedCorners = true;
            this.TextSearch.BorderRadius = 19;
            this.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextSearch.DefaultText = "";
            this.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.DisabledState.Parent = this.TextSearch;
            this.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.FocusedState.Parent = this.TextSearch;
            this.TextSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.HoverState.Parent = this.TextSearch;
            this.TextSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.TextSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextSearch.Location = new System.Drawing.Point(474, 153);
            this.TextSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.PasswordChar = '\0';
            this.TextSearch.PlaceholderText = "Tìm kiếm trong menu";
            this.TextSearch.SelectedText = "";
            this.TextSearch.ShadowDecoration.Parent = this.TextSearch;
            this.TextSearch.Size = new System.Drawing.Size(326, 40);
            this.TextSearch.TabIndex = 13;
            this.TextSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(42, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 298);
            this.panel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(735, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ButtonsMenu
            // 
            this.ButtonsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsMenu.ColumnCount = 5;
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.Controls.Add(this.ButtonDesserts, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonSmoothies, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonDrinks, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonCoffee, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonTea, 0, 0);
            this.ButtonsMenu.Location = new System.Drawing.Point(42, 78);
            this.ButtonsMenu.Name = "ButtonsMenu";
            this.ButtonsMenu.RowCount = 1;
            this.ButtonsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsMenu.Size = new System.Drawing.Size(758, 60);
            this.ButtonsMenu.TabIndex = 11;
            // 
            // ButtonDesserts
            // 
            this.ButtonDesserts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonDesserts.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonDesserts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonDesserts.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonDesserts.CheckedState.Parent = this.ButtonDesserts;
            this.ButtonDesserts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ButtonDesserts.CustomImages.Parent = this.ButtonDesserts;
            this.ButtonDesserts.DisabledState.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDesserts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonDesserts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDesserts.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonDesserts.HoverState.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Location = new System.Drawing.Point(453, 0);
            this.ButtonDesserts.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDesserts.Name = "ButtonDesserts";
            this.ButtonDesserts.ShadowDecoration.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Size = new System.Drawing.Size(151, 60);
            this.ButtonDesserts.TabIndex = 5;
            this.ButtonDesserts.Tag = "Dessert";
            this.ButtonDesserts.Text = "Desserts";
            // 
            // ButtonSmoothies
            // 
            this.ButtonSmoothies.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonSmoothies.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonSmoothies.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonSmoothies.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonSmoothies.CheckedState.Parent = this.ButtonSmoothies;
            this.ButtonSmoothies.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ButtonSmoothies.CustomImages.Parent = this.ButtonSmoothies;
            this.ButtonSmoothies.DisabledState.Parent = this.ButtonSmoothies;
            this.ButtonSmoothies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSmoothies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonSmoothies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSmoothies.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonSmoothies.HoverState.Parent = this.ButtonSmoothies;
            this.ButtonSmoothies.Location = new System.Drawing.Point(604, 0);
            this.ButtonSmoothies.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSmoothies.Name = "ButtonSmoothies";
            this.ButtonSmoothies.ShadowDecoration.Parent = this.ButtonSmoothies;
            this.ButtonSmoothies.Size = new System.Drawing.Size(154, 60);
            this.ButtonSmoothies.TabIndex = 4;
            this.ButtonSmoothies.Tag = "Smoothies";
            this.ButtonSmoothies.Text = "Smoothies";
            // 
            // ButtonDrinks
            // 
            this.ButtonDrinks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonDrinks.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonDrinks.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonDrinks.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonDrinks.CheckedState.Parent = this.ButtonDrinks;
            this.ButtonDrinks.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ButtonDrinks.CustomImages.Parent = this.ButtonDrinks;
            this.ButtonDrinks.DisabledState.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDrinks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonDrinks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDrinks.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonDrinks.HoverState.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Location = new System.Drawing.Point(302, 0);
            this.ButtonDrinks.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDrinks.Name = "ButtonDrinks";
            this.ButtonDrinks.ShadowDecoration.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Size = new System.Drawing.Size(151, 60);
            this.ButtonDrinks.TabIndex = 3;
            this.ButtonDrinks.Tag = "Drinks";
            this.ButtonDrinks.Text = "Drinks";
            // 
            // ButtonCoffee
            // 
            this.ButtonCoffee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonCoffee.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonCoffee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonCoffee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonCoffee.CheckedState.Parent = this.ButtonCoffee;
            this.ButtonCoffee.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ButtonCoffee.CustomImages.Parent = this.ButtonCoffee;
            this.ButtonCoffee.DisabledState.Parent = this.ButtonCoffee;
            this.ButtonCoffee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCoffee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonCoffee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCoffee.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonCoffee.HoverState.Parent = this.ButtonCoffee;
            this.ButtonCoffee.Location = new System.Drawing.Point(0, 0);
            this.ButtonCoffee.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCoffee.Name = "ButtonCoffee";
            this.ButtonCoffee.ShadowDecoration.Parent = this.ButtonCoffee;
            this.ButtonCoffee.Size = new System.Drawing.Size(151, 60);
            this.ButtonCoffee.TabIndex = 2;
            this.ButtonCoffee.Tag = "Coffee";
            this.ButtonCoffee.Text = "Coffee";
            // 
            // ButtonTea
            // 
            this.ButtonTea.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonTea.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonTea.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonTea.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonTea.CheckedState.Parent = this.ButtonTea;
            this.ButtonTea.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ButtonTea.CustomImages.Parent = this.ButtonTea;
            this.ButtonTea.DisabledState.Parent = this.ButtonTea;
            this.ButtonTea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonTea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonTea.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonTea.HoverState.Parent = this.ButtonTea;
            this.ButtonTea.Location = new System.Drawing.Point(151, 0);
            this.ButtonTea.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTea.Name = "ButtonTea";
            this.ButtonTea.ShadowDecoration.Parent = this.ButtonTea;
            this.ButtonTea.Size = new System.Drawing.Size(151, 60);
            this.ButtonTea.TabIndex = 1;
            this.ButtonTea.Tag = "MilkTea";
            this.ButtonTea.Text = "Milk Tea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý món";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonsMenu);
            this.Controls.Add(this.label1);
            this.Name = "FormManageProducts";
            this.Size = new System.Drawing.Size(837, 535);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ButtonsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonAddProduct;
        private Guna.UI2.WinForms.Guna2TextBox TextSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel ButtonsMenu;
        private Guna.UI2.WinForms.Guna2Button ButtonDesserts;
        private Guna.UI2.WinForms.Guna2Button ButtonSmoothies;
        private Guna.UI2.WinForms.Guna2Button ButtonDrinks;
        private Guna.UI2.WinForms.Guna2Button ButtonCoffee;
        private Guna.UI2.WinForms.Guna2Button ButtonTea;
        private System.Windows.Forms.Label label1;
    }
}
