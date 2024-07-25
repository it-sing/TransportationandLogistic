using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    public partial class FrmPackageinfo : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        private SqlConnection connection;

        public FrmPackageinfo()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString); 
            connection.Open(); // Open the connection
            CustomizeDataGridView();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Forms.FrmPayment2 paymentForm2 = new Forms.FrmPayment2();

            this.Hide(); // Hide the current form (FrmBookinginfo)
            paymentForm2.ShowDialog(); // Show FrmPayment2 as a modal dialog
            paymentForm2.Size = new Size(1700, 1700);
         

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            decimal packageWeight = decimal.Parse(txtPackageWeight.Text);
            string departureFrom = cboDepartureFrom.SelectedItem.ToString();
            string destination = cboDestination.SelectedItem.ToString();
            DateTime dateGoing = DateGoing.Value.Date;
            DateTime dateArrive = DateArrive.Value.Date;
            int customerID = int.Parse(txtCustomerID.Text);
            string senderName = txtSenderName.Text;
            string receiverName = txtReceiverName.Text;
            string senderPhoneNum = txtSenderPhoneNum.Text;
            string receiverPhoneNum = txtReceiverPhoneNum.Text;
            string amount = txtAmount.Text; 


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreatePackage";

                // Add parameters based on your stored procedure parameters
                cmd.Parameters.AddWithValue("@PackageWeight", packageWeight);
                cmd.Parameters.AddWithValue("@DepartureFrom", departureFrom);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@DateGoing", dateGoing);
                cmd.Parameters.AddWithValue("@DateArrive", dateArrive);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@SenderName", senderName);
                cmd.Parameters.AddWithValue("@ReceiverName", receiverName);
                cmd.Parameters.AddWithValue("@SenderPhoneNum", senderPhoneNum);
                cmd.Parameters.AddWithValue("@ReceiverPhoneNum", receiverPhoneNum);
                cmd.Parameters.AddWithValue("@Amount",amount);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Package created successfully!");
                RefreshDataGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating package: " + ex.Message);
            }
        }

        private void FrmPackageinfo_Load(object sender, EventArgs e)
        {
            //loads data into the 'transportandLogisticDataSet13.tbPackage' table. You can move, or remove it, as needed.
            this.tbPackageTableAdapter.Fill(this.transportandLogisticDataSet13.tbPackage);
            RefreshDataGridView();

        }
        private void RefreshDataGridView()
        {
            try
            {
                // Refresh the DataGridView by loading data from the database
                this.tbPackageTableAdapter.Fill(this.transportandLogisticDataSet13.tbPackage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtSenderName.Text = reader["SenderName"].ToString();
                            txtReceiverName.Text = reader["ReceiverName"].ToString();
                            txtSenderPhoneNum.Text = reader["SenderPhoneNum"].ToString();
                            txtReceiverPhoneNum.Text = reader["ReceiverPhoneNum"].ToString();
                            txtAmount.Text = reader["Amount"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("StaffID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPackageWeight.Text = txtCustomerID.Text = txtSenderName.Text = txtReceiverName.Text = txtSenderPhoneNum.Text = txtReceiverPhoneNum.Text =txtAmount.Text = "";
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
                txtPackageWeight.Text = txtCustomerID.Text = txtSenderName.Text = txtReceiverName.Text = txtSenderPhoneNum.Text = txtReceiverPhoneNum.Text = txtAmount.Text = "";
                cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = -1;
                DateGoing.Value = DateArrive.Value = DateTime.Now;
            }
        }

       private void btnUpdate_Click(object sender, EventArgs e)
        {
            int packageID;
            if (!int.TryParse(txtPackageID.Text, out packageID))
            {
                MessageBox.Show("Please enter a valid Package ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve values from form controls
            decimal packageWeight = decimal.Parse(txtPackageWeight.Text);
            string departureFrom = cboDepartureFrom.SelectedItem.ToString();
            string destination = cboDestination.SelectedItem.ToString();
            DateTime dateGoing = DateGoing.Value.Date;
            DateTime dateArrive = DateArrive.Value.Date;
            int customerID = int.Parse(txtCustomerID.Text);
            string senderName = txtSenderName.Text;
            string receiverName = txtReceiverName.Text;
            string senderPhoneNum = txtSenderPhoneNum.Text;
            string receiverPhoneNum = txtReceiverPhoneNum.Text;
            string amount = txtAmount.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdatePackage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PackageID", packageID);
                        command.Parameters.AddWithValue("@PackageWeight", packageWeight);
                        command.Parameters.AddWithValue("@DepartureFrom", departureFrom);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.Parameters.AddWithValue("@DateGoing", dateGoing);
                        command.Parameters.AddWithValue("@DateArrive", dateArrive);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@SenderName", senderName);
                        command.Parameters.AddWithValue("@ReceiverName", receiverName);
                        command.Parameters.AddWithValue("@SenderPhoneNum", senderPhoneNum);
                        command.Parameters.AddWithValue("@ReceiverPhoneNum", receiverPhoneNum);
                        command.Parameters.AddWithValue("@Amount",amount);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Package information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No record updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPackageID.Text =txtPackageWeight.Text = txtCustomerID.Text = txtSenderName.Text = txtReceiverName.Text = txtSenderPhoneNum.Text = txtReceiverPhoneNum.Text = txtAmount.Text = "";
            cboDepartureFrom.SelectedIndex = cboDestination.SelectedIndex = -1;
            DateGoing.Value = DateArrive.Value = DateTime.Now; ;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPackageWeight_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPackageWeight.Text, out decimal packageWeight))
            {
                
                if (packageWeight >= 1 && packageWeight <= 20)
                {
                    // Calculate the amount based on the package weight (assuming 4000 riel per kg)
                    decimal amount = packageWeight * 4000;

                    // Display the calculated amount in txtAmount
                    txtAmount.Text = amount.ToString();
                }
                else
                {
           
                    MessageBox.Show("Package weight must be between 1kg and 20kg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Text = "";
                }
            }
            else
            {
                // If txtPackageWeight does not contain a valid decimal number, handle the error
                MessageBox.Show("Please enter a valid package weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Text = ""; 
            }

        }
        private void CustomizeDataGridView()
        {

            dataGridView1.Font = new Font("Arial", 11);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         
        }
       

        
    }
}