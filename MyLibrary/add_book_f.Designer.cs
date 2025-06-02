namespace MYLIBRARY
{
    partial class add_book_f
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_book_f));
            this.savebut = new System.Windows.Forms.Button();
            this.addlb = new System.Windows.Forms.Label();
            this.TitleTxBox = new System.Windows.Forms.TextBox();
            this.BIDlb = new System.Windows.Forms.Label();
            this.BookIDtxBox = new System.Windows.Forms.TextBox();
            this.bookidlb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authLb = new System.Windows.Forms.Label();
            this.AutherTxBox = new System.Windows.Forms.TextBox();
            this.yearLb = new System.Windows.Forms.Label();
            this.YearTxBox = new System.Windows.Forms.TextBox();
            this.AvcLB = new System.Windows.Forms.Label();
            this.CtagoryLb = new System.Windows.Forms.Label();
            this.AvCopiesTxBut = new System.Windows.Forms.TextBox();
            this.CtagoryComBox = new System.Windows.Forms.ComboBox();
            this.backbut = new System.Windows.Forms.Button();
            this.btnGenerateId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // savebut
            // 
            this.savebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebut.Location = new System.Drawing.Point(393, 472);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(155, 54);
            this.savebut.TabIndex = 16;
            this.savebut.Text = "SAVE";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // addlb
            // 
            this.addlb.AutoSize = true;
            this.addlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlb.Location = new System.Drawing.Point(535, 93);
            this.addlb.Name = "addlb";
            this.addlb.Size = new System.Drawing.Size(141, 25);
            this.addlb.TabIndex = 15;
            this.addlb.Text = "ADD BOOKS";
            // 
            // TitleTxBox
            // 
            this.TitleTxBox.Location = new System.Drawing.Point(329, 285);
            this.TitleTxBox.Name = "TitleTxBox";
            this.TitleTxBox.Size = new System.Drawing.Size(190, 26);
            this.TitleTxBox.TabIndex = 14;
            this.TitleTxBox.TextChanged += new System.EventHandler(this.TitleTxBox_TextChanged);
            // 
            // BIDlb
            // 
            this.BIDlb.AutoSize = true;
            this.BIDlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIDlb.Location = new System.Drawing.Point(256, 285);
            this.BIDlb.Name = "BIDlb";
            this.BIDlb.Size = new System.Drawing.Size(57, 20);
            this.BIDlb.TabIndex = 13;
            this.BIDlb.Text = "TITLE";
            // 
            // BookIDtxBox
            // 
            this.BookIDtxBox.Location = new System.Drawing.Point(329, 201);
            this.BookIDtxBox.Name = "BookIDtxBox";
            this.BookIDtxBox.Size = new System.Drawing.Size(190, 26);
            this.BookIDtxBox.TabIndex = 12;
            this.BookIDtxBox.TextChanged += new System.EventHandler(this.BookIDtxBox_TextChanged);
            this.BookIDtxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookIDtxBox_KeyPress);
            // 
            // bookidlb
            // 
            this.bookidlb.AutoSize = true;
            this.bookidlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidlb.Location = new System.Drawing.Point(236, 204);
            this.bookidlb.Name = "bookidlb";
            this.bookidlb.Size = new System.Drawing.Size(77, 20);
            this.bookidlb.TabIndex = 11;
            this.bookidlb.Text = "BOOKID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(472, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // authLb
            // 
            this.authLb.AutoSize = true;
            this.authLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLb.Location = new System.Drawing.Point(225, 375);
            this.authLb.Name = "authLb";
            this.authLb.Size = new System.Drawing.Size(88, 20);
            this.authLb.TabIndex = 17;
            this.authLb.Text = "AUTHOR ";
            // 
            // AutherTxBox
            // 
            this.AutherTxBox.Location = new System.Drawing.Point(329, 369);
            this.AutherTxBox.Name = "AutherTxBox";
            this.AutherTxBox.Size = new System.Drawing.Size(190, 26);
            this.AutherTxBox.TabIndex = 18;
            this.AutherTxBox.TextChanged += new System.EventHandler(this.AutherTxBox_TextChanged);
            // 
            // yearLb
            // 
            this.yearLb.AutoSize = true;
            this.yearLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLb.Location = new System.Drawing.Point(688, 207);
            this.yearLb.Name = "yearLb";
            this.yearLb.Size = new System.Drawing.Size(58, 20);
            this.yearLb.TabIndex = 19;
            this.yearLb.Text = "YEAR";
            // 
            // YearTxBox
            // 
            this.YearTxBox.Location = new System.Drawing.Point(768, 207);
            this.YearTxBox.Name = "YearTxBox";
            this.YearTxBox.Size = new System.Drawing.Size(190, 26);
            this.YearTxBox.TabIndex = 20;
            this.YearTxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTxBox_KeyPress);
            // 
            // AvcLB
            // 
            this.AvcLB.AutoSize = true;
            this.AvcLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvcLB.Location = new System.Drawing.Point(568, 291);
            this.AvcLB.Name = "AvcLB";
            this.AvcLB.Size = new System.Drawing.Size(178, 20);
            this.AvcLB.TabIndex = 21;
            this.AvcLB.Text = "AVAILABLE COPIES";
            // 
            // CtagoryLb
            // 
            this.CtagoryLb.AutoSize = true;
            this.CtagoryLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtagoryLb.Location = new System.Drawing.Point(657, 369);
            this.CtagoryLb.Name = "CtagoryLb";
            this.CtagoryLb.Size = new System.Drawing.Size(107, 20);
            this.CtagoryLb.TabIndex = 22;
            this.CtagoryLb.Text = "CATAGORY";
            // 
            // AvCopiesTxBut
            // 
            this.AvCopiesTxBut.Location = new System.Drawing.Point(768, 285);
            this.AvCopiesTxBut.Name = "AvCopiesTxBut";
            this.AvCopiesTxBut.Size = new System.Drawing.Size(190, 26);
            this.AvCopiesTxBut.TabIndex = 23;
            this.AvCopiesTxBut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AvCopiesTxBut_KeyPress);
            // 
            // CtagoryComBox
            // 
            this.CtagoryComBox.FormattingEnabled = true;
            this.CtagoryComBox.Location = new System.Drawing.Point(768, 366);
            this.CtagoryComBox.Name = "CtagoryComBox";
            this.CtagoryComBox.Size = new System.Drawing.Size(190, 28);
            this.CtagoryComBox.TabIndex = 24;
            this.CtagoryComBox.SelectedIndexChanged += new System.EventHandler(this.CtagoryComBox_SelectedIndexChanged);
            // 
            // backbut
            // 
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbut.Location = new System.Drawing.Point(681, 472);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(155, 54);
            this.backbut.TabIndex = 25;
            this.backbut.Text = "BACK";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // btnGenerateId
            // 
            this.btnGenerateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateId.Location = new System.Drawing.Point(525, 198);
            this.btnGenerateId.Name = "btnGenerateId";
            this.btnGenerateId.Size = new System.Drawing.Size(108, 32);
            this.btnGenerateId.TabIndex = 26;
            this.btnGenerateId.Text = "Generate";
            this.btnGenerateId.UseVisualStyleBackColor = true;
            this.btnGenerateId.Click += new System.EventHandler(this.btnGenerateId_Click);
            // 
            // add_book_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.btnGenerateId);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.CtagoryComBox);
            this.Controls.Add(this.AvCopiesTxBut);
            this.Controls.Add(this.CtagoryLb);
            this.Controls.Add(this.AvcLB);
            this.Controls.Add(this.YearTxBox);
            this.Controls.Add(this.yearLb);
            this.Controls.Add(this.AutherTxBox);
            this.Controls.Add(this.authLb);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.addlb);
            this.Controls.Add(this.TitleTxBox);
            this.Controls.Add(this.BIDlb);
            this.Controls.Add(this.BookIDtxBox);
            this.Controls.Add(this.bookidlb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "add_book_f";
            this.Text = "ADD BOOKS ";
            this.Load += new System.EventHandler(this.add_book_f_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Label addlb;
        private System.Windows.Forms.TextBox TitleTxBox;
        private System.Windows.Forms.Label BIDlb;
        private System.Windows.Forms.TextBox BookIDtxBox;
        private System.Windows.Forms.Label bookidlb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label authLb;
        private System.Windows.Forms.TextBox AutherTxBox;
        private System.Windows.Forms.Label yearLb;
        private System.Windows.Forms.TextBox YearTxBox;
        private System.Windows.Forms.Label AvcLB;
        private System.Windows.Forms.Label CtagoryLb;
        private System.Windows.Forms.TextBox AvCopiesTxBut;
        private System.Windows.Forms.ComboBox CtagoryComBox;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Button btnGenerateId;
    }
}