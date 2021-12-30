
namespace Chanh_Coffee.View.AdminForms
{
    partial class FormUsers
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
            this.flowLayoutPanelUserList = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelUserList
            // 
            this.flowLayoutPanelUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelUserList.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelUserList.Location = new System.Drawing.Point(34, 72);
            this.flowLayoutPanelUserList.Name = "flowLayoutPanelUserList";
            this.flowLayoutPanelUserList.Size = new System.Drawing.Size(878, 428);
            this.flowLayoutPanelUserList.TabIndex = 18;
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddUser.CheckedState.Parent = this.ButtonAddUser;
            this.ButtonAddUser.CustomImages.Parent = this.ButtonAddUser;
            this.ButtonAddUser.DisabledState.Parent = this.ButtonAddUser;
            this.ButtonAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonAddUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonAddUser.ForeColor = System.Drawing.Color.White;
            this.ButtonAddUser.HoverState.Parent = this.ButtonAddUser;
            this.ButtonAddUser.Location = new System.Drawing.Point(34, 526);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.ShadowDecoration.Parent = this.ButtonAddUser;
            this.ButtonAddUser.Size = new System.Drawing.Size(180, 45);
            this.ButtonAddUser.TabIndex = 17;
            this.ButtonAddUser.Text = "Thêm người dùng mới";
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách người dùng";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanelUserList);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.label1);
            this.Name = "FormUsers";
            this.Size = new System.Drawing.Size(929, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserList;
        private Guna.UI2.WinForms.Guna2Button ButtonAddUser;
        private System.Windows.Forms.Label label1;
    }
}
