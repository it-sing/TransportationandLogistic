namespace TransportationandLogistic.Forms
{
    partial class FrmService
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
            this.btnDelivery = new FontAwesome.Sharp.IconButton();
            this.btnBooking = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1006, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Please choose section";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(925, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome to service section";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelivery.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelivery.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.Black;
            this.btnDelivery.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingLuggage;
            this.btnDelivery.IconColor = System.Drawing.Color.IndianRed;
            this.btnDelivery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelivery.IconSize = 70;
            this.btnDelivery.Location = new System.Drawing.Point(1555, 648);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(582, 367);
            this.btnDelivery.TabIndex = 13;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBooking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooking.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.btnBooking.IconColor = System.Drawing.Color.IndianRed;
            this.btnBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBooking.IconSize = 70;
            this.btnBooking.Location = new System.Drawing.Point(226, 649);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(580, 366);
            this.btnBooking.TabIndex = 12;
            this.btnBooking.Text = "Booking";
            this.btnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // FrmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2354, 1421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.btnBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmService";
            this.Text = "FrmService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDelivery;
        private FontAwesome.Sharp.IconButton btnBooking;
    }
}