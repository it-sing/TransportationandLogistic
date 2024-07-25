using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    public partial class FrmBookingReport : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        public FrmBookingReport()
        {
            InitializeComponent();
            CustomizeDataGridView();
        }

        private void FrmBookingReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportandLogisticDataSet19.tbBookingInfo' table. You can move, or remove it, as needed.
            this.tbBookingInfoTableAdapter.Fill(this.transportandLogisticDataSet19.tbBookingInfo);
            // TODO: This line of code loads data into the 'transportandLogisticDataSet4.tbCustomerBookingInformation' table. You can move, or remove it, as needed.
            //this.tbCustomerBookingInformationTableAdapter.Fill(this.transportandLogisticDataSet19.tbBookingInfo);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateBooking = dateTimePicker1.Value.Date;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetBookingInfoByDateBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@DateBooking", dateBooking);

                        connection.Open();

                        // Execute query
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind DataTable to DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                RefreshDataGridView();
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
                this.tbBookingInfoTableAdapter.Fill(this.transportandLogisticDataSet19.tbBookingInfo);
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
        private void CustomizeDataGridView()
        {

            dataGridView1.Font = new Font("Arial", 11);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
