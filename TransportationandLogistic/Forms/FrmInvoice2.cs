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
    public partial class FrmInvoice2 : Form
    {

        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        public FrmInvoice2()
        {
            InitializeComponent();
        }

        private void FrmInvoice2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportandLogisticDataSet32.tbInvoicePackage2' table. You can move, or remove it, as needed.
            this.tbInvoicePackage2TableAdapter1.Fill(this.transportandLogisticDataSet32.tbInvoicePackage2);
            

        }
        private void txtPackageID_TextChanged(object sender, EventArgs e)
        {
            // Ensure txtStaffID has a valid integer value
            if (int.TryParse(txtPackageID.Text, out int staffID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("GetPackageInfoByPackageID", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PackageID", staffID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtPackageWeight.Text = reader["PackageWeight"].ToString();
                            cboDepartureFrom.SelectedItem = reader["DepartureFrom"].ToString();
                            cboDestination.SelectedItem = reader["Destination"].ToString();
                            DateGoing.Value = Convert.ToDateTime(reader["DateGoing"]);
                            DateArrive.Value = Convert.ToDateTime(reader["DateArrive"]);

                        }
                        else
                        {
                            MessageBox.Show("StaffID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPackageWeight.Text = "";
                            cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = -1;
                            DateGoing.Value = DateArrive.Value = DateTime.Now;
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle case where txtStaffID does not contain a valid integer
                txtPackageWeight.Text = "";
                cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = -1;
                DateGoing.Value = DateArrive.Value = DateTime.Now;
            }
        }
        private void txtpaymentID_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtPaymentID.Text, out int paymentID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("GePaymentInfoByPaymentID2", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@paymentID", paymentID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {

                            txtAmount.Text = reader["Amount"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("PaymentID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAmount.Text = txtPaymentID.Text = "";


                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                txtAmount.Text = txtPaymentID.Text = "";

            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Refresh the DataGridView by loading data from the database
                this.tbInvoicePackage2TableAdapter1.Fill(this.transportandLogisticDataSet32.tbInvoicePackage2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int packageID = int.Parse(txtPackageID.Text);
            decimal packageWeight = decimal.Parse(txtPackageWeight.Text);
            string departureFrom = cboDepartureFrom.SelectedItem?.ToString();
            string destination = cboDestination.SelectedItem?.ToString();
            DateTime dateGoing = DateGoing.Value.Date;
            DateTime dateArrive = DateArrive.Value.Date;
            string paymentID = txtPaymentID.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            string status = cboStatus.SelectedItem?.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "InsertPackageInvoice"; // Stored procedure name

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@PackageID", packageID);
                        command.Parameters.AddWithValue("@PackageWeight", packageWeight);
                        command.Parameters.AddWithValue("@DepartureFrom", departureFrom);
                        command.Parameters.AddWithValue("@DateArrive", dateArrive);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.Parameters.AddWithValue("@DateGoing", dateGoing);
                        command.Parameters.AddWithValue("@PaymentID", paymentID);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Status", status);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView(); // Assuming you have a method to refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if PackageID is provided and valid
            if (!int.TryParse(txtSearch.Text, out int InvoiceNo))
            {
                MessageBox.Show("Please enter a valid Package ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT PackageID, PackageWeight, DepartureFrom, Destination, DateGoing, DateArrive
                             FROM tbInvoicePackage2
                             WHERE InvoiceNo = @InvoiceNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
