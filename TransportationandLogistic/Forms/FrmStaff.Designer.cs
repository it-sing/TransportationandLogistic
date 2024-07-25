namespace TransportationandLogistic.Forms
{
    partial class FrmStaff
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
            this.btnStaffInfo = new FontAwesome.Sharp.IconButton();
            this.btnStaffPaywage = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStaffInfo
            // 
            this.btnStaffInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStaffInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffInfo.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffInfo.ForeColor = System.Drawing.Color.Black;
            this.btnStaffInfo.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btnStaffInfo.IconColor = System.Drawing.Color.IndianRed;
            this.btnStaffInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaffInfo.IconSize = 70;
            this.btnStaffInfo.Location = new System.Drawing.Point(270, 552);
            this.btnStaffInfo.Name = "btnStaffInfo";
            this.btnStaffInfo.Size = new System.Drawing.Size(549, 386);
            this.btnStaffInfo.TabIndex = 0;
            this.btnStaffInfo.Text = "Staff Information";
            this.btnStaffInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffInfo.UseVisualStyleBackColor = false;
            this.btnStaffInfo.Click += new System.EventHandler(this.btnStaffInfo_Click);
            // 
            // btnStaffPaywage
            // 
            this.btnStaffPaywage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStaffPaywage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStaffPaywage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStaffPaywage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffPaywage.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffPaywage.ForeColor = System.Drawing.Color.Black;
            this.btnStaffPaywage.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.btnStaffPaywage.IconColor = System.Drawing.Color.IndianRed;
            this.btnStaffPaywage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaffPaywage.IconSize = 70;
            this.btnStaffPaywage.Location = new System.Drawing.Point(1507, 552);
            this.btnStaffPaywage.Name = "btnStaffPaywage";
            this.btnStaffPaywage.Size = new System.Drawing.Size(557, 358);
            this.btnStaffPaywage.TabIndex = 1;
            this.btnStaffPaywage.Text = "Staff Paywage";
            this.btnStaffPaywage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffPaywage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffPaywage.UseVisualStyleBackColor = false;
            this.btnStaffPaywage.Click += new System.EventHandler(this.btnStaffPaywage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(938, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Staff Section";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1012, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please choose section";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2360, 1431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStaffPaywage);
            this.Controls.Add(this.btnStaffInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaff";
            this.Text = "FrmStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnStaffInfo;
        private FontAwesome.Sharp.IconButton btnStaffPaywage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}