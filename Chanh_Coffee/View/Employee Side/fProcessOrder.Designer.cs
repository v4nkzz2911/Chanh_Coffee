
namespace Chanh_Coffee.View.Employee_Side
{
    partial class fProcessOrder
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonClose = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPrint = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(Chanh_Coffee.Models.Order);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BorderColor = System.Drawing.Color.Silver;
            this.ButtonClose.BorderThickness = 1;
            this.ButtonClose.CheckedState.Parent = this.ButtonClose;
            this.ButtonClose.CustomImages.Parent = this.ButtonClose;
            this.ButtonClose.DisabledState.Parent = this.ButtonClose;
            this.ButtonClose.FillColor = System.Drawing.Color.White;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonClose.HoverState.Parent = this.ButtonClose;
            this.ButtonClose.Location = new System.Drawing.Point(209, 497);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.ShadowDecoration.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(171, 45);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "Close Window";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.CheckedState.Parent = this.ButtonPrint;
            this.ButtonPrint.CustomImages.Parent = this.ButtonPrint;
            this.ButtonPrint.DisabledState.Parent = this.ButtonPrint;
            this.ButtonPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.ButtonPrint.HoverState.Parent = this.ButtonPrint;
            this.ButtonPrint.Location = new System.Drawing.Point(23, 497);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.ShadowDecoration.Parent = this.ButtonPrint;
            this.ButtonPrint.Size = new System.Drawing.Size(171, 45);
            this.ButtonPrint.TabIndex = 11;
            this.ButtonPrint.Text = "Print Receipt";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(395, 100);
            this.guna2Panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Successful Transaction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Chanh_Coffee.View.Employee Side.Report1.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(4, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(391, 385);
            this.reportViewer1.TabIndex = 12;
            // 
            // fProcessOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 558);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fProcessOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.fProcessOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonClose;
        private Guna.UI2.WinForms.Guna2Button ButtonPrint;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrderBindingSource;
    }
}