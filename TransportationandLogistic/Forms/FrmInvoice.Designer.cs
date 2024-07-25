namespace TransportationandLogistic.Forms
{
    partial class FrmInvoice
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
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbInvoiceTicket2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet23 = new TransportationandLogistic.TransportandLogisticDataSet23();
            this.tbInvoiceTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet21 = new TransportationandLogistic.TransportandLogisticDataSet21();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSeat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBookingQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateBooking = new System.Windows.Forms.DateTimePicker();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateBack = new System.Windows.Forms.DateTimePicker();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDepartureFrom = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DateGoing = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbInvoiceTicketTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet21TableAdapters.tbInvoiceTicketTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.tbInvoiceTicket2TableAdapter = new TransportationandLogistic.TransportandLogisticDataSet23TableAdapters.tbInvoiceTicket2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceTicket2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet21)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTicketID
            // 
            this.txtTicketID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketID.Location = new System.Drawing.Point(878, 293);
            this.txtTicketID.Multiline = true;
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(538, 43);
            this.txtTicketID.TabIndex = 120;
            this.txtTicketID.TextChanged += new System.EventHandler(this.txtTicketID_TextChanged);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(878, 197);
            this.txtInvoiceNo.Multiline = true;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(538, 43);
            this.txtInvoiceNo.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(594, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 118;
            this.label2.Text = "Ticket ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(596, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 117;
            this.label1.Text = "Invoice No :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(1001, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 49);
            this.label10.TabIndex = 121;
            this.label10.Text = "Invoice Ticket";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(873, 1090);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(538, 43);
            this.txtSearch.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(523, 1090);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 31);
            this.label3.TabIndex = 122;
            this.label3.Text = "Search by InvoiceNo :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.paymentIDDataGridViewTextBoxColumn,
            this.ticketIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.bookingQuantityDataGridViewTextBoxColumn,
            this.dateBookingDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn,
            this.seatDataGridViewTextBoxColumn,
            this.Status});
            this.dataGridView1.DataSource = this.tbInvoiceTicket2BindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(252, 1159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1917, 358);
            this.dataGridView1.TabIndex = 124;
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
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookingQuantityDataGridViewTextBoxColumn
            // 
            this.bookingQuantityDataGridViewTextBoxColumn.DataPropertyName = "BookingQuantity";
            this.bookingQuantityDataGridViewTextBoxColumn.HeaderText = "BookingQuantity";
            this.bookingQuantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bookingQuantityDataGridViewTextBoxColumn.Name = "bookingQuantityDataGridViewTextBoxColumn";
            this.bookingQuantityDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateBookingDataGridViewTextBoxColumn
            // 
            this.dateBookingDataGridViewTextBoxColumn.DataPropertyName = "DateBooking";
            this.dateBookingDataGridViewTextBoxColumn.HeaderText = "DateBooking";
            this.dateBookingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateBookingDataGridViewTextBoxColumn.Name = "dateBookingDataGridViewTextBoxColumn";
            this.dateBookingDataGridViewTextBoxColumn.Width = 200;
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            this.carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            this.carTypeDataGridViewTextBoxColumn.HeaderText = "CarType";
            this.carTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            this.carTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // seatDataGridViewTextBoxColumn
            // 
            this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
            this.seatDataGridViewTextBoxColumn.HeaderText = "Seat";
            this.seatDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            this.seatDataGridViewTextBoxColumn.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.Width = 200;
            // 
            // tbInvoiceTicket2BindingSource
            // 
            this.tbInvoiceTicket2BindingSource.DataMember = "tbInvoiceTicket2";
            this.tbInvoiceTicket2BindingSource.DataSource = this.transportandLogisticDataSet23;
            // 
            // transportandLogisticDataSet23
            // 
            this.transportandLogisticDataSet23.DataSetName = "TransportandLogisticDataSet23";
            this.transportandLogisticDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInvoiceTicketBindingSource
            // 
            this.tbInvoiceTicketBindingSource.DataMember = "tbInvoiceTicket";
            this.tbInvoiceTicketBindingSource.DataSource = this.transportandLogisticDataSet21;
            // 
            // transportandLogisticDataSet21
            // 
            this.transportandLogisticDataSet21.DataSetName = "TransportandLogisticDataSet21";
            this.transportandLogisticDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1169, 988);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 50);
            this.btnExit.TabIndex = 179;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentID.Location = new System.Drawing.Point(878, 771);
            this.txtPaymentID.Multiline = true;
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(538, 43);
            this.txtPaymentID.TabIndex = 194;
            this.txtPaymentID.TextChanged += new System.EventHandler(this.txtpaymentID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(626, 771);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 193;
            this.label4.Text = "Payment ID :";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1467, 1088);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(206, 43);
            this.btnSearch.TabIndex = 195;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(878, 837);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(538, 43);
            this.txtAmount.TabIndex = 197;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(675, 837);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 196;
            this.label5.Text = "Amount :";
            // 
            // cboSeat
            // 
            this.cboSeat.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboSeat.FormattingEnabled = true;
            this.cboSeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.cboSeat.Location = new System.Drawing.Point(379, 233);
            this.cboSeat.Name = "cboSeat";
            this.cboSeat.Size = new System.Drawing.Size(408, 57);
            this.cboSeat.TabIndex = 216;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(184, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 33);
            this.label16.TabIndex = 215;
            this.label16.Text = "Seat :";
            // 
            // txtBookingQuantity
            // 
            this.txtBookingQuantity.Location = new System.Drawing.Point(379, 107);
            this.txtBookingQuantity.Multiline = true;
            this.txtBookingQuantity.Name = "txtBookingQuantity";
            this.txtBookingQuantity.ReadOnly = true;
            this.txtBookingQuantity.Size = new System.Drawing.Size(408, 44);
            this.txtBookingQuantity.TabIndex = 214;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(1200, 1123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 33);
            this.label13.TabIndex = 213;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(50, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 33);
            this.label11.TabIndex = 211;
            this.label11.Text = "Booking Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(91, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 33);
            this.label9.TabIndex = 210;
            this.label9.Text = "Booking Date : ";
            // 
            // DateBooking
            // 
            this.DateBooking.Location = new System.Drawing.Point(379, 47);
            this.DateBooking.Name = "DateBooking";
            this.DateBooking.Size = new System.Drawing.Size(408, 38);
            this.DateBooking.TabIndex = 203;
            // 
            // cboCarType
            // 
            this.cboCarType.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Items.AddRange(new object[] {
            "Van",
            "Bus",
            "VIP"});
            this.cboCarType.Location = new System.Drawing.Point(379, 163);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(408, 57);
            this.cboCarType.TabIndex = 208;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(137, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 33);
            this.label7.TabIndex = 202;
            this.label7.Text = "Car Type : ";
            // 
            // DateBack
            // 
            this.DateBack.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateBack.Location = new System.Drawing.Point(1328, 235);
            this.DateBack.Name = "DateBack";
            this.DateBack.Size = new System.Drawing.Size(552, 57);
            this.DateBack.TabIndex = 205;
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
            this.cboDestination.Location = new System.Drawing.Point(1328, 97);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(552, 57);
            this.cboDestination.TabIndex = 207;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1032, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 33);
            this.label6.TabIndex = 198;
            this.label6.Text = "Departure From : ";
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
            this.cboDepartureFrom.Location = new System.Drawing.Point(1328, 26);
            this.cboDepartureFrom.Name = "cboDepartureFrom";
            this.cboDepartureFrom.Size = new System.Drawing.Size(552, 57);
            this.cboDepartureFrom.TabIndex = 206;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(1032, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 33);
            this.label12.TabIndex = 199;
            this.label12.Text = "Destination : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(1032, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 33);
            this.label14.TabIndex = 200;
            this.label14.Text = "Date Going  : ";
            // 
            // DateGoing
            // 
            this.DateGoing.Font = new System.Drawing.Font("Arial", 16.125F);
            this.DateGoing.Location = new System.Drawing.Point(1328, 173);
            this.DateGoing.Name = "DateGoing";
            this.DateGoing.Size = new System.Drawing.Size(552, 57);
            this.DateGoing.TabIndex = 204;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(1037, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 33);
            this.label15.TabIndex = 201;
            this.label15.Text = "Date Back :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboSeat);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtBookingQuantity);
            this.panel1.Controls.Add(this.cboCarType);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.DateBooking);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cboDepartureFrom);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboDestination);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DateGoing);
            this.panel1.Controls.Add(this.DateBack);
            this.panel1.Location = new System.Drawing.Point(185, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1962, 302);
            this.panel1.TabIndex = 217;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(197, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 31);
            this.label8.TabIndex = 218;
            this.label8.Text = "Booking Detail";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(873, 988);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(198, 50);
            this.btnCreate.TabIndex = 219;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbInvoiceTicketTableAdapter
            // 
            this.tbInvoiceTicketTableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(671, 906);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 31);
            this.label17.TabIndex = 220;
            this.label17.Text = "Status ";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Arial", 16.125F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending Payment"});
            this.cboStatus.Location = new System.Drawing.Point(875, 906);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(541, 57);
            this.cboStatus.TabIndex = 217;
            // 
            // tbInvoiceTicket2TableAdapter
            // 
            this.tbInvoiceTicket2TableAdapter.ClearBeforeFill = true;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2318, 1559);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.txtTicketID);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceTicket2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet21)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSeat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBookingQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateBooking;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateBack;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDepartureFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DateGoing;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreate;
        private TransportandLogisticDataSet21 transportandLogisticDataSet21;
        private System.Windows.Forms.BindingSource tbInvoiceTicketBindingSource;
        private TransportandLogisticDataSet21TableAdapters.tbInvoiceTicketTableAdapter tbInvoiceTicketTableAdapter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboStatus;
        private TransportandLogisticDataSet23 transportandLogisticDataSet23;
        private System.Windows.Forms.BindingSource tbInvoiceTicket2BindingSource;
        private TransportandLogisticDataSet23TableAdapters.tbInvoiceTicket2TableAdapter tbInvoiceTicket2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}