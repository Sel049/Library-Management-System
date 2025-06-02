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
    public partial class Return_Form : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";

        public Return_Form()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Return_Form_Load);

        }
        private void Return_Form_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();
        }

        private void LoadIssuedBooks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IssueID, BorrowerID, BookID, IssueDate, DueDate FROM IssuedBooks";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int issueId = Convert.ToInt32(selectedRow.Cells["IssueID"].Value);
            string bookId = selectedRow.Cells["BookID"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                   
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM IssuedBooks WHERE IssueID = @IssueID", conn, transaction);
                    deleteCmd.Parameters.AddWithValue("@IssueID", issueId);
                    deleteCmd.ExecuteNonQuery();

                 
                    SqlCommand updateCmd = new SqlCommand("UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID", conn, transaction);
                    updateCmd.Parameters.AddWithValue("@BookID", bookId);
                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Book returned successfully.");
                    LoadIssuedBooks(); 
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error while returning the book: " + ex.Message);
                }
            }
        }


        private void backbut_Click(object sender, EventArgs e)
        {
            Borrower_mgt_Form f1 = new Borrower_mgt_Form();
            f1.Show();
            this.Hide();
        }
    }
}
