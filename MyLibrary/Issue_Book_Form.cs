using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MYLIBRARY
{
    public partial class Issue_Book_Form : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";

        public Issue_Book_Form()
        {
            InitializeComponent();
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            string borrowerId = BorowerId_txbox.Text.Trim();
            string bookId = BookIdTxbox.Text.Trim(); 
            DateTime issueDate = IssuedateTimePicker1.Value;
            DateTime dueDate = DuedateTimePicker1.Value;

            if (string.IsNullOrEmpty(borrowerId) || string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter both Borrower ID and Book ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

               
                SqlCommand checkBorrowerCmd = new SqlCommand("SELECT COUNT(*) FROM Borrowers WHERE BorrowerID = @BorrowerID", conn);
                checkBorrowerCmd.Parameters.AddWithValue("@BorrowerID", borrowerId);
                int borrowerExists = (int)checkBorrowerCmd.ExecuteScalar();

                if (borrowerExists == 0)
                {
                    MessageBox.Show("Borrower ID does not exist.");
                    return;
                }

               
                SqlCommand checkBookCmd = new SqlCommand("SELECT AvailableCopies FROM Books WHERE BookID = @BookID", conn);
                checkBookCmd.Parameters.AddWithValue("@BookID", bookId);
                object result = checkBookCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Book ID does not exist.");
                    return;
                }

                int availableCopies = (int)result;
                if (availableCopies <= 0)
                {
                    MessageBox.Show("No copies of the book are currently available.");
                    return;
                }

             
                SqlCommand issueBookCmd = new SqlCommand(@"
                    INSERT INTO IssuedBooks (BorrowerID, BookID, IssueDate, DueDate) 
                    VALUES (@BorrowerID, @BookID, @IssueDate, @DueDate)", conn);
                issueBookCmd.Parameters.AddWithValue("@BorrowerID", borrowerId);
                issueBookCmd.Parameters.AddWithValue("@BookID", bookId);
                issueBookCmd.Parameters.AddWithValue("@IssueDate", issueDate);
                issueBookCmd.Parameters.AddWithValue("@DueDate", dueDate);
                issueBookCmd.ExecuteNonQuery();

               
                SqlCommand updateBookCmd = new SqlCommand("UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @BookID", conn);
                updateBookCmd.Parameters.AddWithValue("@BookID", bookId);
                updateBookCmd.ExecuteNonQuery();

                MessageBox.Show("Book issued successfully.");
            }
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            Borrower_mgt_Form form = new Borrower_mgt_Form();
            form.Show();
            this.Hide();
        }

    
        private void BorowerId_txbox_TextChanged(object sender, EventArgs e) { }
        private void nameTxbox_TextChanged(object sender, EventArgs e) { }
        private void DuedateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void IssuedateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void BookIdTxbox_TextChanged(object sender, EventArgs e) { } 
    }
}
