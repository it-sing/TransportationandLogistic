namespace TransportationandLogistic.Forms
{
    partial class FrmDriver
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
            this.btnDriverLogistic = new FontAwesome.Sharp.IconButton();
            this.btnDriverTransport = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1040, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please choose section";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(868, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to Driver schedule Section";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDriverLogistic
            // 
            this.btnDriverLogistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDriverLogistic.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDriverLogistic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDriverLogistic.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverLogistic.ForeColor = System.Drawing.Color.Black;
            this.btnDriverLogistic.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            this.btnDriverLogistic.IconColor = System.Drawing.Color.IndianRed;
            this.btnDriverLogistic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDriverLogistic.IconSize = 70;
            this.btnDriverLogistic.Location = new System.Drawing.Point(1574, 558);
            this.btnDriverLogistic.Name = "btnDriverLogistic";
            this.btnDriverLogistic.Size = new System.Drawing.Size(551, 369);
            this.btnDriverLogistic.TabIndex = 5;
            this.btnDriverLogistic.Text = "Driver Logistic";
            this.btnDriverLogistic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDriverLogistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDriverLogistic.UseVisualStyleBackColor = false;
            this.btnDriverLogistic.Click += new System.EventHandler(this.btnDriverLogistic_Click);
            // 
            // btnDriverTransport
            // 
            this.btnDriverTransport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDriverTransport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDriverTransport.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverTransport.ForeColor = System.Drawing.Color.Black;
            this.btnDriverTransport.IconChar = FontAwesome.Sharp.IconChar.CarCrash;
            this.btnDriverTransport.IconColor = System.Drawing.Color.IndianRed;
            this.btnDriverTransport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDriverTransport.IconSize = 70;
            this.btnDriverTransport.Location = new System.Drawing.Point(235, 552);
            this.btnDriverTransport.Name = "btnDriverTransport";
            this.btnDriverTransport.Size = new System.Drawing.Size(545, 381);
            this.btnDriverTransport.TabIndex = 4;
            this.btnDriverTransport.Text = "Driver Transportation";
            this.btnDriverTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriverTransport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDriverTransport.UseVisualStyleBackColor = false;
            this.btnDriverTransport.Click += new System.EventHandler(this.btnDriverTransport_Click);
            // 
            // FrmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2301, 1357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDriverLogistic);
            this.Controls.Add(this.btnDriverTransport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " FrmDriver";
            this.Load += new System.EventHandler(this.FrmDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDriverLogistic;
        private FontAwesome.Sharp.IconButton btnDriverTransport;
    }
}