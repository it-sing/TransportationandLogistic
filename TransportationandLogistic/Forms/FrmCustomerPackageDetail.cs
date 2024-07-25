using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    public partial class FrmCustomerPackageDetail : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        public FrmCustomerPackageDetail()
        {
            InitializeComponent();
        }

        private void FrmCustomerPackageDetail_Load(object sender, EventArgs e)
        {
        
            this.tbPackageTableAdapter1.Fill(this.transportandLogisticDataSet29.tbPackage);
           

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if TicketID is provided and valid
            if (!int.TryParse(txtSearch.Text, out int PackageID))
            {
                MessageBox.Show("Please enter a valid Package ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetPackageInfoByPackageID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@PackageID", PackageID);

                        connection.Open();

                        // Execute query
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind DataTable to DataGridView
                            dataGridView1.DataSource = dataTable;
                            RefreshDataGridView();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Refresh the DataGridView by loading data from the database
                this.tbPackageTableAdapter.Fill(this.transportandLogisticDataSet18.tbPackage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
