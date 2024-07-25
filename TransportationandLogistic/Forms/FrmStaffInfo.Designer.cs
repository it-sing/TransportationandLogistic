namespace TransportationandLogistic.Forms
{
    partial class FrmStaffInfo
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtStaffNameKH = new System.Windows.Forms.TextBox();
            this.txtStaffNameEn = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.HiredDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.transportandLogisticDataSet = new TransportationandLogistic.TransportandLogisticDataSet();
            this.tbUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUserTableAdapter = new TransportationandLogistic.TransportandLogisticDataSetTableAdapters.tbUserTableAdapter();
            this.transportandLogisticDataSet1 = new TransportationandLogistic.TransportandLogisticDataSet1();
            this.tbStaffInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStaffInfoTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet1TableAdapters.tbStaffInfoTableAdapter();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.cboStaffPostion = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStaffInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(464, 909);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 58;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(464, 836);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 31);
            this.label6.TabIndex = 56;
            this.label6.Text = "Hired Date : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtAddress.Location = new System.Drawing.Point(748, 676);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(538, 58);
            this.txtAddress.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(464, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 31);
            this.label5.TabIndex = 54;
            this.label5.Text = "Address : ";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1184, 1044);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 50);
            this.btnLogout.TabIndex = 53;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(914, 1044);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(198, 50);
            this.btnNew.TabIndex = 52;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(656, 1044);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 50);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(412, 1044);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreate.Size = new System.Drawing.Size(198, 50);
            this.btnCreate.TabIndex = 50;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtStaffNameKH
            // 
            this.txtStaffNameKH.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtStaffNameKH.Location = new System.Drawing.Point(748, 333);
            this.txtStaffNameKH.Multiline = true;
            this.txtStaffNameKH.Name = "txtStaffNameKH";
            this.txtStaffNameKH.Size = new System.Drawing.Size(538, 45);
            this.txtStaffNameKH.TabIndex = 46;
            // 
            // txtStaffNameEn
            // 
            this.txtStaffNameEn.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNameEn.Location = new System.Drawing.Point(748, 254);
            this.txtStaffNameEn.Multiline = true;
            this.txtStaffNameEn.Name = "txtStaffNameEn";
            this.txtStaffNameEn.Size = new System.Drawing.Size(538, 43);
            this.txtStaffNameEn.TabIndex = 45;
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(748, 161);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(538, 50);
            this.txtStaffID.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(464, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 31);
            this.label4.TabIndex = 43;
            this.label4.Text = "Staff Postition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(464, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "Birth Date : ";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lable4.Location = new System.Drawing.Point(464, 426);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(126, 31);
            this.lable4.TabIndex = 41;
            this.lable4.Text = "Gender : ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Password.Location = new System.Drawing.Point(464, 336);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(258, 31);
            this.Password.TabIndex = 40;
            this.Password.Text = "Staff Name Khmer : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(464, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "Staff Name English : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(464, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Staff ID : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(464, 762);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 31);
            this.label8.TabIndex = 60;
            this.label8.Text = "PhoneNumber : ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(748, 759);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(538, 56);
            this.txtPhoneNumber.TabIndex = 61;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(81, 109);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 48);
            this.txtSearch.TabIndex = 64;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPhoto.Location = new System.Drawing.Point(1544, 505);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(269, 61);
            this.btnSelectPhoto.TabIndex = 65;
            this.btnSelectPhoto.Text = "Select Photo";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(86, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 31);
            this.label9.TabIndex = 66;
            this.label9.Text = "Search";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(843, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(453, 49);
            this.label10.TabIndex = 68;
            this.label10.Text = "Staff Information Form";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Arial", 16.125F);
            this.rbMale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbMale.Location = new System.Drawing.Point(748, 426);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(146, 53);
            this.rbMale.TabIndex = 69;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Arial", 16.125F);
            this.rbFemale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbFemale.Location = new System.Drawing.Point(1121, 426);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(209, 53);
            this.rbFemale.TabIndex = 70;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // BirthDate
            // 
            this.BirthDate.CalendarFont = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Location = new System.Drawing.Point(748, 520);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(538, 57);
            this.BirthDate.TabIndex = 71;
            // 
            // HiredDate
            // 
            this.HiredDate.CalendarFont = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiredDate.Location = new System.Drawing.Point(748, 836);
            this.HiredDate.Name = "HiredDate";
            this.HiredDate.Size = new System.Drawing.Size(538, 57);
            this.HiredDate.TabIndex = 72;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Working",
            "Resigned"});
            this.cboStatus.Location = new System.Drawing.Point(748, 912);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(538, 57);
            this.cboStatus.TabIndex = 73;
            // 
            // transportandLogisticDataSet
            // 
            this.transportandLogisticDataSet.DataSetName = "TransportandLogisticDataSet";
            this.transportandLogisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUserBindingSource
            // 
            this.tbUserBindingSource.DataMember = "tbUser";
            this.tbUserBindingSource.DataSource = this.transportandLogisticDataSet;
            // 
            // tbUserTableAdapter
            // 
            this.tbUserTableAdapter.ClearBeforeFill = true;
            // 
            // transportandLogisticDataSet1
            // 
            this.transportandLogisticDataSet1.DataSetName = "TransportandLogisticDataSet1";
            this.transportandLogisticDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbStaffInfoBindingSource
            // 
            this.tbStaffInfoBindingSource.DataMember = "tbStaffInfo";
            this.tbStaffInfoBindingSource.DataSource = this.transportandLogisticDataSet1;
            // 
            // tbStaffInfoTableAdapter
            // 
            this.tbStaffInfoTableAdapter.ClearBeforeFill = true;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDisplay.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDisplay.Location = new System.Drawing.Point(81, 187);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(284, 907);
            this.panelDisplay.TabIndex = 79;
            // 
            // cboStaffPostion
            // 
            this.cboStaffPostion.FormattingEnabled = true;
            this.cboStaffPostion.Items.AddRange(new object[] {
            "Admin",
            "Accounting",
            "Driver ",
            "Manager ",
            "Customer Service "});
            this.cboStaffPostion.Location = new System.Drawing.Point(748, 602);
            this.cboStaffPostion.Name = "cboStaffPostion";
            this.cboStaffPostion.Size = new System.Drawing.Size(538, 57);
            this.cboStaffPostion.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(1544, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2003, 1275);
            this.Controls.Add(this.cboStaffPostion);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.HiredDate);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtStaffNameKH);
            this.Controls.Add(this.txtStaffNameEn);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 16.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmStaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStaffInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtStaffNameKH;
        private System.Windows.Forms.TextBox txtStaffNameEn;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.DateTimePicker HiredDate;
        private System.Windows.Forms.ComboBox cboStatus;
        private TransportandLogisticDataSet transportandLogisticDataSet;
        private System.Windows.Forms.BindingSource tbUserBindingSource;
        private TransportandLogisticDataSetTableAdapters.tbUserTableAdapter tbUserTableAdapter;
        private TransportandLogisticDataSet1 transportandLogisticDataSet1;
        private System.Windows.Forms.BindingSource tbStaffInfoBindingSource;
        private TransportandLogisticDataSet1TableAdapters.tbStaffInfoTableAdapter tbStaffInfoTableAdapter;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.ComboBox cboStaffPostion;
    }
}