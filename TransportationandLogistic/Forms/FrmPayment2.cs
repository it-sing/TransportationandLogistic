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
using System.Windows.Controls;
using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    public partial class FrmPayment2 : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        public FrmPayment2()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Forms.FrmInvoice2 invoice = new Forms.FrmInvoice2();
            
            // Show FrmPayment as a modal dialog
            invoice.ShowDialog();
            invoice.Size = new Size(2300, 1700);
            this.Hide();

        }
        private void txtPackageID_TextChanged(object sender, EventArgs e)
        {
            // Ensure txtPackageID has a valid integer value
            if (int.TryParse(txtPackageID.Text, out int PackageID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("GetPackageInfoByPackageID", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PackageID", PackageID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtAmount.Text = reader["Amount"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("CustomerID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCustomerID.Text = "";
                            txtAmount.Text = "";

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
                // Handle case where txtCustomerID does not contain a valid integer
                txtCustomerID.Text = "";
                txtAmount.Text = "";

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            int packageID = int.Parse(txtPackageID.Text);
            int customerID = int.Parse(txtCustomerID.Text);
            int staffID = int.Parse(txtStaffID.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            string payment = cboPayment.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("CreatePayment2", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters

                        command.Parameters.AddWithValue("@PackageID", packageID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@PaymentMethod", payment);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Payment created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshDataGridView();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Add validation logic here based on your application requirements
            if (string.IsNullOrWhiteSpace(txtPackageID.Text) || !int.TryParse(txtPackageID.Text, out _))
            {
                MessageBox.Show("Please enter a valid Ticket ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Add similar validations for other fields as needed

            return true;
        }

        private void ClearForm()
        {
            // Clear all input fields

            txtPackageID.Text = "";
            txtCustomerID.Text = "";
            txtPaymentID.Text = "";
            txtAmount.Text = "";
            txtStaffID.Text = "";
            cboPayment.SelectedIndex = -1; // Reset combo box selection
        }


       
        private void txtpaymentID_TextChanged(object sender, EventArgs e)
        {
            // Ensure txtPaymentID has a valid integer value
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
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtStaffID.Text = reader["StaffID"].ToString();
                            txtAmount.Text = reader["Amount"].ToString();
                            txtPackageID.Text = reader["PackageID"].ToString();
                            cboPayment.SelectedItem = reader["PaymentMethod"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("PaymentID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtStaffID.Text = txtAmount.Text = txtCustomerID.Text = txtPaymentID.Text = txtPackageID.Text = "";
                            cboPayment.SelectedIndex = -1;

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

                txtStaffID.Text = txtAmount.Text = txtCustomerID.Text = txtPaymentID.Text = txtPackageID.Text = "";
                cboPayment.SelectedIndex = -1;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input fields (you can add more validations as needed)
            if (!ValidateInput())
            {
                return;
            }

            // Retrieve values from form controls
            int paymentID = int.Parse(txtPaymentID.Text); // Assuming you have a textbox txtPaymentID for Payment ID
            int packageID = int.Parse(txtPackageID.Text);
            int customerID = int.Parse(txtCustomerID.Text);
            int staffID = int.Parse(txtStaffID.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            string payment = cboPayment.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdatePayment2", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@PaymentID", paymentID);

                        command.Parameters.AddWithValue("@PackageID", packageID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@PaymentMethod", payment);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Payment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshDataGridView();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPayment2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportandLogisticDataSet28.tbPayment2' table. You can move, or remove it, as needed.
            this.tbPayment2TableAdapter.Fill(this.transportandLogisticDataSet28.tbPayment2);
            

        }
        private void RefreshDataGridView()
        {
            try
            {
                // Refresh the DataGridView by loading data from the database
                this.tbPayment2TableAdapter.Fill(this.transportandLogisticDataSet28.tbPayment2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
