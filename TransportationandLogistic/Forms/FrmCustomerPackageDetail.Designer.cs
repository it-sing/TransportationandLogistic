namespace TransportationandLogistic.Forms
{
    partial class FrmCustomerPackageDetail
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
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGoingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPackageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet29 = new TransportationandLogistic.TransportandLogisticDataSet29();
            this.tbPackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportandLogisticDataSet18 = new TransportationandLogistic.TransportandLogisticDataSet18();
            this.tbPackageTableAdapter = new TransportationandLogistic.TransportandLogisticDataSet18TableAdapters.tbPackageTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbPackageTableAdapter1 = new TransportationandLogistic.TransportandLogisticDataSet29TableAdapters.tbPackageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet18)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(901, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(473, 49);
            this.label10.TabIndex = 70;
            this.label10.Text = "Customer Packgae info";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 16.125F);
            this.txtSearch.Location = new System.Drawing.Point(1053, 251);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(483, 42);
            this.txtSearch.TabIndex = 159;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(693, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(316, 33);
            this.label12.TabIndex = 158;
            this.label12.Text = "Search by Package ID :";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1930, 1401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(363, 60);
            this.btnExit.TabIndex = 160;
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
            this.packageIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.packageWeightDataGridViewTextBoxColumn,
            this.Amount,
            this.departureFromDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.dateGoingDataGridViewTextBoxColumn,
            this.dateArriveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbPackageBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(358, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1695, 911);
            this.dataGridView1.TabIndex = 161;
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
            // tbPackageBindingSource1
            // 
            this.tbPackageBindingSource1.DataMember = "tbPackage";
            this.tbPackageBindingSource1.DataSource = this.transportandLogisticDataSet29;
            // 
            // transportandLogisticDataSet29
            // 
            this.transportandLogisticDataSet29.DataSetName = "TransportandLogisticDataSet29";
            this.transportandLogisticDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPackageBindingSource
            // 
            this.tbPackageBindingSource.DataMember = "tbPackage";
            this.tbPackageBindingSource.DataSource = this.transportandLogisticDataSet18;
            // 
            // transportandLogisticDataSet18
            // 
            this.transportandLogisticDataSet18.DataSetName = "TransportandLogisticDataSet18";
            this.transportandLogisticDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPackageTableAdapter
            // 
            this.tbPackageTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.btnSearch.Location = new System.Drawing.Point(1573, 251);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(214, 42);
            this.btnSearch.TabIndex = 162;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbPackageTableAdapter1
            // 
            this.tbPackageTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmCustomerPackageDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2354, 1471);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCustomerPackageDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomerPackageDetail";
            this.Load += new System.EventHandler(this.FrmCustomerPackageDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPackageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportandLogisticDataSet18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportandLogisticDataSet18 transportandLogisticDataSet18;
        private System.Windows.Forms.BindingSource tbPackageBindingSource;
        private TransportandLogisticDataSet18TableAdapters.tbPackageTableAdapter tbPackageTableAdapter;
        private System.Windows.Forms.Button btnSearch;
        private TransportandLogisticDataSet29 transportandLogisticDataSet29;
        private System.Windows.Forms.BindingSource tbPackageBindingSource1;
        private TransportandLogisticDataSet29TableAdapters.tbPackageTableAdapter tbPackageTableAdapter1;
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