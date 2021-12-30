
namespace Chanh_Coffee.Asset.UserControls.OderForms
{
    partial class UserItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserItem));
            this.itemPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.itemUserName = new System.Windows.Forms.Label();
            this.itemType = new System.Windows.Forms.Label();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPicture
            // 
            this.itemPicture.FillColor = System.Drawing.Color.Silver;
            this.itemPicture.ImageRotate = 0F;
            this.itemPicture.Location = new System.Drawing.Point(19, 10);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.itemPicture.ShadowDecoration.Parent = this.itemPicture;
            this.itemPicture.Size = new System.Drawing.Size(40, 40);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPicture.TabIndex = 12;
            this.itemPicture.TabStop = false;
            // 
            // itemUserName
            // 
            this.itemUserName.AutoSize = true;
            this.itemUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemUserName.Location = new System.Drawing.Point(65, 10);
            this.itemUserName.Name = "itemUserName";
            this.itemUserName.Size = new System.Drawing.Size(111, 21);
            this.itemUserName.TabIndex = 7;
            this.itemUserName.Text = "Tên đăng nhập";
            // 
            // itemType
            // 
            this.itemType.AutoSize = true;
            this.itemType.ForeColor = System.Drawing.Color.Gray;
            this.itemType.Location = new System.Drawing.Point(66, 37);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(47, 13);
            this.itemType.TabIndex = 13;
            this.itemType.Text = "Chức vụ";
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonRemove.Animated = true;
            this.ButtonRemove.AutoRoundedCorners = true;
            this.ButtonRemove.BorderRadius = 14;
            this.ButtonRemove.CheckedState.Parent = this.ButtonRemove;
            this.ButtonRemove.CustomImages.Parent = this.ButtonRemove;
            this.ButtonRemove.DisabledState.Parent = this.ButtonRemove;
            this.ButtonRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.HoverState.Parent = this.ButtonRemove;
            this.ButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRemove.Image")));
            this.ButtonRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonRemove.ImageSize = new System.Drawing.Size(12, 12);
            this.ButtonRemove.Location = new System.Drawing.Point(588, 16);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Parent = this.ButtonRemove;
            this.ButtonRemove.Size = new System.Drawing.Size(30, 30);
            this.ButtonRemove.TabIndex = 9;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdate.CheckedState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.CustomImages.Parent = this.ButtonUpdate;
            this.ButtonUpdate.DisabledState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.HoverState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate.Image")));
            this.ButtonUpdate.ImageOffset = new System.Drawing.Point(1, 0);
            this.ButtonUpdate.ImageSize = new System.Drawing.Size(15, 15);
            this.ButtonUpdate.Location = new System.Drawing.Point(554, 16);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonUpdate.ShadowDecoration.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Size = new System.Drawing.Size(30, 30);
            this.ButtonUpdate.TabIndex = 11;
            this.ButtonUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // UserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.itemPicture);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.itemUserName);
            this.Name = "UserItem";
            this.Size = new System.Drawing.Size(637, 61);
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox itemPicture;
        private System.Windows.Forms.Label itemUserName;
        private System.Windows.Forms.Label itemType;
        private Guna.UI2.WinForms.Guna2Button ButtonRemove;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonUpdate;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}
