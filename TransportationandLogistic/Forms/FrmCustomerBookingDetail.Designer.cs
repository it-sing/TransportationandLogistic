namespace TransportationandLogistic.Forms
{
    partial class FrmCustomerBookingDetail
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGoingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBookingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet17 = new TransportationandLogistic.TransportandLogisticDataSet17();
            this.tbBookingInfoTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet17TableAdapters.tbBookingInfoTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBookingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(937, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(461, 49);
            this.label10.TabIndex = 69;
            this.label10.Text = "Customer Booking info";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtSearch.Location = new System.Drawing.Point(1081, 248);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(483, 48);
            this.txtSearch.TabIndex = 157;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(721, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(281, 33);
            this.label12.TabIndex = 156;
            this.label12.Text = "Search by Ticket ID :";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1956, 1374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(363, 60);
            this.btnExit.TabIndex = 159;
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
            this.ticketIDDataGridViewTextBoxColumn,
            this.CustomerID,
            this.dateBookingDataGridViewTextBoxColumn,
            this.bookingQuantityDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn,
            this.seatDataGridViewTextBoxColumn,
            this.departureFromDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.dateGoingDataGridViewTextBoxColumn,
            this.dateBackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbBookingInfoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(166, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2118, 911);
            this.dataGridView1.TabIndex = 158;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 10;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 200;
            // 
            // dateBookingDataGridViewTextBoxColumn
            // 
            this.dateBookingDataGridViewTextBoxColumn.DataPropertyName = "DateBooking";
            this.dateBookingDataGridViewTextBoxColumn.HeaderText = "DateBooking";
            this.dateBookingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateBookingDataGridViewTextBoxColumn.Name = "dateBookingDataGridViewTextBoxColumn";
            this.dateBookingDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookingQuantityDataGridViewTextBoxColumn
            // 
            this.bookingQuantityDataGridViewTextBoxColumn.DataPropertyName = "BookingQuantity";
            this.bookingQuantityDataGridViewTextBoxColumn.HeaderText = "BookingQuantity";
            this.bookingQuantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bookingQuantityDataGridViewTextBoxColumn.Name = "bookingQuantityDataGridViewTextBoxColumn";
            this.bookingQuantityDataGridViewTextBoxColumn.Width = 200;
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
            // dateBackDataGridViewTextBoxColumn
            // 
            this.dateBackDataGridViewTextBoxColumn.DataPropertyName = "DateBack";
            this.dateBackDataGridViewTextBoxColumn.HeaderText = "DateBack";
            this.dateBackDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateBackDataGridViewTextBoxColumn.Name = "dateBackDataGridViewTextBoxColumn";
            this.dateBackDataGridViewTextBoxColumn.Width = 200;
            // 
            // tbBookingInfoBindingSource
            // 
            this.tbBookingInfoBindingSource.DataMember = "tbBookingInfo";
            this.tbBookingInfoBindingSource.DataSource = this.transportandLogisticDataSet17;
            // 
            // transportandLogisticDataSet17
            // 
            this.transportandLogisticDataSet17.DataSetName = "TransportandLogisticDataSet17";
            this.transportandLogisticDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBookingInfoTableAdapter
            // 
            this.tbBookingInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1617, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(221, 48);
            this.btnSearch.TabIndex = 163;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmCustomerBookingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2355, 1466);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCustomerBookingDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomerBookingDetail";
            this.Load += new System.EventHandler(this.FrmCustomerBookingDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBookingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportandLogisticDataSet17 transportandLogisticDataSet17;
        private System.Windows.Forms.BindingSource tbBookingInfoBindingSource;
        private TransportandLogisticDataSet17TableAdapters.tbBookingInfoTableAdapter tbBookingInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGoingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBackDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
    }
}