namespace TransportationandLogistic.Forms
{
    partial class FrmDriverLogistic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboStaffPosition = new System.Windows.Forms.ComboBox();
            this.DateGo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtStaffNameEn = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DateBack = new System.Windows.Forms.DateTimePicker();
            this.cboDepartureFrom = new System.Windows.Forms.ComboBox();
            this.cboGoingTo = new System.Windows.Forms.ComboBox();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.driverLogisticScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLogisticScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet11 = new TransportationandLogistic.TransportandLogisticDataSet11();
            this.driverLogisticScheduleTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet11TableAdapters.DriverLogisticScheduleTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverLogisticScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // cboStaffPosition
            // 
            this.cboStaffPosition.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffPosition.FormattingEnabled = true;
            this.cboStaffPosition.Items.AddRange(new object[] {
            "Admin",
            "Accounting",
            "Driver ",
            "Stock Manager"});
            this.cboStaffPosition.Location = new System.Drawing.Point(1060, 363);
            this.cboStaffPosition.Name = "cboStaffPosition";
            this.cboStaffPosition.Size = new System.Drawing.Size(538, 57);
            this.cboStaffPosition.TabIndex = 105;
            // 
            // DateGo
            // 
            this.DateGo.CalendarFont = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateGo.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateGo.Location = new System.Drawing.Point(1060, 645);
            this.DateGo.Name = "DateGo";
            this.DateGo.Size = new System.Drawing.Size(538, 57);
            this.DateGo.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(706, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 31);
            this.label8.TabIndex = 98;
            this.label8.Text = "Going to ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(706, 714);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 31);
            this.label7.TabIndex = 97;
            this.label7.Text = "Date Back";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(706, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 31);
            this.label6.TabIndex = 96;
            this.label6.Text = "Date Go ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(706, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 31);
            this.label5.TabIndex = 94;
            this.label5.Text = "Departure from";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1317, 819);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 50);
            this.btnLogout.TabIndex = 93;
            this.btnLogout.Text = "Exit";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1062, 819);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(198, 50);
            this.btnNew.TabIndex = 92;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtStaffNameEn
            // 
            this.txtStaffNameEn.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNameEn.Location = new System.Drawing.Point(1060, 285);
            this.txtStaffNameEn.Multiline = true;
            this.txtStaffNameEn.Name = "txtStaffNameEn";
            this.txtStaffNameEn.Size = new System.Drawing.Size(538, 43);
            this.txtStaffNameEn.TabIndex = 88;
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(1062, 194);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(538, 50);
            this.txtStaffID.TabIndex = 87;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(706, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 31);
            this.label4.TabIndex = 86;
            this.label4.Text = "Staff Postition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(706, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 31);
            this.label2.TabIndex = 82;
            this.label2.Text = "Staff Name English : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(708, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 81;
            this.label1.Text = "Staff ID : ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(886, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(491, 49);
            this.label10.TabIndex = 106;
            this.label10.Text = "Driver Logistic Schedule";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateBack
            // 
            this.DateBack.CalendarFont = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBack.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateBack.Location = new System.Drawing.Point(1060, 730);
            this.DateBack.Name = "DateBack";
            this.DateBack.Size = new System.Drawing.Size(540, 57);
            this.DateBack.TabIndex = 110;
            // 
            // cboDepartureFrom
            // 
            this.cboDepartureFrom.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureFrom.FormattingEnabled = true;
            this.cboDepartureFrom.Items.AddRange(new object[] {
            "Phnom Penh"});
            this.cboDepartureFrom.Location = new System.Drawing.Point(1060, 463);
            this.cboDepartureFrom.Name = "cboDepartureFrom";
            this.cboDepartureFrom.Size = new System.Drawing.Size(538, 57);
            this.cboDepartureFrom.TabIndex = 143;
            // 
            // cboGoingTo
            // 
            this.cboGoingTo.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGoingTo.FormattingEnabled = true;
            this.cboGoingTo.Items.AddRange(new object[] {
            "Phnom Penh",
            "Banteay Meanchey",
            "Battambang",
            "Kampong Cham",
            "Kampong Chhnang",
            "Kampong Speu",
            "Kampong Thom",
            "Kandal",
            "Kep",
            "Kratie",
            "Mondulkiri",
            "Oddar Meanchey",
            "Pailin",
            "Preah Vihear",
            "Prey Veng",
            "Pursat",
            "Ratanakiri",
            "Siem Reap",
            "Stung Treng",
            "Svay Rieng",
            "Takeo",
            "Tboung Khmum"});
            this.cboGoingTo.Location = new System.Drawing.Point(1060, 544);
            this.cboGoingTo.Name = "cboGoingTo";
            this.cboGoingTo.Size = new System.Drawing.Size(538, 57);
            this.cboGoingTo.TabIndex = 142;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverLogisticScheduleDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameEnDataGridViewTextBoxColumn,
            this.staffPositionDataGridViewTextBoxColumn,
            this.departureFromDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.goingDateDataGridViewTextBoxColumn,
            this.backDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.driverLogisticScheduleBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(381, 951);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1685, 376);
            this.dataGridView1.TabIndex = 144;
            // 
            // driverLogisticScheduleDataGridViewTextBoxColumn
            // 
            this.driverLogisticScheduleDataGridViewTextBoxColumn.DataPropertyName = "DriverLogisticSchedule";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLogisticScheduleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.driverLogisticScheduleDataGridViewTextBoxColumn.HeaderText = "DriverLogisticSchedule";
            this.driverLogisticScheduleDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.driverLogisticScheduleDataGridViewTextBoxColumn.Name = "driverLogisticScheduleDataGridViewTextBoxColumn";
            this.driverLogisticScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverLogisticScheduleDataGridViewTextBoxColumn.Width = 200;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // staffNameEnDataGridViewTextBoxColumn
            // 
            this.staffNameEnDataGridViewTextBoxColumn.DataPropertyName = "StaffNameEn";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameEnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffNameEnDataGridViewTextBoxColumn.HeaderText = "StaffNameEn";
            this.staffNameEnDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.staffNameEnDataGridViewTextBoxColumn.Name = "staffNameEnDataGridViewTextBoxColumn";
            this.staffNameEnDataGridViewTextBoxColumn.Width = 200;
            // 
            // staffPositionDataGridViewTextBoxColumn
            // 
            this.staffPositionDataGridViewTextBoxColumn.DataPropertyName = "StaffPosition";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffPositionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.staffPositionDataGridViewTextBoxColumn.HeaderText = "StaffPosition";
            this.staffPositionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.staffPositionDataGridViewTextBoxColumn.Name = "staffPositionDataGridViewTextBoxColumn";
            this.staffPositionDataGridViewTextBoxColumn.Width = 200;
            // 
            // departureFromDataGridViewTextBoxColumn
            // 
            this.departureFromDataGridViewTextBoxColumn.DataPropertyName = "DepartureFrom";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureFromDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.departureFromDataGridViewTextBoxColumn.HeaderText = "DepartureFrom";
            this.departureFromDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.departureFromDataGridViewTextBoxColumn.Name = "departureFromDataGridViewTextBoxColumn";
            this.departureFromDataGridViewTextBoxColumn.Width = 200;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 200;
            // 
            // goingDateDataGridViewTextBoxColumn
            // 
            this.goingDateDataGridViewTextBoxColumn.DataPropertyName = "GoingDate";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goingDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.goingDateDataGridViewTextBoxColumn.HeaderText = "GoingDate";
            this.goingDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.goingDateDataGridViewTextBoxColumn.Name = "goingDateDataGridViewTextBoxColumn";
            this.goingDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // backDateDataGridViewTextBoxColumn
            // 
            this.backDateDataGridViewTextBoxColumn.DataPropertyName = "BackDate";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.backDateDataGridViewTextBoxColumn.HeaderText = "BackDate";
            this.backDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.backDateDataGridViewTextBoxColumn.Name = "backDateDataGridViewTextBoxColumn";
            this.backDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // driverLogisticScheduleBindingSource
            // 
            this.driverLogisticScheduleBindingSource.DataMember = "DriverLogisticSchedule";
            this.driverLogisticScheduleBindingSource.DataSource = this.transportandLogisticDataSet11;
            // 
            // transportandLogisticDataSet11
            // 
            this.transportandLogisticDataSet11.DataSetName = "TransportandLogisticDataSet11";
            this.transportandLogisticDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverLogisticScheduleTableAdapter
            // 
            this.driverLogisticScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(805, 819);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 50);
            this.btnUpdate.TabIndex = 145;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmDriverLogistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2212, 1397);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboDepartureFrom);
            this.Controls.Add(this.cboGoingTo);
            this.Controls.Add(this.DateBack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboStaffPosition);
            this.Controls.Add(this.DateGo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtStaffNameEn);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDriverLogistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDriverLogistic";
            this.Load += new System.EventHandler(this.FrmDriverLogistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverLogisticScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStaffPosition;
        private System.Windows.Forms.DateTimePicker DateGo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtStaffNameEn;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateBack;
        private System.Windows.Forms.ComboBox cboDepartureFrom;
        private System.Windows.Forms.ComboBox cboGoingTo;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportandLogisticDataSet11 transportandLogisticDataSet11;
        private System.Windows.Forms.BindingSource driverLogisticScheduleBindingSource;
        private TransportandLogisticDataSet11TableAdapters.DriverLogisticScheduleTableAdapter driverLogisticScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverLogisticScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
    }
}