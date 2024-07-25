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
using System.Windows.Forms.VisualStyles;

namespace TransportationandLogistic.Forms
{
    public partial class FrmBookinginfo : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        private SqlConnection connection;
        private DataGridViewCellEventHandler dataGridView1_CellClick;

        public object transportandLogisticDataSet13 { get; private set; }

        public FrmBookinginfo()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString); // Initialize SqlConnection object
            connection.Open(); // Open the connection
            CustomizeDataGridView();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Forms.FrmPayment paymentForm = new Forms.FrmPayment();
            this.Hide();
            paymentForm.ShowDialog();
            paymentForm.Size = new Size(1700, 1700);
          


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTicketID.Text = txtCustomerName.Text = txtPhoneNumber.Text = txtBookingQuantity.Text = txtCustomerID.Text="";
            cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = cboCarType.SelectedIndex = cboSeat.SelectedIndex = -1;
            DateGoing.Value = DateBack.Value = DateBooking.Value = DateTime.Now;
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Refresh the DataGridView by loading data from the database
                this.tbBookingInfoTableAdapter.Fill(this.transportandLogisticDataSet14.tbBookingInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DateTime dateBooking = DateBooking.Value.Date;
            string departureFrom = cboDepartureFrom.SelectedItem.ToString();
            string destination = cboDestination.SelectedItem.ToString();
            DateTime dateGoing = DateGoing.Value.Date;
            DateTime dateBack = DateBack.Value.Date;
            int customerID = int.Parse(txtCustomerID.Text);
            string customerName = txtCustomerName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string bookingQuantity = txtBookingQuantity.Text;
            string carType = cboCarType.SelectedItem.ToString();
            string seat = cboSeat.SelectedItem.ToString();
            string Amount = txtAmount.Text;


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateBooking";

                // Add parameters based on your stored procedure parameters
                cmd.Parameters.AddWithValue("@DateBooking", dateBooking);
                cmd.Parameters.AddWithValue("@DepartureFrom", departureFrom);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@DateGoing", dateGoing);
                cmd.Parameters.AddWithValue("@DateBack", dateBack);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@CustomerPhoneNum", phoneNumber);
                cmd.Parameters.AddWithValue("@BookingQuantity", bookingQuantity);
                cmd.Parameters.AddWithValue("@CarType", carType);
                cmd.Parameters.AddWithValue("@Seat", seat);
                cmd.Parameters.AddWithValue("@Amount",Amount);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Ticket created successfully!");
                RefreshDataGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating Ticket: " + ex.Message);
            }
        }

        private void FrmBookinginfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportandLogisticDataSet14.tbBookingInfo' table. You can move, or remove it, as needed.
            this.tbBookingInfoTableAdapter.Fill(this.transportandLogisticDataSet14.tbBookingInfo);

        }
        private void txtTicketID_TextChanged(object sender, EventArgs e)
        {
            // Ensure txtStaffID has a valid integer value
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
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtCustomerName.Text = reader["CustomerName"].ToString();
                            txtPhoneNumber.Text = reader["CustomerPhoneNum"].ToString();
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
                            MessageBox.Show("Ticket ID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTicketID.Text = txtCustomerName.Text = txtPhoneNumber.Text = txtBookingQuantity.Text = "";
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
                // Handle case where txtStaffID does not contain a valid integer
                txtTicketID.Text = txtCustomerName.Text = txtPhoneNumber.Text = txtBookingQuantity.Text = "";
                cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = cboCarType.SelectedIndex = cboSeat.SelectedIndex = -1;
                DateGoing.Value = DateBack.Value = DateBooking.Value = DateTime.Now;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int TicketID;
            if (!int.TryParse(txtTicketID.Text, out TicketID))
            {
                MessageBox.Show("Please enter a valid Ticket ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve other values from form controls
            DateTime dateBooking = DateBooking.Value.Date;
            string departureFrom = cboDepartureFrom.SelectedItem.ToString();
            string destination = cboDestination.SelectedItem.ToString();
            DateTime dateGoing = DateGoing.Value.Date;
            DateTime dateBack = DateBack.Value.Date;
            int customerID = int.Parse(txtCustomerID.Text);
            string customerName = txtCustomerName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string bookingQuantity = txtBookingQuantity.Text;
            string carType = cboCarType.SelectedItem.ToString();
            string seat = cboSeat.SelectedItem.ToString();
            string amount = txtAmount.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdateBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@TicketID", TicketID);
                        command.Parameters.AddWithValue("@DateBooking", dateBooking);
                        command.Parameters.AddWithValue("@BookingQuantity", bookingQuantity);
                        command.Parameters.AddWithValue("@CarType", carType);
                        command.Parameters.AddWithValue("@Seat", seat);
                        command.Parameters.AddWithValue("@DepartureFrom", departureFrom);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.Parameters.AddWithValue("@DateGoing", dateGoing);
                        command.Parameters.AddWithValue("@DateBack", dateBack);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@CustomerPhoneNum", phoneNumber);
                        command.Parameters.AddWithValue("Amount",amount);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ticket information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No record updated. Check the Ticket ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void cboCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            cboSeat.Items.Clear();


            string selectedVehicleType = cboCarType.SelectedItem?.ToString();

  
            if (selectedVehicleType == "VIP")
            {
                for (int i = 1; i <= 5; i++)
                {
                    cboSeat.Items.Add(i.ToString());
                }
                txtAmount.Text = "100000"; 
            }
            else if (selectedVehicleType == "Bus")
            {
                for (int i = 1; i <= 50; i++)
                {
                    cboSeat.Items.Add(i.ToString());
                }
                txtAmount.Text = "40000"; 
            }
            else if (selectedVehicleType == "Van")
            {
                for (int i = 1; i <= 15; i++)
                {
                    cboSeat.Items.Add(i.ToString());
                }
                txtAmount.Text = "60000"; 
            }
            else
            {
                txtAmount.Text = ""; // Handle other cases if needed
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            // Leave this method empty, as per your requirement
        }

        private void txtBookingQuantity_TextChanged(object sender, EventArgs e)
        {
          
            txtBookingQuantity.ReadOnly = true;
            txtBookingQuantity.Text = "1";

        }
        private void CustomizeDataGridView()
        {
            
            dataGridView1.Font = new Font("Arial", 11);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;       
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
        }
        
    }
}