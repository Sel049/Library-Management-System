using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search_form f2 = new search_form();
            f2.Show();
            this.Hide();

        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            add_book_f mainForm = new add_book_f();
            mainForm.Show();
            this.Hide();
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            Edit_book editForm = new Edit_book();
            editForm.Show();
            this.Hide();
        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            DeleteFrame f2 = new DeleteFrame();
            f2.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
