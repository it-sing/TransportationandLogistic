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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TransportationandLogistic.Forms
{
    public partial class FrmStaffInfo : Form

    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;";
        public FrmStaffInfo()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Get user input from text boxes
            string staffNameEn = txtStaffNameEn.Text;
            string staffNameKh = txtStaffNameKH.Text;
            string gender = rbMale.Checked ? "Male" : "Female";
            DateTime birthDate = BirthDate.Value.Date;
            string staffPosition = cboStaffPostion.SelectedItem.ToString();
            string address = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            DateTime hiredDate = HiredDate.Value.Date;
            string status = cboStatus.SelectedItem.ToString();

            // Get photo data
            byte[] photoData = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg); // Assuming the image format is JPEG
                    photoData = ms.ToArray();
                }
            }

            try
            {
                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("InsertStaffInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StaffNameEn", staffNameEn);
                        command.Parameters.AddWithValue("@StaffNameKh", staffNameKh);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@StaffPosition", staffPosition);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@HiredDate", hiredDate);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@Photo", (object)photoData ?? DBNull.Value); // If photoData is null, insert DBNull.Value

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap selectedImage = new Bitmap(openFileDialog.FileName);
                        pictureBox1.Image = selectedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DisplayStaffName();
            }
        }

        private void panelDisplay_MouseClick(object sender, MouseEventArgs e)
        {
         
            Label clickedLabel = panelDisplay.GetChildAtPoint(e.Location) as Label;

            if (clickedLabel != null)
            {
       
                string selectedName = clickedLabel.Text;
                DisplayStaffInfo(selectedName);
            }
        }

        private void DisplayStaffName()
        {
            int staffID;
            if (!int.TryParse(txtSearch.Text, out staffID))
            {
                MessageBox.Show("Please enter a valid staff ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string selectSql = "SELECT * FROM tbStaffInfo WHERE StaffID = @StaffID";

            try
            {
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectSql, connection))
                    {
                   
                        command.Parameters.AddWithValue("@StaffID", staffID);

                        
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            if (reader.Read())
                            {
                                
                                panelDisplay.Controls.Clear();

                               
                                Label nameLabel = new Label();
                                nameLabel.Text = reader["StaffNameEn"].ToString();
                                nameLabel.AutoSize = true; 
                                nameLabel.Cursor = Cursors.Hand; 
                                nameLabel.Click += (sender, e) => DisplayStaffInfo(nameLabel.Text); 
                                panelDisplay.Controls.Add(nameLabel); 
                            }
                            else
                            {
                                
                                MessageBox.Show("No staff found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private void DisplayStaffInfo(string selectedName)
        {
            int staffID;
            if (!int.TryParse(txtSearch.Text, out staffID))
            {
                MessageBox.Show("Please enter a valid staff ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT staffID, StaffNameEn, StaffNameKh, Gender, BirthDate, StaffPosition, Address, PhoneNumber, HiredDate, Status, Photo
                             FROM tbStaffInfo
                             WHERE staffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@StaffID", staffID);

                        // Open the connection
                        connection.Open();

                        // Execute the command and create a reader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if a record was found
                            if (reader.Read())
                            {
                                // Fill in the text boxes and other UI elements with staff information
                                txtStaffID.Text = reader["staffID"].ToString();
                                txtStaffNameEn.Text = reader["StaffNameEn"].ToString();
                                txtStaffNameKH.Text = reader["StaffNameKh"].ToString();
                                cboStaffPostion.SelectedItem = reader["StaffPosition"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                                txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                                BirthDate.Value = (DateTime)reader["BirthDate"];
                                HiredDate.Value = (DateTime)reader["HiredDate"];
                                cboStatus.SelectedItem = reader["Status"].ToString();
                                rbMale.Checked = reader["Gender"].ToString() == "Male";
                                rbFemale.Checked = reader["Gender"].ToString() == "Female";

                                // Get the photo data
                                byte[] photoData = reader["Photo"] as byte[];
                                if (photoData != null)
                                {
                                    // Convert byte array to image and display it in PictureBox
                                    using (MemoryStream ms = new MemoryStream(photoData))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    // Clear the PictureBox if there's no photo data
                                    pictureBox1.Image = null;
                                }
                            }
                            else
                            {
                                // No staff found with the given ID
                                MessageBox.Show("No staff found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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


        private void btnLogout_Click(object sender, EventArgs e)
          {
              this.Close();
          }

        // Update info in field staff information detail 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int staffID;
            if (!int.TryParse(txtSearch.Text, out staffID))
            {
                MessageBox.Show("Please enter a valid staff ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdateStaffInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@StaffNameEn", txtStaffNameEn.Text);
                        command.Parameters.AddWithValue("@StaffNameKh", txtStaffNameKH.Text);
                        command.Parameters.AddWithValue("@Gender", rbMale.Checked ? "Male" : "Female");
                        command.Parameters.AddWithValue("@BirthDate", BirthDate.Value.Date);
                        command.Parameters.AddWithValue("@StaffPosition", cboStaffPostion.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        command.Parameters.AddWithValue("@HiredDate", HiredDate.Value.Date);
                        command.Parameters.AddWithValue("@Status", cboStatus.SelectedItem.ToString());

                        // Get photo data
                        byte[] photoData = null;
                        if (pictureBox1.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, ImageFormat.Jpeg); // Assuming the image format is JPEG
                                photoData = ms.ToArray();
                            }
                        }
                        command.Parameters.AddWithValue("@Photo", (object)photoData ?? DBNull.Value);

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // When user click on new it will clear all info in form 
        private void btnNew_Click(object sender, EventArgs e)
          {


            txtStaffID.Text =txtStaffNameEn.Text = txtStaffNameKH.Text = txtAddress.Text = txtPhoneNumber.Text = "";
            BirthDate.Value = HiredDate.Value = DateTime.Now;
            cboStatus.SelectedIndex = cboStaffPostion.SelectedIndex = - 1;
            rbMale.Checked = rbFemale.Checked = false;
            pictureBox1.Image = null;
            txtSearch.Text = "";

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}


    

