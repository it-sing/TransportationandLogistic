namespace TransportationandLogistic.Forms
{
    partial class FrmPackageReport
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
            this.tbCustomerPackageInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet5 = new TransportationandLogistic.TransportandLogisticDataSet5();
            this.transportandLogisticDataSet3 = new TransportationandLogistic.TransportandLogisticDataSet3();
            this.tbCustomerBookingInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCustomerBookingInformationTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet3TableAdapters.tbCustomerBookingInformationTableAdapter();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCustomerPackageInformationTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet5TableAdapters.tbCustomerPackageInformationTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.transportandLogisticDataSet15 = new TransportationandLogistic.TransportandLogisticDataSet15();
            this.tbPackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPackageTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet15TableAdapters.tbPackageTableAdapter();
            this.transportandLogisticDataSet16 = new TransportationandLogistic.TransportandLogisticDataSet16();
            this.tbPackageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbPackageTableAdapter1 = new TransportationandLogistic.TransportandLogisticDataSet16TableAdapters.tbPackageTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGoingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPackageBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet30 = new TransportationandLogistic.TransportandLogisticDataSet30();
            this.tbPackageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet20 = new TransportationandLogistic.TransportandLogisticDataSet20();
            this.tbPackageTableAdapter2 = new TransportationandLogistic.TransportandLogisticDataSet20TableAdapters.tbPackageTableAdapter();
            this.tbPackageTableAdapter3 = new TransportationandLogistic.TransportandLogisticDataSet30TableAdapters.tbPackageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomerPackageInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomerBookingInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCustomerPackageInformationBindingSource
            // 
            this.tbCustomerPackageInformationBindingSource.DataMember = "tbCustomerPackageInformation";
            this.tbCustomerPackageInformationBindingSource.DataSource = this.transportandLogisticDataSet5;
            // 
            // transportandLogisticDataSet5
            // 
            this.transportandLogisticDataSet5.DataSetName = "TransportandLogisticDataSet5";
            this.transportandLogisticDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportandLogisticDataSet3
            // 
            this.transportandLogisticDataSet3.DataSetName = "TransportandLogisticDataSet3";
            this.transportandLogisticDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCustomerBookingInformationBindingSource
            // 
            this.tbCustomerBookingInformationBindingSource.DataMember = "tbCustomerBookingInformation";
            this.tbCustomerBookingInformationBindingSource.DataSource = this.transportandLogisticDataSet3;
            // 
            // tbCustomerBookingInformationTableAdapter
            // 
            this.tbCustomerBookingInformationTableAdapter.ClearBeforeFill = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(584, 177);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(225, 36);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search by date";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(965, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(332, 49);
            this.label10.TabIndex = 105;
            this.label10.Text = "Package Report";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbCustomerPackageInformationTableAdapter
            // 
            this.tbCustomerPackageInformationTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 16.125F);
            this.dateTimePicker1.Location = new System.Drawing.Point(652, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(560, 57);
            this.dateTimePicker1.TabIndex = 106;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1303, 224);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(198, 50);
            this.btnSearch.TabIndex = 119;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1820, 1246);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(276, 64);
            this.btnExit.TabIndex = 122;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // transportandLogisticDataSet15
            // 
            this.transportandLogisticDataSet15.DataSetName = "TransportandLogisticDataSet15";
            this.transportandLogisticDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPackageBindingSource
            // 
            this.tbPackageBindingSource.DataMember = "tbPackage";
            this.tbPackageBindingSource.DataSource = this.transportandLogisticDataSet15;
            // 
            // tbPackageTableAdapter
            // 
            this.tbPackageTableAdapter.ClearBeforeFill = true;
            // 
            // transportandLogisticDataSet16
            // 
            this.transportandLogisticDataSet16.DataSetName = "TransportandLogisticDataSet16";
            this.transportandLogisticDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPackageBindingSource1
            // 
            this.tbPackageBindingSource1.DataMember = "tbPackage";
            this.tbPackageBindingSource1.DataSource = this.transportandLogisticDataSet16;
            // 
            // tbPackageTableAdapter1
            // 
            this.tbPackageTableAdapter1.ClearBeforeFill = true;
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
            this.Amount,
            this.departureFromDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.dateGoingDataGridViewTextBoxColumn,
            this.dateArriveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbPackageBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(321, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1704, 898);
            this.dataGridView1.TabIndex = 123;
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // packageWeightDataGridViewTextBoxColumn
            // 
            this.packageWeightDataGridViewTextBoxColumn.DataPropertyName = "PackageWeight";
            this.packageWeightDataGridViewTextBoxColumn.HeaderText = "PackageWeight";
            this.packageWeightDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.packageWeightDataGridViewTextBoxColumn.Name = "packageWeightDataGridViewTextBoxColumn";
            this.packageWeightDataGridViewTextBoxColumn.Width = 200;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 10;
            this.Amount.Name = "Amount";
            this.Amount.Width = 200;
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
            // tbPackageBindingSource3
            // 
            this.tbPackageBindingSource3.DataMember = "tbPackage";
            this.tbPackageBindingSource3.DataSource = this.transportandLogisticDataSet30;
            // 
            // transportandLogisticDataSet30
            // 
            this.transportandLogisticDataSet30.DataSetName = "TransportandLogisticDataSet30";
            this.transportandLogisticDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPackageBindingSource2
            // 
            this.tbPackageBindingSource2.DataMember = "tbPackage";
            this.tbPackageBindingSource2.DataSource = this.transportandLogisticDataSet20;
            // 
            // transportandLogisticDataSet20
            // 
            this.transportandLogisticDataSet20.DataSetName = "TransportandLogisticDataSet20";
            this.transportandLogisticDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPackageTableAdapter2
            // 
            this.tbPackageTableAdapter2.ClearBeforeFill = true;
            // 
            // tbPackageTableAdapter3
            // 
            this.tbPackageTableAdapter3.ClearBeforeFill = true;
            // 
            // FrmPackageReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2213, 1371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPackageReport";
            this.Text = "FrmPackageReport";
            this.Load += new System.EventHandler(this.FrmPackageReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomerPackageInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomerBookingInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransportandLogisticDataSet3 transportandLogisticDataSet3;
        private System.Windows.Forms.BindingSource tbCustomerBookingInformationBindingSource;
        private TransportandLogisticDataSet3TableAdapters.tbCustomerBookingInformationTableAdapter tbCustomerBookingInformationTableAdapter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label10;
        private TransportandLogisticDataSet5 transportandLogisticDataSet5;
        private System.Windows.Forms.BindingSource tbCustomerPackageInformationBindingSource;
        private TransportandLogisticDataSet5TableAdapters.tbCustomerPackageInformationTableAdapter tbCustomerPackageInformationTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private TransportandLogisticDataSet15 transportandLogisticDataSet15;
        private System.Windows.Forms.BindingSource tbPackageBindingSource;
        private TransportandLogisticDataSet15TableAdapters.tbPackageTableAdapter tbPackageTableAdapter;
        private TransportandLogisticDataSet16 transportandLogisticDataSet16;
        private System.Windows.Forms.BindingSource tbPackageBindingSource1;
        private TransportandLogisticDataSet16TableAdapters.tbPackageTableAdapter tbPackageTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportandLogisticDataSet20 transportandLogisticDataSet20;
        private System.Windows.Forms.BindingSource tbPackageBindingSource2;
        private TransportandLogisticDataSet20TableAdapters.tbPackageTableAdapter tbPackageTableAdapter2;
        private TransportandLogisticDataSet30 transportandLogisticDataSet30;
        private System.Windows.Forms.BindingSource tbPackageBindingSource3;
        private TransportandLogisticDataSet30TableAdapters.tbPackageTableAdapter tbPackageTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGoingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveDataGridViewTextBoxColumn;
    }
}