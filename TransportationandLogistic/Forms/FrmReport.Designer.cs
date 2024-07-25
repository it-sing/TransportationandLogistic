namespace TransportationandLogistic.Forms
{
    partial class FrmReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvoiceReport = new FontAwesome.Sharp.IconButton();
            this.btnBookingReport = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(982, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please choose section";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(877, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to Report section";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInvoiceReport
            // 
            this.btnInvoiceReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInvoiceReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInvoiceReport.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceReport.ForeColor = System.Drawing.Color.Black;
            this.btnInvoiceReport.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnInvoiceReport.IconColor = System.Drawing.Color.IndianRed;
            this.btnInvoiceReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoiceReport.IconSize = 70;
            this.btnInvoiceReport.Location = new System.Drawing.Point(1451, 567);
            this.btnInvoiceReport.Name = "btnInvoiceReport";
            this.btnInvoiceReport.Size = new System.Drawing.Size(551, 369);
            this.btnInvoiceReport.TabIndex = 9;
            this.btnInvoiceReport.Text = "Package Report";
            this.btnInvoiceReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoiceReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoiceReport.UseVisualStyleBackColor = false;
            this.btnInvoiceReport.Click += new System.EventHandler(this.btnInvoiceReport_Click);
            // 
            // btnBookingReport
            // 
            this.btnBookingReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookingReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBookingReport.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReport.ForeColor = System.Drawing.Color.Black;
            this.btnBookingReport.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnBookingReport.IconColor = System.Drawing.Color.IndianRed;
            this.btnBookingReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookingReport.IconSize = 70;
            this.btnBookingReport.Location = new System.Drawing.Point(236, 556);
            this.btnBookingReport.Name = "btnBookingReport";
            this.btnBookingReport.Size = new System.Drawing.Size(545, 381);
            this.btnBookingReport.TabIndex = 8;
            this.btnBookingReport.Text = "Booking Report ";
            this.btnBookingReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookingReport.UseVisualStyleBackColor = false;
            this.btnBookingReport.Click += new System.EventHandler(this.btnBookingReport_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2256, 1377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvoiceReport);
            this.Controls.Add(this.btnBookingReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnInvoiceReport;
        private FontAwesome.Sharp.IconButton btnBookingReport;
    }
}