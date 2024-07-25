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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=TransportandLogistic;Integrated Security=True;");
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbUser WHERE UserName=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login Account Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.Size = new Size(2800, 1706);
                    mainForm.StartPosition = FormStartPosition.CenterScreen;
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtUser.Clear();
            txtPassword.Clear();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
            }
        }   
    }
}

