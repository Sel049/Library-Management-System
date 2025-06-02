namespace MYLIBRARY
{
    partial class Issue_Book_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issue_Book_Form));
            this.backbut = new System.Windows.Forms.Button();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.BookIdTxbox = new System.Windows.Forms.TextBox();
            this.Bo_Name_Lb = new System.Windows.Forms.Label();
            this.BorowerId_txbox = new System.Windows.Forms.TextBox();
            this.bid_nmae = new System.Windows.Forms.Label();
            this.addlb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DuedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.issue_date_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IssuedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbut
            // 
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbut.Location = new System.Drawing.Point(403, 369);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(155, 46);
            this.backbut.TabIndex = 92;
            this.backbut.Text = "BACK";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.Location = new System.Drawing.Point(126, 369);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(177, 46);
            this.IssueBtn.TabIndex = 91;
            this.IssueBtn.Text = "ISSUE BOOK";
            this.IssueBtn.UseVisualStyleBackColor = true;
            this.IssueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // BookIdTxbox
            // 
            this.BookIdTxbox.Location = new System.Drawing.Point(283, 191);
            this.BookIdTxbox.Name = "BookIdTxbox";
            this.BookIdTxbox.Size = new System.Drawing.Size(190, 26);
            this.BookIdTxbox.TabIndex = 88;
            this.BookIdTxbox.TextChanged += new System.EventHandler(this.nameTxbox_TextChanged);
            // 
            // Bo_Name_Lb
            // 
            this.Bo_Name_Lb.AutoSize = true;
            this.Bo_Name_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bo_Name_Lb.Location = new System.Drawing.Point(144, 194);
            this.Bo_Name_Lb.Name = "Bo_Name_Lb";
            this.Bo_Name_Lb.Size = new System.Drawing.Size(120, 20);
            this.Bo_Name_Lb.TabIndex = 87;
            this.Bo_Name_Lb.Text = "BookID/Name";
            // 
            // BorowerId_txbox
            // 
            this.BorowerId_txbox.Location = new System.Drawing.Point(283, 121);
            this.BorowerId_txbox.Name = "BorowerId_txbox";
            this.BorowerId_txbox.Size = new System.Drawing.Size(190, 26);
            this.BorowerId_txbox.TabIndex = 86;
            this.BorowerId_txbox.TextChanged += new System.EventHandler(this.BorowerId_txbox_TextChanged);
            // 
            // bid_nmae
            // 
            this.bid_nmae.AutoSize = true;
            this.bid_nmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid_nmae.Location = new System.Drawing.Point(131, 127);
            this.bid_nmae.Name = "bid_nmae";
            this.bid_nmae.Size = new System.Drawing.Size(133, 20);
            this.bid_nmae.TabIndex = 85;
            this.bid_nmae.Text = "BORROWERID";
            // 
            // addlb
            // 
            this.addlb.AutoSize = true;
            this.addlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlb.Location = new System.Drawing.Point(288, 45);
            this.addlb.Name = "addlb";
            this.addlb.Size = new System.Drawing.Size(146, 25);
            this.addlb.TabIndex = 84;
            this.addlb.Text = "ISSUE BOOK";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // DuedateTimePicker1
            // 
            this.DuedateTimePicker1.Location = new System.Drawing.Point(283, 254);
            this.DuedateTimePicker1.Name = "DuedateTimePicker1";
            this.DuedateTimePicker1.Size = new System.Drawing.Size(190, 26);
            this.DuedateTimePicker1.TabIndex = 93;
            this.DuedateTimePicker1.ValueChanged += new System.EventHandler(this.DuedateTimePicker1_ValueChanged);
            // 
            // issue_date_lb
            // 
            this.issue_date_lb.AutoSize = true;
            this.issue_date_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_date_lb.Location = new System.Drawing.Point(172, 260);
            this.issue_date_lb.Name = "issue_date_lb";
            this.issue_date_lb.Size = new System.Drawing.Size(92, 20);
            this.issue_date_lb.TabIndex = 94;
            this.issue_date_lb.Text = "IssueDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Due Date";
            // 
            // IssuedateTimePicker1
            // 
            this.IssuedateTimePicker1.Location = new System.Drawing.Point(283, 316);
            this.IssuedateTimePicker1.Name = "IssuedateTimePicker1";
            this.IssuedateTimePicker1.Size = new System.Drawing.Size(190, 26);
            this.IssuedateTimePicker1.TabIndex = 96;
            this.IssuedateTimePicker1.ValueChanged += new System.EventHandler(this.IssuedateTimePicker1_ValueChanged);
            // 
            // Issue_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IssuedateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.issue_date_lb);
            this.Controls.Add(this.DuedateTimePicker1);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.IssueBtn);
            this.Controls.Add(this.BookIdTxbox);
            this.Controls.Add(this.Bo_Name_Lb);
            this.Controls.Add(this.BorowerId_txbox);
            this.Controls.Add(this.bid_nmae);
            this.Controls.Add(this.addlb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Issue_Book_Form";
            this.Text = "ISSUE BOOK FORM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.TextBox BookIdTxbox;
        private System.Windows.Forms.Label Bo_Name_Lb;
        private System.Windows.Forms.TextBox BorowerId_txbox;
        private System.Windows.Forms.Label bid_nmae;
        private System.Windows.Forms.Label addlb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DuedateTimePicker1;
        private System.Windows.Forms.Label issue_date_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker IssuedateTimePicker1;
    }
}