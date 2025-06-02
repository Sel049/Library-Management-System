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
    public partial class DeleteFrame : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";
        public DeleteFrame()
        {
            InitializeComponent();
        }

        private void SearchBooks(string searchTerm)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT BookID, Title, Author, Category, Year, AvailableCopies 
                                   FROM Books 
                                   WHERE BookID LIKE @SearchTerm OR Title LIKE @SearchTerm";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            DeleteDataGridView.DataSource = dataTable;
                        }
                        else
                        {
                            DeleteDataGridView.DataSource = null;
                            MessageBox.Show("No books found matching your search criteria.",
                                          "Not Found",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        private void searchTxBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTxBox.Text))
            {
                SearchBooks(searchTxBox.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please enter a book ID or title to search",
                              "Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }


        private void DeleteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DeleteDataGridView.Rows.Count == 0 || DeleteDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete",
                              "Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return;
            }

            string bookId = DeleteDataGridView.SelectedRows[0].Cells["BookID"].Value.ToString();
            string bookTitle = DeleteDataGridView.SelectedRows[0].Cells["Title"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete '{bookTitle}' (ID: {bookId})?",
                                                 "Confirm Deletion",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {

                string inputPassword = ShowPasswordDialog();

                if (string.IsNullOrWhiteSpace(inputPassword))
                {
                    MessageBox.Show("Password is required for deletion.",
                                  "Verification Required",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();


                        string verifyQuery = "SELECT COUNT(*) FROM Users WHERE Username = 'admin' AND Password = @Password";

                        using (SqlCommand verifyCmd = new SqlCommand(verifyQuery, connection))
                        {
                            verifyCmd.Parameters.AddWithValue("@Password", inputPassword);

                            int validUserCount = (int)verifyCmd.ExecuteScalar();

                            if (validUserCount == 0)
                            {
                                MessageBox.Show("Incorrect admin password. Deletion canceled.",
                                              "Verification Failed",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
                                return;
                            }
                        }


                        string deleteQuery = "DELETE FROM Books WHERE BookID = @BookID";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@BookID", bookId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book deleted successfully!",
                                              "Success",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);
                                SearchBooks(searchTxBox.Text.Trim()); 
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}",
                                  "Database Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }



        private string ShowPasswordDialog()
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter Admin Password",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Password:" };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240, PasswordChar = '*' };
            Button confirmation = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private void backbut_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void DeleteFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
