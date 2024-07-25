using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    public partial class FrmPayment : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Forms.FrmInvoice invoice = new Forms.FrmInvoice();
          

            // Show FrmPayment as a modal dialog
            invoice.ShowDialog();
            invoice.Size = new Size(2300, 1700);
            this.Hide();

        }
        private void txtTicketID_TextChanged(object sender, EventArgs e)
        {
            // Ensure txtTicketID has a valid integer value
            if (int.TryParse(txtTicketID.Text, out int TicketID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("GetBookinginfoByTicketID", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TicketID", TicketID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtAmount.Text = reader["Amount"].ToString();
                            
                        }
                        else
                        {
                            MessageBox.Show("Ticket ID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            

            int ticketID = int.Parse(txtTicketID.Text);
            int customerID = int.Parse(txtCustomerID.Text);
            int staffID = int.Parse(txtStaff.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            string payment= cboPayment.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("CreatePayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                      
                        command.Parameters.AddWithValue("@TicketID", ticketID);
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
            if (string.IsNullOrWhiteSpace(txtTicketID.Text) || !int.TryParse(txtTicketID.Text, out _))
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
        
            txtTicketID.Text = "";
            txtCustomerID.Text = "";
            txtPaymentID.Text = "";
            txtAmount.Text = "";
            txtStaff.Text = "";
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
                        SqlCommand command = new SqlCommand("GetPaymentInfoByPaymentID", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@paymentID", paymentID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtStaff.Text = reader["StaffID"].ToString() ;
                            txtAmount.Text = reader["Amount"].ToString();
                            txtTicketID.Text = reader["TicketID"].ToString();
                            cboPayment.SelectedItem = reader["PaymentMethod"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("CustomerID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtStaff.Text = txtAmount.Text = txtCustomerID.Text = txtPaymentID.Text = txtTicketID.Text = "";
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
                
                txtStaff.Text = txtAmount.Text = txtCustomerID.Text = txtPaymentID.Text = txtTicketID.Text = "";
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
            int ticketID = int.Parse(txtTicketID.Text);
            int customerID = int.Parse(txtCustomerID.Text);
            int staffID = int.Parse(txtStaff.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            string payment = cboPayment.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdatePayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@PaymentID", paymentID);

                        command.Parameters.AddWithValue("@TicketID", ticketID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@PaymentMethod", payment);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Payment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, clear input fields or reset the form
                        ClearForm();
                        RefreshDataGridView();
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

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportandLogisticDataSet27.tbPayment' table. You can move, or remove it, as needed.
            this.tbPaymentTableAdapter.Fill(this.transportandLogisticDataSet27.tbPayment);

        }
        private void RefreshDataGridView()
        {
            try
            {
                // Refresh the DataGridView by loading data from the database
                this.tbPaymentTableAdapter.Fill(this.transportandLogisticDataSet27.tbPayment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
