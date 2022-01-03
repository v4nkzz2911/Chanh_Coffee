
namespace Chanh_Coffee.Asset.UserControls.AdminForms
{
    partial class FormPromotion
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPromotion = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddPromo = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản lý mã giảm giá";
            // 
            // flowLayoutPanelPromotion
            // 
            this.flowLayoutPanelPromotion.AutoScroll = true;
            this.flowLayoutPanelPromotion.Location = new System.Drawing.Point(36, 73);
            this.flowLayoutPanelPromotion.Name = "flowLayoutPanelPromotion";
            this.flowLayoutPanelPromotion.Size = new System.Drawing.Size(804, 439);
            this.flowLayoutPanelPromotion.TabIndex = 15;
            // 
            // ButtonAddPromo
            // 
            this.ButtonAddPromo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddPromo.CheckedState.Parent = this.ButtonAddPromo;
            this.ButtonAddPromo.CustomImages.Parent = this.ButtonAddPromo;
            this.ButtonAddPromo.DisabledState.Parent = this.ButtonAddPromo;
            this.ButtonAddPromo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonAddPromo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonAddPromo.ForeColor = System.Drawing.Color.White;
            this.ButtonAddPromo.HoverState.Parent = this.ButtonAddPromo;
            this.ButtonAddPromo.Location = new System.Drawing.Point(36, 518);
            this.ButtonAddPromo.Name = "ButtonAddPromo";
            this.ButtonAddPromo.ShadowDecoration.Parent = this.ButtonAddPromo;
            this.ButtonAddPromo.Size = new System.Drawing.Size(180, 45);
            this.ButtonAddPromo.TabIndex = 18;
            this.ButtonAddPromo.Text = "Thêm mã mới";
            this.ButtonAddPromo.Click += new System.EventHandler(this.ButtonAddPromo_Click);
            // 
            // FormPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAddPromo);
            this.Controls.Add(this.flowLayoutPanelPromotion);
            this.Controls.Add(this.label1);
            this.Name = "FormPromotion";
            this.Size = new System.Drawing.Size(865, 572);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPromotion;
        private Guna.UI2.WinForms.Guna2Button ButtonAddPromo;
    }
}
