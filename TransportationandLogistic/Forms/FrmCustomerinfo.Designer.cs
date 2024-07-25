namespace TransportationandLogistic.Forms
{
    partial class FrmCustomerinfo
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
            this.btnCustomerPackageDetail = new FontAwesome.Sharp.IconButton();
            this.btnCustomerBookinginfo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(928, 460);
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
            this.label1.Location = new System.Drawing.Point(728, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(869, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to Customer Infomation Section";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCustomerPackageDetail
            // 
            this.btnCustomerPackageDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomerPackageDetail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCustomerPackageDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerPackageDetail.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPackageDetail.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerPackageDetail.IconChar = FontAwesome.Sharp.IconChar.WalkieTalkie;
            this.btnCustomerPackageDetail.IconColor = System.Drawing.Color.IndianRed;
            this.btnCustomerPackageDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomerPackageDetail.IconSize = 70;
            this.btnCustomerPackageDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerPackageDetail.Location = new System.Drawing.Point(1436, 589);
            this.btnCustomerPackageDetail.Name = "btnCustomerPackageDetail";
            this.btnCustomerPackageDetail.Size = new System.Drawing.Size(557, 385);
            this.btnCustomerPackageDetail.TabIndex = 9;
            this.btnCustomerPackageDetail.Text = "Customer Package Detail";
            this.btnCustomerPackageDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerPackageDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerPackageDetail.UseVisualStyleBackColor = false;
            this.btnCustomerPackageDetail.Click += new System.EventHandler(this.btnCustomerPackageDetail_Click);
            // 
            // btnCustomerBookinginfo
            // 
            this.btnCustomerBookinginfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomerBookinginfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCustomerBookinginfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerBookinginfo.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerBookinginfo.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerBookinginfo.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            this.btnCustomerBookinginfo.IconColor = System.Drawing.Color.IndianRed;
            this.btnCustomerBookinginfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomerBookinginfo.IconSize = 70;
            this.btnCustomerBookinginfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerBookinginfo.Location = new System.Drawing.Point(234, 601);
            this.btnCustomerBookinginfo.Name = "btnCustomerBookinginfo";
            this.btnCustomerBookinginfo.Size = new System.Drawing.Size(569, 373);
            this.btnCustomerBookinginfo.TabIndex = 8;
            this.btnCustomerBookinginfo.Text = "Customer Booking Detail";
            this.btnCustomerBookinginfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerBookinginfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerBookinginfo.UseVisualStyleBackColor = false;
            this.btnCustomerBookinginfo.Click += new System.EventHandler(this.btnCustomerBookinginfo_Click);
            // 
            // FrmCustomerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2165, 1290);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerPackageDetail);
            this.Controls.Add(this.btnCustomerBookinginfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomerinfo";
            this.Text = "FrmCustomerinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCustomerPackageDetail;
        private FontAwesome.Sharp.IconButton btnCustomerBookinginfo;
    }
}