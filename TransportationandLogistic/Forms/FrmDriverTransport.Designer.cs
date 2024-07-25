namespace TransportationandLogistic.Forms
{
    partial class FrmDriverTransport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.cboStaffPosition = new System.Windows.Forms.ComboBox();
            this.DateGo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStaffNameEn = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBack = new System.Windows.Forms.DateTimePicker();
            this.cboGoingTo = new System.Windows.Forms.ComboBox();
            this.cboDepartureFrom = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.driverTransportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverTransportScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet12 = new TransportationandLogistic.TransportandLogisticDataSet12();
            this.driverTransportScheduleTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet12TableAdapters.DriverTransportScheduleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTransportScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(980, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(524, 49);
            this.label10.TabIndex = 133;
            this.label10.Text = "Driver Transport Schedule";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboStaffPosition
            // 
            this.cboStaffPosition.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboStaffPosition.FormattingEnabled = true;
            this.cboStaffPosition.Items.AddRange(new object[] {
            "Admin",
            "Accounting",
            "Driver ",
            "Stock Manager"});
            this.cboStaffPosition.Location = new System.Drawing.Point(1093, 348);
            this.cboStaffPosition.Name = "cboStaffPosition";
            this.cboStaffPosition.Size = new System.Drawing.Size(538, 57);
            this.cboStaffPosition.TabIndex = 132;
            // 
            // DateGo
            // 
            this.DateGo.CalendarFont = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateGo.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateGo.Location = new System.Drawing.Point(1093, 602);
            this.DateGo.Name = "DateGo";
            this.DateGo.Size = new System.Drawing.Size(538, 57);
            this.DateGo.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(809, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 31);
            this.label8.TabIndex = 126;
            this.label8.Text = "Going to  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(809, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 31);
            this.label7.TabIndex = 125;
            this.label7.Text = "Date Back : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(809, 621);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 31);
            this.label6.TabIndex = 124;
            this.label6.Text = "Date Go :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(809, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 31);
            this.label5.TabIndex = 122;
            this.label5.Text = "Departure from : ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1400, 845);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(198, 50);
            this.btnLogOut.TabIndex = 121;
            this.btnLogOut.Text = "Exit";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1130, 845);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(198, 50);
            this.btnNew.TabIndex = 120;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(872, 845);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 50);
            this.btnUpdate.TabIndex = 119;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStaffNameEn
            // 
            this.txtStaffNameEn.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNameEn.Location = new System.Drawing.Point(1093, 269);
            this.txtStaffNameEn.Multiline = true;
            this.txtStaffNameEn.Name = "txtStaffNameEn";
            this.txtStaffNameEn.Size = new System.Drawing.Size(538, 43);
            this.txtStaffNameEn.TabIndex = 116;
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(1093, 173);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(538, 43);
            this.txtStaffID.TabIndex = 115;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(809, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 114;
            this.label4.Text = "Staff Postition :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(809, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 31);
            this.label2.TabIndex = 111;
            this.label2.Text = "Staff Name English : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(811, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 110;
            this.label1.Text = "Staff ID : ";
            // 
            // cboCarType
            // 
            this.cboCarType.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Items.AddRange(new object[] {
            "Van",
            "Bus",
            "VIP"});
            this.cboCarType.Location = new System.Drawing.Point(1093, 756);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(538, 57);
            this.cboCarType.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(811, 756);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 137;
            this.label3.Text = "Car Type : ";
            // 
            // DateBack
            // 
            this.DateBack.CalendarFont = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBack.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateBack.Location = new System.Drawing.Point(1093, 679);
            this.DateBack.Name = "DateBack";
            this.DateBack.Size = new System.Drawing.Size(538, 57);
            this.DateBack.TabIndex = 139;
            // 
            // cboGoingTo
            // 
            this.cboGoingTo.Font = new System.Drawing.Font("Arial", 16.125F);
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
            this.cboGoingTo.Location = new System.Drawing.Point(1093, 520);
            this.cboGoingTo.Name = "cboGoingTo";
            this.cboGoingTo.Size = new System.Drawing.Size(538, 57);
            this.cboGoingTo.TabIndex = 140;
            // 
            // cboDepartureFrom
            // 
            this.cboDepartureFrom.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboDepartureFrom.FormattingEnabled = true;
            this.cboDepartureFrom.Items.AddRange(new object[] {
            "Phnom Penh"});
            this.cboDepartureFrom.Location = new System.Drawing.Point(1093, 428);
            this.cboDepartureFrom.Name = "cboDepartureFrom";
            this.cboDepartureFrom.Size = new System.Drawing.Size(538, 57);
            this.cboDepartureFrom.TabIndex = 141;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverTransportIDDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameEnDataGridViewTextBoxColumn,
            this.staffPositionDataGridViewTextBoxColumn,
            this.departureFromDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.goingDateDataGridViewTextBoxColumn,
            this.backDateDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.driverTransportScheduleBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(326, 941);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1888, 421);
            this.dataGridView1.TabIndex = 142;
            // 
            // driverTransportIDDataGridViewTextBoxColumn
            // 
            this.driverTransportIDDataGridViewTextBoxColumn.DataPropertyName = "DriverTransportID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.driverTransportIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.driverTransportIDDataGridViewTextBoxColumn.HeaderText = "DriverTransportID";
            this.driverTransportIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.driverTransportIDDataGridViewTextBoxColumn.Name = "driverTransportIDDataGridViewTextBoxColumn";
            this.driverTransportIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverTransportIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.staffIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // staffNameEnDataGridViewTextBoxColumn
            // 
            this.staffNameEnDataGridViewTextBoxColumn.DataPropertyName = "StaffNameEn";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.staffNameEnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffNameEnDataGridViewTextBoxColumn.HeaderText = "StaffNameEn";
            this.staffNameEnDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.staffNameEnDataGridViewTextBoxColumn.Name = "staffNameEnDataGridViewTextBoxColumn";
            this.staffNameEnDataGridViewTextBoxColumn.Width = 200;
            // 
            // staffPositionDataGridViewTextBoxColumn
            // 
            this.staffPositionDataGridViewTextBoxColumn.DataPropertyName = "StaffPosition";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.staffPositionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.staffPositionDataGridViewTextBoxColumn.HeaderText = "StaffPosition";
            this.staffPositionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.staffPositionDataGridViewTextBoxColumn.Name = "staffPositionDataGridViewTextBoxColumn";
            this.staffPositionDataGridViewTextBoxColumn.Width = 200;
            // 
            // departureFromDataGridViewTextBoxColumn
            // 
            this.departureFromDataGridViewTextBoxColumn.DataPropertyName = "DepartureFrom";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.departureFromDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.departureFromDataGridViewTextBoxColumn.HeaderText = "DepartureFrom";
            this.departureFromDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.departureFromDataGridViewTextBoxColumn.Name = "departureFromDataGridViewTextBoxColumn";
            this.departureFromDataGridViewTextBoxColumn.Width = 200;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.destinationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 200;
            // 
            // goingDateDataGridViewTextBoxColumn
            // 
            this.goingDateDataGridViewTextBoxColumn.DataPropertyName = "GoingDate";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.goingDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.goingDateDataGridViewTextBoxColumn.HeaderText = "GoingDate";
            this.goingDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.goingDateDataGridViewTextBoxColumn.Name = "goingDateDataGridViewTextBoxColumn";
            this.goingDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // backDateDataGridViewTextBoxColumn
            // 
            this.backDateDataGridViewTextBoxColumn.DataPropertyName = "BackDate";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.backDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.backDateDataGridViewTextBoxColumn.HeaderText = "BackDate";
            this.backDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.backDateDataGridViewTextBoxColumn.Name = "backDateDataGridViewTextBoxColumn";
            this.backDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            this.carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.carTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.carTypeDataGridViewTextBoxColumn.HeaderText = "CarType";
            this.carTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            this.carTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // driverTransportScheduleBindingSource
            // 
            this.driverTransportScheduleBindingSource.DataMember = "DriverTransportSchedule";
            this.driverTransportScheduleBindingSource.DataSource = this.transportandLogisticDataSet12;
            // 
            // transportandLogisticDataSet12
            // 
            this.transportandLogisticDataSet12.DataSetName = "TransportandLogisticDataSet12";
            this.transportandLogisticDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverTransportScheduleTableAdapter
            // 
            this.driverTransportScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDriverTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2415, 1432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboDepartureFrom);
            this.Controls.Add(this.cboGoingTo);
            this.Controls.Add(this.DateBack);
            this.Controls.Add(this.cboCarType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboStaffPosition);
            this.Controls.Add(this.DateGo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtStaffNameEn);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDriverTransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDriverTransport";
            this.Load += new System.EventHandler(this.FrmDriverTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTransportScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboStaffPosition;
        private System.Windows.Forms.DateTimePicker DateGo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStaffNameEn;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateBack;
        private System.Windows.Forms.ComboBox cboGoingTo;
        private System.Windows.Forms.ComboBox cboDepartureFrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportandLogisticDataSet12 transportandLogisticDataSet12;
        private System.Windows.Forms.BindingSource driverTransportScheduleBindingSource;
        private TransportandLogisticDataSet12TableAdapters.DriverTransportScheduleTableAdapter driverTransportScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverTransportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
    }
}