using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;

namespace TransportationandLogistic.Forms
{
    public partial class Form2 : Form
    {
        private SqlConnection connect = new SqlConnection("Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;");
        private TextBox hiddenUserIdField;

        public Form2()
        {
            InitializeComponent();
            CustomizeDataGridView();
            UserDisplayData();  // Load user data initially

            // Initialize hidden field
            hiddenUserIdField = new TextBox();
            hiddenUserIdField.Visible = false;  // Hide the hidden field
            this.Controls.Add(hiddenUserIdField);  // Add it to the form's controls

            // Add event handler for StaffID textbox
            txtStaffID.Leave += new EventHandler(txtStaffID_Leave);
        }

        private void CustomizeDataGridView()
        {
            // Set the font and size
            dataGridView1.Font = new Font("Arial", 11);
            // Make columns more sizable
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Allow user to resize columns
            dataGridView1.AllowUserToResizeColumns = true;
            // Make column headers sizable
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Add click event for DataGridView
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }
        
        private void txtStaffID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStaffID.Text.Trim()))
            {
                string enteredStaffID = txtStaffID.Text.Trim();

                try
                {
                    connect.Open();
                    string query = "SELECT StaffNameEn, StaffPosition FROM tbStaffInfo WHERE StaffID = @StaffID";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@StaffID", enteredStaffID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtStaffName.Text = reader["StaffNameEn"].ToString();
                        txtStaffPosition.Text = reader["StaffPosition"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Staff ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading staff details: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void UserDisplayData()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM tbUser";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == ""
             || txtPassword.Text == ""
             || txtStaffID.Text == ""
             || txtStaffName.Text == ""
             || txtStaffPosition.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    // Check if the StaffID exists in tbStaffInfo
                    string checkStaffID = "SELECT COUNT(*) FROM tbStaffInfo WHERE StaffID = @StaffID AND StaffNameEn = @StaffNameEn AND StaffPosition = @StaffPosition";

                    using (SqlCommand checkSID = new SqlCommand(checkStaffID, connect))
                    {
                        checkSID.Parameters.AddWithValue("@StaffID", txtStaffID.Text.Trim());
                        checkSID.Parameters.AddWithValue("@StaffNameEn", txtStaffName.Text.Trim());
                        checkSID.Parameters.AddWithValue("@StaffPosition", txtStaffPosition.Text.Trim());

                        int staffCount = (int)checkSID.ExecuteScalar();

                        if (staffCount == 0)
                        {
                            MessageBox.Show("Staff ID, Name, or Position is invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Check if the username already exists in tbUser
                    string checkUserName = "SELECT COUNT(*) FROM tbUser WHERE UserName = @UserName";

                    using (SqlCommand checkUName = new SqlCommand(checkUserName, connect))
                    {
                        checkUName.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        int userNameCount = (int)checkUName.ExecuteScalar();

                        if (userNameCount >= 1)
                        {
                            MessageBox.Show("UserName: " + txtUserName.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Check if the StaffID and StaffName combination already exists in tbUser
                    string checkStaffUser = "SELECT COUNT(*) FROM tbUser WHERE StaffID = @StaffID AND StaffNameEn = @StaffNameEn";

                    using (SqlCommand checkSU = new SqlCommand(checkStaffUser, connect))
                    {
                        checkSU.Parameters.AddWithValue("@StaffID", txtStaffID.Text.Trim());
                        checkSU.Parameters.AddWithValue("@StaffNameEn", txtStaffName.Text.Trim());

                        int staffUserCount = (int)checkSU.ExecuteScalar();

                        if (staffUserCount >= 1)
                        {
                            MessageBox.Show("Staff ID and Staff Name combination already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user into tbUser without specifying UserID
                    string insertData = "INSERT INTO tbUser (UserName, Password, StaffID, StaffNameEn, StaffPosition) VALUES (@UserName, @Password, @StaffID, @StaffNameEn, @StaffPosition)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffNameEn", txtStaffName.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffPosition", txtStaffPosition.Text.Trim());

                        cmd.ExecuteNonQuery();
                        UserDisplayData();

                        MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (hiddenUserIdField.Text != "")
            {
                int userId = int.Parse(hiddenUserIdField.Text);

                try
                {
                    connect.Open();

                    string updateQuery = "UPDATE tbUser SET UserName = @UserName, Password = @Password, StaffID = @StaffID, StaffNameEn = @StaffNameEn, StaffPosition = @StaffPosition WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffNameEn", txtStaffName.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffPosition", txtStaffPosition.Text.Trim());

                        cmd.ExecuteNonQuery();
                        UserDisplayData();

                        MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (hiddenUserIdField.Text != "")
            {
                int userId = int.Parse(hiddenUserIdField.Text);

                try
                {
                    connect.Open();

                    string deleteQuery = "DELETE FROM tbUser WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        cmd.ExecuteNonQuery();
                        UserDisplayData();

                        MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting from Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                hiddenUserIdField.Text = row.Cells["UserID"].Value.ToString();
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtStaffID.Text = row.Cells["StaffID"].Value.ToString();
                txtStaffName.Text = row.Cells["StaffNameEn"].Value.ToString();
                txtStaffPosition.Text = row.Cells["Position"].Value.ToString();
            }
        }

        private void clearFields()
        {
            hiddenUserIdField.Text = "";
            txtUserName.Clear();
            txtPassword.Clear();
            txtStaffID.Clear();
            txtStaffName.Clear();
            txtStaffPosition.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM tbUser WHERE UserName LIKE @UserName";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                    sda.SelectCommand.Parameters.AddWithValue("@UserName", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // If only one record is found, populate the form fields
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];
                        hiddenUserIdField.Text = row["UserID"].ToString();
                        txtUserName.Text = row["UserName"].ToString();
                        txtPassword.Text = row["Password"].ToString();
                        txtStaffID.Text = row["StaffID"].ToString();
                        txtStaffName.Text = row["StaffNameEn"].ToString();
                        txtStaffPosition.Text = row["StaffPosition"].ToString();
                    }
                    else
                    {
                        // Clear the form fields if no or multiple records found
                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching user data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a name to search", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_sform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportandLogisticDataSet25.tbUser' table. You can move, or remove it, as needed.
            this.tbUserTableAdapter1.Fill(this.transportandLogisticDataSet25.tbUser);
            

        }

        private void txtStaffPosition_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
