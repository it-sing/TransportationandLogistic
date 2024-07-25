using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    public partial class FrmStaffPaywage : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";

        public FrmStaffPaywage()
        {
            InitializeComponent();
        }

        private void FrmStaffPaywage_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            // Load data into datasets
            this.tbStaffInfoTableAdapter3.Fill(this.transportandLogisticDataSet10.tbStaffInfo);
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int staffID;
            if (!int.TryParse(txtStaffID.Text, out staffID))
            {
                MessageBox.Show("Please enter a valid staff ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Parse salary input
                if (!decimal.TryParse(txtSalary.Text, out decimal salary))
                {
                    MessageBox.Show("Please enter a valid salary amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE tbStaffInfo
                             SET Salary = @Salary,
                                 SalaryDate = @SalaryDate
                             WHERE StaffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@SalaryDate", dateTimePicker1.Value.Date);

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void RefreshDataGridView()
        {
            // Reload data into DataGridView
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtStaffID.Text = row.Cells[0].Value.ToString();
                txtSalary.Text = row.Cells[6].Value.ToString();

                // Convert the value from row.Cells[7] to DateTime
                if (DateTime.TryParse(row.Cells[7].Value.ToString(), out DateTime salaryDate))
                {
                    dateTimePicker1.Value = salaryDate;
                }
                else
                {
                    MessageBox.Show("Invalid date format in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Handle the error or provide default behavior
                    dateTimePicker1.Value = DateTime.Today; // Default to today's date or another appropriate default
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtStaffID.Text = txtSalary.Text= "";
           dateTimePicker1.Value = DateTime.Now;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
