
namespace Chanh_Coffee.View.AdminForms
{
    partial class FormSaleReport
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.DateTimeEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetStat = new System.Windows.Forms.Button();
            this.dataGridViewStat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(31, 66);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(720, 10);
            this.guna2Separator1.TabIndex = 16;
            // 
            // DateTimeEnd
            // 
            this.DateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeEnd.AutoRoundedCorners = true;
            this.DateTimeEnd.BorderRadius = 12;
            this.DateTimeEnd.Checked = true;
            this.DateTimeEnd.CheckedState.Parent = this.DateTimeEnd;
            this.DateTimeEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.DateTimeEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeEnd.ForeColor = System.Drawing.Color.Black;
            this.DateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeEnd.HoverState.Parent = this.DateTimeEnd;
            this.DateTimeEnd.Location = new System.Drawing.Point(579, 86);
            this.DateTimeEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeEnd.Name = "DateTimeEnd";
            this.DateTimeEnd.ShadowDecoration.Parent = this.DateTimeEnd;
            this.DateTimeEnd.Size = new System.Drawing.Size(175, 27);
            this.DateTimeEnd.TabIndex = 14;
            this.DateTimeEnd.Value = new System.DateTime(2021, 5, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(475, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // DateTimeStart
            // 
            this.DateTimeStart.AutoRoundedCorners = true;
            this.DateTimeStart.BorderRadius = 12;
            this.DateTimeStart.Checked = true;
            this.DateTimeStart.CheckedState.Parent = this.DateTimeStart;
            this.DateTimeStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.DateTimeStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeStart.ForeColor = System.Drawing.Color.Black;
            this.DateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeStart.HoverState.Parent = this.DateTimeStart;
            this.DateTimeStart.Location = new System.Drawing.Point(132, 86);
            this.DateTimeStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeStart.Name = "DateTimeStart";
            this.DateTimeStart.ShadowDecoration.Parent = this.DateTimeStart;
            this.DateTimeStart.Size = new System.Drawing.Size(175, 27);
            this.DateTimeStart.TabIndex = 15;
            this.DateTimeStart.Value = new System.DateTime(2021, 11, 30, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thống kê bán hàng";
            // 
            // btnGetStat
            // 
            this.btnGetStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetStat.BackColor = System.Drawing.Color.Moccasin;
            this.btnGetStat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGetStat.FlatAppearance.BorderSize = 0;
            this.btnGetStat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnGetStat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStat.Location = new System.Drawing.Point(652, 496);
            this.btnGetStat.Name = "btnGetStat";
            this.btnGetStat.Size = new System.Drawing.Size(99, 36);
            this.btnGetStat.TabIndex = 18;
            this.btnGetStat.Text = "Thống kê";
            this.btnGetStat.UseVisualStyleBackColor = false;
            this.btnGetStat.Click += new System.EventHandler(this.btnGetStat_Click);
            // 
            // dataGridViewStat
            // 
            this.dataGridViewStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStat.Location = new System.Drawing.Point(35, 119);
            this.dataGridViewStat.Name = "dataGridViewStat";
            this.dataGridViewStat.Size = new System.Drawing.Size(716, 371);
            this.dataGridViewStat.TabIndex = 19;
            // 
            // FormSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewStat);
            this.Controls.Add(this.btnGetStat);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.DateTimeEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSaleReport";
            this.Size = new System.Drawing.Size(768, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeEnd;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetStat;
        private System.Windows.Forms.DataGridView dataGridViewStat;
    }
}
