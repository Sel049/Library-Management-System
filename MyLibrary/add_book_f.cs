using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYLIBRARY
{
    public partial class add_book_f : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=true;";
        public add_book_f()
        {
            InitializeComponent();


            InitializeCategories();

            
            BookIDtxBox.KeyPress += BookIDtxBox_KeyPress;
        }

        private void InitializeCategories()
        {
            CtagoryComBox.Items.AddRange(new object[] {
                "Fiction",
                "Non-Fiction",
                "Science Fiction",
                "Fantasy",
                "Mystery",
                "Thriller",
                "Horror",
                "Romance",
                "Historical Fiction",
                "Biography",
                "Autobiography",
                "Self-Help",
                "Science",
                "Technology",
                "Programming",
                "Philosophy",
                "Psychology",
                "Travel",
                "Cooking",
                "Health & Fitness",
                "Art & Photography",
                "Poetry",
                "Drama",
                "Comics & Graphic Novels",
                "Children's Books",
                "Young Adult (YA)",
                "Religion & Spirituality",
                "Business & Finance",
                "Economics",
                "Politics"
            });
            CtagoryComBox.SelectedIndex = 0; 
        }

        private bool BookIdExists(string bookId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false; 
            }
        }

        private void GenerateRandomBookId()
        {
            Random rnd = new Random();
            string newId;
            int attempts = 0;

            do
            {
                newId = rnd.Next(1000, 99999).ToString();
                attempts++;
                if (attempts > 100) 
                {
                    MessageBox.Show("Could not generate unique ID. Please enter manually.", "Warning",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } while (BookIdExists(newId));

            BookIDtxBox.Text = newId;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void add_book_f_Load(object sender, EventArgs e)
        {

        }


        private void CtagoryComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookIDtxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleTxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutherTxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearTxBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AvCopiesTxBut_TextChanged(object sender, EventArgs e)
        {
        }

        private void savebut_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(BookIDtxBox.Text))
            {
                if (MessageBox.Show("Generate random Book ID?", "Book ID Missing",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GenerateRandomBookId();
                }
                return;
            }

            if (!Regex.IsMatch(BookIDtxBox.Text, @"^\d+$"))
            {
                MessageBox.Show("Book ID must contain only numbers", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BookIdExists(BookIDtxBox.Text))
            {
                MessageBox.Show("This Book ID already exists. Please use a different ID.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(TitleTxBox.Text) ||
                string.IsNullOrWhiteSpace(AutherTxBox.Text) ||
                string.IsNullOrWhiteSpace(YearTxBox.Text) ||
                string.IsNullOrWhiteSpace(AvCopiesTxBut.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(YearTxBox.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Please enter a valid 4-digit year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(AvCopiesTxBut.Text, out int copies) || copies < 0)
            {
                MessageBox.Show("Available copies must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Books 
                                    (BookID, Title, Author, Category, Year, AvailableCopies) 
                                    VALUES 
                                    (@BookID, @Title, @Author, @Category, @Year, @Copies)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", BookIDtxBox.Text);
                        cmd.Parameters.AddWithValue("@Title", TitleTxBox.Text);
                        cmd.Parameters.AddWithValue("@Author", AutherTxBox.Text);
                        cmd.Parameters.AddWithValue("@Category", CtagoryComBox.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Year", YearTxBox.Text);
                        cmd.Parameters.AddWithValue("@Copies", copies);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        BookIDtxBox.Clear();
                        TitleTxBox.Clear();
                        AutherTxBox.Clear();
                        YearTxBox.Clear();
                        AvCopiesTxBut.Clear();
                        CtagoryComBox.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void YearTxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AvCopiesTxBut_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookIDtxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
  
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerateId_Click(object sender, EventArgs e)
        {
            GenerateRandomBookId();
        }
    }
}
