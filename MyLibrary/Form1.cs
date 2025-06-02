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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BookMgtBtn_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Hide();
        }

        private void BorrowerMgtBtn_Click(object sender, EventArgs e)
        {
            Borrower_mgt_Form f1= new Borrower_mgt_Form();
            f1.Show();
            this.Hide();
        }
    }
}
