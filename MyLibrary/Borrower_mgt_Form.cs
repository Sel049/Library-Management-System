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
    public partial class Borrower_mgt_Form : Form
    {
        public Borrower_mgt_Form()
        {
            InitializeComponent();
        }

        private void Borrower_mgt_Form_Load(object sender, EventArgs e)
        {

        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            manage_bo_form f1 = new manage_bo_form();
            f1.Show();
            this.Hide();
        }

        private void issueBookBtn_Click(object sender, EventArgs e)
        {
            Issue_Book_Form f2 = new Issue_Book_Form();
            f2.Show();
            this.Hide();
        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            Return_Form f1 = new Return_Form();
            f1.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}
