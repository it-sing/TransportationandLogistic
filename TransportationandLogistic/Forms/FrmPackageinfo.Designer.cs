using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    partial class FrmPackageinfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGoingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet13 = new TransportationandLogistic.TransportandLogisticDataSet13();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSenderPhoneNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateArrive = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackageWeight = new System.Windows.Forms.TextBox();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDepartureFrom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateGoing = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceiverPhoneNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.tbPackageTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet13TableAdapters.tbPackageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet13)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.packageWeightDataGridViewTextBoxColumn,
            this.departureFromDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.dateGoingDataGridViewTextBoxColumn,
            this.dateArriveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbPackageBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(282, 979);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1515, 453);
            this.dataGridView1.TabIndex = 167;
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // packageWeightDataGridViewTextBoxColumn
            // 
            this.packageWeightDataGridViewTextBoxColumn.DataPropertyName = "PackageWeight";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.packageWeightDataGridViewTextBoxColumn.HeaderText = "PackageWeight";
            this.packageWeightDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.packageWeightDataGridViewTextBoxColumn.Name = "packageWeightDataGridViewTextBoxColumn";
            this.packageWeightDataGridViewTextBoxColumn.Width = 200;
            // 
            // departureFromDataGridViewTextBoxColumn
            // 
            this.departureFromDataGridViewTextBoxColumn.DataPropertyName = "DepartureFrom";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureFromDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.departureFromDataGridViewTextBoxColumn.HeaderText = "DepartureFrom";
            this.departureFromDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.departureFromDataGridViewTextBoxColumn.Name = "departureFromDataGridViewTextBoxColumn";
            this.departureFromDataGridViewTextBoxColumn.Width = 200;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateGoingDataGridViewTextBoxColumn
            // 
            this.dateGoingDataGridViewTextBoxColumn.DataPropertyName = "DateGoing";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateGoingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.dateGoingDataGridViewTextBoxColumn.HeaderText = "DateGoing";
            this.dateGoingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateGoingDataGridViewTextBoxColumn.Name = "dateGoingDataGridViewTextBoxColumn";
            this.dateGoingDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateArriveDataGridViewTextBoxColumn
            // 
            this.dateArriveDataGridViewTextBoxColumn.DataPropertyName = "DateArrive";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateArriveDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.dateArriveDataGridViewTextBoxColumn.HeaderText = "DateArrive";
            this.dateArriveDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateArriveDataGridViewTextBoxColumn.Name = "dateArriveDataGridViewTextBoxColumn";
            this.dateArriveDataGridViewTextBoxColumn.Width = 200;
            // 
            // tbPackageBindingSource
            // 
            this.tbPackageBindingSource.DataMember = "tbPackage";
            this.tbPackageBindingSource.DataSource = this.transportandLogisticDataSet13;
            // 
            // transportandLogisticDataSet13
            // 
            this.transportandLogisticDataSet13.DataSetName = "TransportandLogisticDataSet13";
            this.transportandLogisticDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1237, 891);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 50);
            this.btnLogout.TabIndex = 166;
            this.btnLogout.Text = "Exit";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(982, 891);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(198, 50);
            this.btnNew.TabIndex = 165;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(746, 891);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 50);
            this.btnUpdate.TabIndex = 164;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(484, 891);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreate.Size = new System.Drawing.Size(198, 50);
            this.btnCreate.TabIndex = 163;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(163, 453);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(284, 49);
            this.label15.TabIndex = 162;
            this.label15.Text = "Package Detail";
            // 
            // txtSenderPhoneNum
            // 
            this.txtSenderPhoneNum.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtSenderPhoneNum.Location = new System.Drawing.Point(950, 275);
            this.txtSenderPhoneNum.Multiline = true;
            this.txtSenderPhoneNum.Name = "txtSenderPhoneNum";
            this.txtSenderPhoneNum.Size = new System.Drawing.Size(552, 42);
            this.txtSenderPhoneNum.TabIndex = 161;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(493, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(311, 33);
            this.label14.TabIndex = 160;
            this.label14.Text = "Sender PhoneNumber:";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtSenderName.Location = new System.Drawing.Point(950, 206);
            this.txtSenderName.Multiline = true;
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(552, 42);
            this.txtSenderName.TabIndex = 159;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DateArrive);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPackageWeight);
            this.panel1.Controls.Add(this.txtPackageID);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboDestination);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboDepartureFrom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DateGoing);
            this.panel1.Location = new System.Drawing.Point(172, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 348);
            this.panel1.TabIndex = 158;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(1228, 228);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(493, 43);
            this.txtAmount.TabIndex = 176;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(908, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 31);
            this.label7.TabIndex = 175;
            this.label7.Text = "Total Amount: ";
            // 
            // DateArrive
            // 
            this.DateArrive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateArrive.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateArrive.Location = new System.Drawing.Point(1228, 143);
            this.DateArrive.Name = "DateArrive";
            this.DateArrive.Size = new System.Drawing.Size(493, 57);
            this.DateArrive.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(908, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 33);
            this.label4.TabIndex = 152;
            this.label4.Text = "Date Arrive : ";
            // 
            // txtPackageWeight
            // 
            this.txtPackageWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPackageWeight.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtPackageWeight.Location = new System.Drawing.Point(380, 122);
            this.txtPackageWeight.Multiline = true;
            this.txtPackageWeight.Name = "txtPackageWeight";
            this.txtPackageWeight.Size = new System.Drawing.Size(408, 42);
            this.txtPackageWeight.TabIndex = 151;
            this.txtPackageWeight.TextChanged += new System.EventHandler(this.txtPackageWeight_TextChanged);
            // 
            // txtPackageID
            // 
            this.txtPackageID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPackageID.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtPackageID.Location = new System.Drawing.Point(373, 35);
            this.txtPackageID.Multiline = true;
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(408, 42);
            this.txtPackageID.TabIndex = 148;
            this.txtPackageID.TextChanged += new System.EventHandler(this.txtPackageID_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(149, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 33);
            this.label13.TabIndex = 149;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(56, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 33);
            this.label9.TabIndex = 146;
            this.label9.Text = "Package Weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(49, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 33);
            this.label8.TabIndex = 145;
            this.label8.Text = "package ID : ";
            // 
            // cboDestination
            // 
            this.cboDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDestination.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Items.AddRange(new object[] {
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
            this.cboDestination.Location = new System.Drawing.Point(373, 272);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(415, 57);
            this.cboDestination.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure From : ";
            // 
            // cboDepartureFrom
            // 
            this.cboDepartureFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDepartureFrom.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboDepartureFrom.FormattingEnabled = true;
            this.cboDepartureFrom.Items.AddRange(new object[] {
            "Phnom Penh"});
            this.cboDepartureFrom.Location = new System.Drawing.Point(373, 197);
            this.cboDepartureFrom.Name = "cboDepartureFrom";
            this.cboDepartureFrom.Size = new System.Drawing.Size(415, 57);
            this.cboDepartureFrom.TabIndex = 141;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(49, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Destination : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(908, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Going  : ";
            // 
            // DateGoing
            // 
            this.DateGoing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateGoing.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateGoing.Location = new System.Drawing.Point(1228, 46);
            this.DateGoing.Name = "DateGoing";
            this.DateGoing.Size = new System.Drawing.Size(493, 57);
            this.DateGoing.TabIndex = 139;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtCustomerID.Location = new System.Drawing.Point(950, 129);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(552, 42);
            this.txtCustomerID.TabIndex = 157;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(821, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 49);
            this.label10.TabIndex = 156;
            this.label10.Text = "Package Form";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(493, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 33);
            this.label2.TabIndex = 155;
            this.label2.Text = "Sender Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(493, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 154;
            this.label1.Text = "Customer ID  :";
            // 
            // txtReceiverPhoneNum
            // 
            this.txtReceiverPhoneNum.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtReceiverPhoneNum.Location = new System.Drawing.Point(950, 408);
            this.txtReceiverPhoneNum.Multiline = true;
            this.txtReceiverPhoneNum.Name = "txtReceiverPhoneNum";
            this.txtReceiverPhoneNum.Size = new System.Drawing.Size(552, 42);
            this.txtReceiverPhoneNum.TabIndex = 171;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(493, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(332, 33);
            this.label12.TabIndex = 170;
            this.label12.Text = "Receiver PhoneNumber:";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtReceiverName.Location = new System.Drawing.Point(950, 339);
            this.txtReceiverName.Multiline = true;
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(552, 42);
            this.txtReceiverName.TabIndex = 169;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(493, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(231, 33);
            this.label16.TabIndex = 168;
            this.label16.Text = "Receiver Name :";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(1511, 891);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(198, 50);
            this.btnContinue.TabIndex = 174;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // tbPackageTableAdapter
            // 
            this.tbPackageTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPackageinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2007, 1502);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtReceiverPhoneNum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSenderPhoneNum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPackageinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPackageinfo";
            this.Load += new System.EventHandler(this.FrmPackageinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSenderPhoneNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDepartureFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateGoing;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceiverPhoneNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker DateArrive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackageWeight;
        private System.Windows.Forms.Button btnContinue;
        private TransportandLogisticDataSet13 transportandLogisticDataSet13;
        private System.Windows.Forms.BindingSource tbPackageBindingSource;
        private TransportandLogisticDataSet13TableAdapters.tbPackageTableAdapter tbPackageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGoingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveDataGridViewTextBoxColumn;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick;
        private TextBox txtAmount;
        private Label label7;
    }
}