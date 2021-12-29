
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
            this.ButtonAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
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
            this.ButtonAddUser.Location = new System.Drawing.Point(42, 455);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.ShadowDecoration.Parent = this.ButtonAddUser;
            this.ButtonAddUser.Size = new System.Drawing.Size(180, 45);
            this.ButtonAddUser.TabIndex = 11;
            this.ButtonAddUser.Text = "Thêm người dùng mới";
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh sách người dùng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(42, 75);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(651, 374);
            this.dataGridViewUser.TabIndex = 12;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.label1);
            this.Name = "FormUsers";
            this.Size = new System.Drawing.Size(731, 528);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ButtonAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUser;
    }
}
