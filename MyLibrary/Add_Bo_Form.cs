using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYLIBRARY
{
    public partial class Add_Bo_Form : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";

        public Add_Bo_Form()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string newId;
                    Random rnd = new Random();

                    do
                    {
                        newId = rnd.Next(1000, 9999).ToString();
                        var checkCmd = new SqlCommand(
                            "SELECT COUNT(*) FROM Borrowers WHERE BorrowerID = @ID",
                            connection);
                        checkCmd.Parameters.AddWithValue("@ID", newId);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists == 0) break;
                    } while (true);

                    BorowerId_txbox.Text = newId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating ID: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(BorowerId_txbox.Text))
            {
                MessageBox.Show("Please generate a Borrower ID", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(nameTxbox.Text))
            {
                MessageBox.Show("Name cannot be empty", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTxbox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Emailtxbox.Text))
            {
                MessageBox.Show("Email cannot be empty", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Emailtxbox.Focus();
                return false;
            }

            if (!Regex.IsMatch(Emailtxbox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Emailtxbox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(PhoneTxBox.Text))
            {
                MessageBox.Show("Phone number cannot be empty", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneTxBox.Focus();
                return false;
            }

            return true;
        }
        private void BorowerId_txbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emailtxbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTxBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void savebut_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Borrowers 
                                    (BorrowerID, Name, Email, Phone) 
                                    VALUES 
                                    (@BorrowerID, @Name, @Email, @Phone)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerID", BorowerId_txbox.Text);
                        cmd.Parameters.AddWithValue("@Name", nameTxbox.Text);
                        cmd.Parameters.AddWithValue("@Email", Emailtxbox.Text);
                        cmd.Parameters.AddWithValue("@Phone", PhoneTxBox.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Borrower added successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving borrower: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            BorowerId_txbox.Clear();
            nameTxbox.Clear();
            Emailtxbox.Clear();
            PhoneTxBox.Clear();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            manage_bo_form f2 = new manage_bo_form();
            f2.Show();
            this.Hide();
        }

        private void PhoneTxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
