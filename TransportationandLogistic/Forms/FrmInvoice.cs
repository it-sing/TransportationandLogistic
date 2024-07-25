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
    public partial class FrmInvoice : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
       

        public FrmInvoice()
        {
            InitializeComponent();
          
        }
        private void txtTicketID_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtTicketID.Text, out int TicketID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("GetBookingInfoByTicketID", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TicketID", TicketID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {

                            DateBooking.Value = Convert.ToDateTime(reader["DateBooking"]);
                            txtBookingQuantity.Text = reader["BookingQuantity"].ToString();
                            cboCarType.SelectedItem = reader["CarType"].ToString();
                            cboSeat.SelectedItem = reader["Seat"].ToString();
                            cboDepartureFrom.SelectedItem = reader["DepartureFrom"].ToString();
                            cboDestination.SelectedItem = reader["Destination"].ToString();
                            DateGoing.Value = Convert.ToDateTime(reader["DateGoing"]);
                            DateBack.Value = Convert.ToDateTime(reader["DateBack"]);

                        }
                        else
                        {
                            MessageBox.Show("StaffID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTicketID.Text = txtBookingQuantity.Text = "";
                            cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = cboCarType.SelectedIndex = cboSeat.SelectedIndex = -1;
                            DateGoing.Value = DateBack.Value = DateBooking.Value = DateTime.Now;
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

                txtTicketID.Text = txtBookingQuantity.Text = "";
                cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = cboCarType.SelectedIndex = cboSeat.SelectedIndex = -1;
                DateGoing.Value = DateBack.Value = DateBooking.Value = DateTime.Now;
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
                        SqlCommand command = new SqlCommand("GetPaymentInfoByPaymentID", connection);
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
                            MessageBox.Show("CustomerID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.tbInvoiceTicket2TableAdapter.Fill(this.transportandLogisticDataSet23.tbInvoiceTicket2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int ticketID = int.Parse(txtTicketID.Text);
            DateTime dateBooking = DateBooking.Value.Date;
            string departureFrom = cboDepartureFrom.SelectedItem?.ToString();
            string destination = cboDestination.SelectedItem?.ToString();
            DateTime dateGoing = DateGoing.Value.Date;
            DateTime dateBack = DateBack.Value.Date;
            int bookingQuantity = int.Parse(txtBookingQuantity.Text); // Assuming this should be an integer
            string carType = cboCarType.SelectedItem?.ToString();
            string seat = cboSeat.SelectedItem?.ToString();
            string paymentID = txtPaymentID.Text;
            decimal amount = decimal.Parse(txtAmount.Text); // Assuming this should be a decimal
            string status = cboStatus.SelectedItem?.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "InsertTicketBooking"; // Stored procedure name

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@TicketID", ticketID);
                        command.Parameters.AddWithValue("@DateBooking", dateBooking);
                        command.Parameters.AddWithValue("@DepartureFrom", departureFrom);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.Parameters.AddWithValue("@DateGoing", dateGoing);
                        command.Parameters.AddWithValue("@DateBack", dateBack);
                        command.Parameters.AddWithValue("@BookingQuantity", bookingQuantity);
                        command.Parameters.AddWithValue("@CarType", carType);
                        command.Parameters.AddWithValue("@Seat", seat);
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




        private void FrmInvoice_Load(object sender, EventArgs e)
        {
           
            this.tbInvoiceTicket2TableAdapter.Fill(this.transportandLogisticDataSet23.tbInvoiceTicket2);
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if InvoiceNo is provided and valid
            if (!int.TryParse(txtSearch.Text, out int InvoiceNo))
            {
                MessageBox.Show("Please enter a valid Package ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT TicketID, DateBooking, DepartureFrom, Destination, DateGoing, DateBack, BookingQuantity, CarType, Seat, PaymentID, Amount, Status
                             FROM tbInvoiceTicket2
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

