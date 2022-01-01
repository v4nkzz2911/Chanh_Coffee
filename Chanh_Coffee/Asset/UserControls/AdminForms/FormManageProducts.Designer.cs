
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
            this.ButtonsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnDrink = new Guna.UI2.WinForms.Guna2Button();
            this.btnPackages = new Guna.UI2.WinForms.Guna2Button();
            this.btnCafe = new Guna.UI2.WinForms.Guna2Button();
            this.btnTea = new Guna.UI2.WinForms.Guna2Button();
            this.btnCake = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelFoodList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2Button();
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
            this.ButtonsMenu.Controls.Add(this.btnDrink, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnPackages, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnCafe, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnTea, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnCake, 0, 0);
            this.ButtonsMenu.Location = new System.Drawing.Point(42, 78);
            this.ButtonsMenu.Name = "ButtonsMenu";
            this.ButtonsMenu.RowCount = 1;
            this.ButtonsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsMenu.Size = new System.Drawing.Size(758, 60);
            this.ButtonsMenu.TabIndex = 11;
            // 
            // btnDrink
            // 
            this.btnDrink.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDrink.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnDrink.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDrink.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDrink.CheckedState.Parent = this.btnDrink;
            this.btnDrink.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnDrink.CustomImages.Parent = this.btnDrink;
            this.btnDrink.DisabledState.Parent = this.btnDrink;
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDrink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDrink.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDrink.HoverState.Parent = this.btnDrink;
            this.btnDrink.Location = new System.Drawing.Point(453, 0);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.ShadowDecoration.Parent = this.btnDrink;
            this.btnDrink.Size = new System.Drawing.Size(151, 60);
            this.btnDrink.TabIndex = 5;
            this.btnDrink.Tag = "Dessert";
            this.btnDrink.Text = "Nước uống";
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPackages.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnPackages.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPackages.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPackages.CheckedState.Parent = this.btnPackages;
            this.btnPackages.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnPackages.CustomImages.Parent = this.btnPackages;
            this.btnPackages.DisabledState.Parent = this.btnPackages;
            this.btnPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPackages.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPackages.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPackages.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPackages.HoverState.Parent = this.btnPackages;
            this.btnPackages.Location = new System.Drawing.Point(604, 0);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(0);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.ShadowDecoration.Parent = this.btnPackages;
            this.btnPackages.Size = new System.Drawing.Size(154, 60);
            this.btnPackages.TabIndex = 4;
            this.btnPackages.Tag = "Smoothies";
            this.btnPackages.Text = "Packages";
            // 
            // btnCafe
            // 
            this.btnCafe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCafe.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCafe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCafe.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCafe.CheckedState.Parent = this.btnCafe;
            this.btnCafe.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCafe.CustomImages.Parent = this.btnCafe;
            this.btnCafe.DisabledState.Parent = this.btnCafe;
            this.btnCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCafe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCafe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCafe.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCafe.HoverState.Parent = this.btnCafe;
            this.btnCafe.Location = new System.Drawing.Point(302, 0);
            this.btnCafe.Margin = new System.Windows.Forms.Padding(0);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.ShadowDecoration.Parent = this.btnCafe;
            this.btnCafe.Size = new System.Drawing.Size(151, 60);
            this.btnCafe.TabIndex = 3;
            this.btnCafe.Tag = "Drinks";
            this.btnCafe.Text = "Cafe";
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // btnTea
            // 
            this.btnTea.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTea.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnTea.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTea.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnTea.CheckedState.Parent = this.btnTea;
            this.btnTea.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnTea.CustomImages.Parent = this.btnTea;
            this.btnTea.DisabledState.Parent = this.btnTea;
            this.btnTea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTea.ForeColor = System.Drawing.Color.DarkGray;
            this.btnTea.HoverState.Parent = this.btnTea;
            this.btnTea.Location = new System.Drawing.Point(0, 0);
            this.btnTea.Margin = new System.Windows.Forms.Padding(0);
            this.btnTea.Name = "btnTea";
            this.btnTea.ShadowDecoration.Parent = this.btnTea;
            this.btnTea.Size = new System.Drawing.Size(151, 60);
            this.btnTea.TabIndex = 2;
            this.btnTea.Tag = "Coffee";
            this.btnTea.Text = "Trà";
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // btnCake
            // 
            this.btnCake.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCake.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCake.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCake.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCake.CheckedState.Parent = this.btnCake;
            this.btnCake.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCake.CustomImages.Parent = this.btnCake;
            this.btnCake.DisabledState.Parent = this.btnCake;
            this.btnCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCake.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCake.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCake.HoverState.Parent = this.btnCake;
            this.btnCake.Location = new System.Drawing.Point(151, 0);
            this.btnCake.Margin = new System.Windows.Forms.Padding(0);
            this.btnCake.Name = "btnCake";
            this.btnCake.ShadowDecoration.Parent = this.btnCake;
            this.btnCake.Size = new System.Drawing.Size(151, 60);
            this.btnCake.TabIndex = 1;
            this.btnCake.Tag = "MilkTea";
            this.btnCake.Text = "Bánh ngọt";
            this.btnCake.Click += new System.EventHandler(this.btnCake_Click);
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
            // 
            // flowLayoutPanelFoodList
            // 
            this.flowLayoutPanelFoodList.AutoScroll = true;
            this.flowLayoutPanelFoodList.Location = new System.Drawing.Point(41, 212);
            this.flowLayoutPanelFoodList.Name = "flowLayoutPanelFoodList";
            this.flowLayoutPanelFoodList.Size = new System.Drawing.Size(793, 295);
            this.flowLayoutPanelFoodList.TabIndex = 15;
            // 
            // btnShowAll
            // 
            this.btnShowAll.AutoRoundedCorners = true;
            this.btnShowAll.BorderRadius = 19;
            this.btnShowAll.CheckedState.Parent = this.btnShowAll;
            this.btnShowAll.CustomImages.Parent = this.btnShowAll;
            this.btnShowAll.DisabledState.Parent = this.btnShowAll;
            this.btnShowAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.HoverState.Parent = this.btnShowAll;
            this.btnShowAll.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnShowAll.Location = new System.Drawing.Point(232, 153);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.ShadowDecoration.Parent = this.btnShowAll;
            this.btnShowAll.Size = new System.Drawing.Size(161, 40);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "Tất cả món";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // FormManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.flowLayoutPanelFoodList);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.ButtonsMenu);
            this.Controls.Add(this.label1);
            this.Name = "FormManageProducts";
            this.Size = new System.Drawing.Size(837, 535);
            this.ButtonsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonAddProduct;
        private Guna.UI2.WinForms.Guna2TextBox TextSearch;
        private System.Windows.Forms.TableLayoutPanel ButtonsMenu;
        private Guna.UI2.WinForms.Guna2Button btnDrink;
        private Guna.UI2.WinForms.Guna2Button btnPackages;
        private Guna.UI2.WinForms.Guna2Button btnCafe;
        private Guna.UI2.WinForms.Guna2Button btnTea;
        private Guna.UI2.WinForms.Guna2Button btnCake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFoodList;
        private Guna.UI2.WinForms.Guna2Button btnShowAll;
    }
}
