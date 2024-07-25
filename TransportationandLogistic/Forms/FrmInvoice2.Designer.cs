namespace TransportationandLogistic.Forms
{
    partial class FrmInvoice2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGoingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbInvoicePackage2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet32 = new TransportationandLogistic.TransportandLogisticDataSet32();
            this.tbInvoicePackage2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet22 = new TransportationandLogistic.TransportandLogisticDataSet22();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateArrive = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPackageWeight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboDepartureFrom = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DateGoing = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.tbInvoicePackage2TableAdapter = new TransportationandLogistic.TransportandLogisticDataSet22TableAdapters.tbInvoicePackage2TableAdapter();
            this.transportandLogisticDataSet31 = new TransportationandLogistic.TransportandLogisticDataSet31();
            this.tbInvoicePackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbInvoicePackageTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet31TableAdapters.tbInvoicePackageTableAdapter();
            this.tbInvoicePackage2TableAdapter1 = new TransportationandLogistic.TransportandLogisticDataSet32TableAdapters.tbInvoicePackage2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoicePackage2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoicePackage2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet22)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoicePackageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1272, 973);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 50);
            this.btnExit.TabIndex = 189;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn,
            this.paymentIDDataGridViewTextBoxColumn,
            this.packageWeightDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.departureFromDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.dateGoingDataGridViewTextBoxColumn,
            this.dateArriveDataGridViewTextBoxColumn,
            this.Status});
            this.dataGridView1.DataSource = this.tbInvoicePackage2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(214, 1186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2107, 349);
            this.dataGridView1.TabIndex = 188;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceNoDataGridViewTextBoxColumn.Width = 200;
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // packageWeightDataGridViewTextBoxColumn
            // 
            this.packageWeightDataGridViewTextBoxColumn.DataPropertyName = "PackageWeight";
            this.packageWeightDataGridViewTextBoxColumn.HeaderText = "PackageWeight";
            this.packageWeightDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.packageWeightDataGridViewTextBoxColumn.Name = "packageWeightDataGridViewTextBoxColumn";
            this.packageWeightDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 200;
            // 
            // departureFromDataGridViewTextBoxColumn
            // 
            this.departureFromDataGridViewTextBoxColumn.DataPropertyName = "DepartureFrom";
            this.departureFromDataGridViewTextBoxColumn.HeaderText = "DepartureFrom";
            this.departureFromDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.departureFromDataGridViewTextBoxColumn.Name = "departureFromDataGridViewTextBoxColumn";
            this.departureFromDataGridViewTextBoxColumn.Width = 200;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateGoingDataGridViewTextBoxColumn
            // 
            this.dateGoingDataGridViewTextBoxColumn.DataPropertyName = "DateGoing";
            this.dateGoingDataGridViewTextBoxColumn.HeaderText = "DateGoing";
            this.dateGoingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateGoingDataGridViewTextBoxColumn.Name = "dateGoingDataGridViewTextBoxColumn";
            this.dateGoingDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateArriveDataGridViewTextBoxColumn
            // 
            this.dateArriveDataGridViewTextBoxColumn.DataPropertyName = "DateArrive";
            this.dateArriveDataGridViewTextBoxColumn.HeaderText = "DateArrive";
            this.dateArriveDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateArriveDataGridViewTextBoxColumn.Name = "dateArriveDataGridViewTextBoxColumn";
            this.dateArriveDataGridViewTextBoxColumn.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.Width = 200;
            // 
            // tbInvoicePackage2BindingSource1
            // 
            this.tbInvoicePackage2BindingSource1.DataMember = "tbInvoicePackage2";
            this.tbInvoicePackage2BindingSource1.DataSource = this.transportandLogisticDataSet32;
            // 
            // transportandLogisticDataSet32
            // 
            this.transportandLogisticDataSet32.DataSetName = "TransportandLogisticDataSet32";
            this.transportandLogisticDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInvoicePackage2BindingSource
            // 
            this.tbInvoicePackage2BindingSource.DataMember = "tbInvoicePackage2";
            this.tbInvoicePackage2BindingSource.DataSource = this.transportandLogisticDataSet22;
            // 
            // transportandLogisticDataSet22
            // 
            this.transportandLogisticDataSet22.DataSetName = "TransportandLogisticDataSet22";
            this.transportandLogisticDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(990, 1086);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(538, 43);
            this.txtSearch.TabIndex = 187;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(603, 1086);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 31);
            this.label3.TabIndex = 186;
            this.label3.Text = "Search by InvoiceNo : ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(1029, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(337, 49);
            this.label10.TabIndex = 185;
            this.label10.Text = "Invoice package";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPackageID
            // 
            this.txtPackageID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageID.Location = new System.Drawing.Point(974, 261);
            this.txtPackageID.Multiline = true;
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(538, 43);
            this.txtPackageID.TabIndex = 184;
            this.txtPackageID.TextChanged += new System.EventHandler(this.txtPackageID_TextChanged);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(974, 165);
            this.txtInvoiceNo.Multiline = true;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(538, 43);
            this.txtInvoiceNo.TabIndex = 183;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(690, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 182;
            this.label2.Text = "Package ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(692, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 181;
            this.label1.Text = "Invoice No :";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentID.Location = new System.Drawing.Point(977, 741);
            this.txtPaymentID.Multiline = true;
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(538, 43);
            this.txtPaymentID.TabIndex = 192;
            this.txtPaymentID.TextChanged += new System.EventHandler(this.txtpaymentID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(693, 741);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 191;
            this.label4.Text = "Payment ID :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1586, 1086);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 52);
            this.btnSearch.TabIndex = 196;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(974, 818);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(538, 43);
            this.txtAmount.TabIndex = 198;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(755, 818);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 197;
            this.label5.Text = "Amount: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(228, 352);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 31);
            this.label17.TabIndex = 219;
            this.label17.Text = "Package Detail";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(1008, 973);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(198, 50);
            this.btnCreate.TabIndex = 220;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.DateArrive);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtPackageWeight);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cboDestination);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.cboDepartureFrom);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.DateGoing);
            this.panel2.Location = new System.Drawing.Point(234, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1946, 305);
            this.panel2.TabIndex = 199;
            // 
            // DateArrive
            // 
            this.DateArrive.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateArrive.Location = new System.Drawing.Point(1298, 134);
            this.DateArrive.Name = "DateArrive";
            this.DateArrive.Size = new System.Drawing.Size(531, 57);
            this.DateArrive.TabIndex = 153;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(978, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 33);
            this.label14.TabIndex = 152;
            this.label14.Text = "Date Arrive : ";
            // 
            // txtPackageWeight
            // 
            this.txtPackageWeight.Location = new System.Drawing.Point(377, 54);
            this.txtPackageWeight.Multiline = true;
            this.txtPackageWeight.Name = "txtPackageWeight";
            this.txtPackageWeight.ReadOnly = true;
            this.txtPackageWeight.Size = new System.Drawing.Size(408, 42);
            this.txtPackageWeight.TabIndex = 151;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(146, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 33);
            this.label15.TabIndex = 149;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(53, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 33);
            this.label16.TabIndex = 146;
            this.label16.Text = "Package Weight";
            // 
            // cboDestination
            // 
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
            this.cboDestination.Location = new System.Drawing.Point(370, 204);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(415, 57);
            this.cboDestination.TabIndex = 142;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(46, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(245, 33);
            this.label18.TabIndex = 2;
            this.label18.Text = "Departure From : ";
            // 
            // cboDepartureFrom
            // 
            this.cboDepartureFrom.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboDepartureFrom.FormattingEnabled = true;
            this.cboDepartureFrom.Items.AddRange(new object[] {
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
            this.cboDepartureFrom.Location = new System.Drawing.Point(370, 129);
            this.cboDepartureFrom.Name = "cboDepartureFrom";
            this.cboDepartureFrom.Size = new System.Drawing.Size(415, 57);
            this.cboDepartureFrom.TabIndex = 141;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(46, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(185, 33);
            this.label19.TabIndex = 3;
            this.label19.Text = "Destination : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(978, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(194, 33);
            this.label20.TabIndex = 4;
            this.label20.Text = "Date Going  : ";
            // 
            // DateGoing
            // 
            this.DateGoing.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateGoing.Location = new System.Drawing.Point(1298, 52);
            this.DateGoing.Name = "DateGoing";
            this.DateGoing.Size = new System.Drawing.Size(531, 57);
            this.DateGoing.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(755, 885);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 221;
            this.label6.Text = "Status : ";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Paid ",
            "Pending Payment"});
            this.cboStatus.Location = new System.Drawing.Point(974, 885);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(541, 57);
            this.cboStatus.TabIndex = 154;
            // 
            // tbInvoicePackage2TableAdapter
            // 
            this.tbInvoicePackage2TableAdapter.ClearBeforeFill = true;
            // 
            // transportandLogisticDataSet31
            // 
            this.transportandLogisticDataSet31.DataSetName = "TransportandLogisticDataSet31";
            this.transportandLogisticDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInvoicePackageBindingSource
            // 
            this.tbInvoicePackageBindingSource.DataMember = "tbInvoicePackage";
            this.tbInvoicePackageBindingSource.DataSource = this.transportandLogisticDataSet31;
            // 
            // tbInvoicePackageTableAdapter
            // 
            this.tbInvoicePackageTableAdapter.ClearBeforeFill = true;
            // 
            // tbInvoicePackage2TableAdapter1
            // 
            this.tbInvoicePackage2TableAdapter1.ClearBeforeFill = true;
            // 
            // FrmInvoice2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2479, 1568);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPackageID);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmInvoice2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice2";
            this.Load += new System.EventHandler(this.FrmInvoice2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoicePackage2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoicePackage2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet22)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoicePackageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateArrive;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPackageWeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboDepartureFrom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker DateGoing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStatus;
        private TransportandLogisticDataSet22 transportandLogisticDataSet22;
        private System.Windows.Forms.BindingSource tbInvoicePackage2BindingSource;
        private TransportandLogisticDataSet22TableAdapters.tbInvoicePackage2TableAdapter tbInvoicePackage2TableAdapter;
        private TransportandLogisticDataSet31 transportandLogisticDataSet31;
        private System.Windows.Forms.BindingSource tbInvoicePackageBindingSource;
        private TransportandLogisticDataSet31TableAdapters.tbInvoicePackageTableAdapter tbInvoicePackageTableAdapter;
        private TransportandLogisticDataSet32 transportandLogisticDataSet32;
        private System.Windows.Forms.BindingSource tbInvoicePackage2BindingSource1;
        private TransportandLogisticDataSet32TableAdapters.tbInvoicePackage2TableAdapter tbInvoicePackage2TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGoingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}