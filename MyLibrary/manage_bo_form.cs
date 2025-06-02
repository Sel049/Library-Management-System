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
    public partial class manage_bo_form : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";
        public manage_bo_form()
        {
            InitializeComponent();
            SearchDataGridView.AutoGenerateColumns = true;
        }

        private void bid_nmae_Click(object sender, EventArgs e)
        {

        }

        private void searchTxBox_TextChanged(object sender, EventArgs e)
        {

        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption, string defaultValue = "")
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 20, Top = 20, Text = text };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = defaultValue };
                Button confirmation = new Button() { Text = "OK", Left = 280, Width = 80, Top = 80 };
                confirmation.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };

                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : defaultValue;
            }
        }


        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTxBox.Text))
            {
                MessageBox.Show("Please enter a borrower ID or name to search", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT BorrowerID, Name, Email, Phone 
                                   FROM Borrowers 
                                   WHERE BorrowerID LIKE @SearchTerm OR Name LIKE @SearchTerm";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTxBox.Text.Trim()}%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            SearchDataGridView.DataSource = dataTable;
                        }
                        else
                        {
                            SearchDataGridView.DataSource = null;
                            MessageBox.Show("No borrowers found matching your search", "Not Found",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching borrowers: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBoBtn_Click(object sender, EventArgs e)
        {
            Add_Bo_Form f2 = new Add_Bo_Form();
            f2.Show();
            this.Hide();
        }

        private void EditBoBtn_Click(object sender, EventArgs e)
        {
            if (SearchDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to edit.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = SearchDataGridView.SelectedRows[0];
            string borrowerID = selectedRow.Cells["BorrowerID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();

       
            string newName = Prompt.ShowDialog("Edit Name:", "Edit Borrower", name);
            string newEmail = Prompt.ShowDialog("Edit Email:", "Edit Borrower", email);
            string newPhone = Prompt.ShowDialog("Edit Phone:", "Edit Borrower", phone);

          
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newEmail) || string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!newEmail.Contains("@"))
            {
                MessageBox.Show("Invalid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE Borrowers 
                                   SET Name = @Name, Email = @Email, Phone = @Phone 
                                   WHERE BorrowerID = @BorrowerID";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Name", newName);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Phone", newPhone);
                    cmd.Parameters.AddWithValue("@BorrowerID", borrowerID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Borrower updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchbtn.PerformClick(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating borrower: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deleteBoBtn_Click(object sender, EventArgs e)
        {
            if (SearchDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to delete.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string adminPassword = Prompt.ShowDialog("Enter admin password to confirm deletion:", "Admin Authorization");

            
            if (adminPassword != "password123") 
            {
                MessageBox.Show("Invalid admin password!", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = SearchDataGridView.SelectedRows[0];
            string borrowerID = selectedRow.Cells["BorrowerID"].Value.ToString();

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this borrower?", "Confirm Delete",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM Borrowers WHERE BorrowerID = @BorrowerID";

                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@BorrowerID", borrowerID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Borrower deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchbtn.PerformClick(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting borrower: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void backbut_Click(object sender, EventArgs e)
        {
            Borrower_mgt_Form form1 = new Borrower_mgt_Form();
            form1.Show();
            this.Hide();
        }
    }
}
