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
    public partial class search_form : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";
        public search_form()
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
                           WHERE BookID LIKE @SearchTerm OR Title LIKE @SearchTerm 
                           OR Author LIKE @SearchTerm";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            SearchDataGridView.DataSource = dataTable;

                           
                            SearchDataGridView.Columns["BookID"].HeaderText = "Book ID";
                            SearchDataGridView.Columns["AvailableCopies"].HeaderText = "Available";
                            SearchDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                        else
                        {
                            SearchDataGridView.DataSource = null; 
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
                MessageBox.Show($"Error searching books: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayAllBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT BookID, Title, Author, Category, Year, AvailableCopies FROM Books";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            SearchDataGridView.DataSource = dataTable;
                            SearchDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                        else
                        {
                            SearchDataGridView.DataSource = null;
                            MessageBox.Show("No books found in the database.",
                                          "No Books",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter a search term", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayALLbtn_Click(object sender, EventArgs e)
        {
            DisplayAllBooks();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void search_form_Load(object sender, EventArgs e)
        {

        }

        private void searchTxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchbtn_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
