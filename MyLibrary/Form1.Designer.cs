namespace MYLIBRARY
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BookMgtBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BorrowerMgtBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookMgtBtn
            // 
            this.BookMgtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookMgtBtn.Location = new System.Drawing.Point(399, 198);
            this.BookMgtBtn.Name = "BookMgtBtn";
            this.BookMgtBtn.Size = new System.Drawing.Size(262, 73);
            this.BookMgtBtn.TabIndex = 16;
            this.BookMgtBtn.Text = "Book Managment";
            this.BookMgtBtn.UseVisualStyleBackColor = true;
            this.BookMgtBtn.Click += new System.EventHandler(this.BookMgtBtn_Click);
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
            // 
            // BorrowerMgtBtn
            // 
            this.BorrowerMgtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowerMgtBtn.Location = new System.Drawing.Point(399, 349);
            this.BorrowerMgtBtn.Name = "BorrowerMgtBtn";
            this.BorrowerMgtBtn.Size = new System.Drawing.Size(262, 68);
            this.BorrowerMgtBtn.TabIndex = 17;
            this.BorrowerMgtBtn.Text = "Borrower Managment";
            this.BorrowerMgtBtn.UseVisualStyleBackColor = true;
            this.BorrowerMgtBtn.Click += new System.EventHandler(this.BorrowerMgtBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.BorrowerMgtBtn);
            this.Controls.Add(this.BookMgtBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BookMgtBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BorrowerMgtBtn;
    }
}