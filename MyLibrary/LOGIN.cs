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

namespace MYLIBRARY
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            passtxbox.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbut_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=true;";
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", usertxbox.Text);
                        cmd.Parameters.AddWithValue("@password", passtxbox.Text);

                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            Form1 mainForm = new Form1();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.", "Login Failed",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            usertxbox.Clear();
                            passtxbox.Clear();
                            usertxbox.Focus();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Connection Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usertxbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
