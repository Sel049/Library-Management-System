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
    public partial class Edit_book : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";
        private DataTable currentBooks = new DataTable();

        public Edit_book()
        {
            InitializeComponent();
            EditDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;

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
                        currentBooks = new DataTable();
                        adapter.Fill(currentBooks);

                        if (currentBooks.Rows.Count > 0)
                        {
                            EditDataGridView.DataSource = currentBooks;
                            EditDataGridView.Columns["BookID"].ReadOnly = true; 
                        }
                        else
                        {
                            MessageBox.Show("No books found matching your search.", "Not Found",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditTxbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EditTxbox.Text))
            {
                SearchBooks(EditTxbox.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please enter a book ID or title to search", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateBookData(DataGridViewRow row, out string errorMessage)
        {
            errorMessage = "";

         
            if (string.IsNullOrWhiteSpace(row.Cells["Title"].Value?.ToString()))
            {
                errorMessage = "Title cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(row.Cells["Author"].Value?.ToString()))
            {
                errorMessage = "Author cannot be empty.";
                return false;
            }

            string yearText = row.Cells["Year"].Value?.ToString()?.Trim();
            if (!Regex.IsMatch(yearText ?? "", @"^\d{4}$"))
            {
                errorMessage = "Year must be a valid 4-digit number (e.g., 2020).";
                return false;
            }

           
            string copiesText = row.Cells["AvailableCopies"].Value?.ToString()?.Trim();
            if (!int.TryParse(copiesText, out int copies) || copies < 0)
            {
                errorMessage = "Available copies must be a positive whole number.";
                return false;
            }

            return true;
        }



        private void EditDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savebut_Click(object sender, EventArgs e)
        {
            if (EditDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No books to update.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool anyUpdatesMade = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in EditDataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            if (ValidateBookData(row, out string errorMessage))
                            {
                                string query = @"UPDATE Books SET 
                                        Title = @Title,
                                        Author = @Author,
                                        Category = @Category,
                                        Year = @Year,
                                        AvailableCopies = @AvailableCopies
                                        WHERE BookID = @BookID";

                                using (SqlCommand cmd = new SqlCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@BookID", row.Cells["BookID"].Value);
                                    cmd.Parameters.AddWithValue("@Title", row.Cells["Title"].Value);
                                    cmd.Parameters.AddWithValue("@Author", row.Cells["Author"].Value);
                                    cmd.Parameters.AddWithValue("@Category", row.Cells["Category"].Value);
                                    cmd.Parameters.AddWithValue("@Year", row.Cells["Year"].Value);
                                    cmd.Parameters.AddWithValue("@AvailableCopies", row.Cells["AvailableCopies"].Value);

                                    cmd.ExecuteNonQuery();
                                    anyUpdatesMade = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Row {row.Index + 1}: {errorMessage}", "Validation Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; 
                            }
                        }
                    }
                }

                if (anyUpdatesMade)
                {
                    MessageBox.Show("Book(s) updated successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SearchBooks(EditTxbox.Text.Trim()); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating books: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void backbut_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        
        private void EditDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (EditDataGridView.Columns[e.ColumnIndex].Name == "BookID")
            {
                e.Cancel = true;
            }
        }

    }
}
