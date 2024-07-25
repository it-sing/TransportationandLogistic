﻿using System;
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
    public partial class FrmDriverTransport : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        public FrmDriverTransport()
        {
            InitializeComponent();
        }

        private void FrmDriverTransport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportandLogisticDataSet12.DriverTransportSchedule' table. You can move, or remove it, as needed.
            this.driverTransportScheduleTableAdapter.Fill(this.transportandLogisticDataSet12.DriverTransportSchedule);


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtStaffID.Text = "";
            txtStaffNameEn.Text = "";
            DateBack.Value = DateGo.Value = DateTime.Now;
            cboStaffPosition.SelectedIndex = cboCarType.SelectedIndex = cboDepartureFrom.SelectedIndex = cboGoingTo.SelectedIndex = -1;


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            // Ensure txtStaffID has a valid integer value
            if (int.TryParse(txtStaffID.Text, out int staffID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("GetStaffInfoByStaffID", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StaffID", staffID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtStaffNameEn.Text = reader["StaffNameEn"].ToString();
                            cboStaffPosition.Text = reader["StaffPosition"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("StaffID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtStaffNameEn.Text = "";
                            cboStaffPosition.SelectedIndex = -1;
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
                txtStaffNameEn.Text = "";
                cboStaffPosition.SelectedIndex = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve data from form controls
            int staffID;
            if (!int.TryParse(txtStaffID.Text, out staffID))
            {
                MessageBox.Show("Please enter a valid StaffID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string staffNameEn = txtStaffNameEn.Text;
            string staffPosition = cboStaffPosition.SelectedItem?.ToString();
            string departureFrom = cboDepartureFrom.Text;
            string destination = cboGoingTo.Text;
            DateTime goingDate = DateGo.Value;
            DateTime backDate = DateBack.Value;
            string carType = cboCarType.SelectedItem?.ToString();

            // Prepare the SQL INSERT statement
            string insertProcedure = "InsertDriverTransportSchedule";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(insertProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@StaffNameEn", staffNameEn);
                        command.Parameters.AddWithValue("@StaffPosition", staffPosition);
                        command.Parameters.AddWithValue("@DepartureFrom", departureFrom);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.Parameters.AddWithValue("@GoingDate", goingDate);
                        command.Parameters.AddWithValue("@BackDate", backDate);
                        command.Parameters.AddWithValue("@CarType", carType);


                        // Add output parameter for error message
                        command.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, -1);
                        command.Parameters["@ErrorMessage"].Direction = ParameterDirection.Output;

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Check the output parameter for any error message
                        string errorMessage = command.Parameters["@ErrorMessage"].Value.ToString();
                        if (string.IsNullOrEmpty(errorMessage))
                        {
                            // Insert successful
                            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView(); // Refresh DataGridView after insert
                        }
                        else
                        {
                            // Insert failed, show error message
                            MessageBox.Show("Error: " + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmDriverLogistic_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Refresh the DataGridView by loading data from the database
                this.driverTransportScheduleTableAdapter.Fill(this.transportandLogisticDataSet12.DriverTransportSchedule);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
