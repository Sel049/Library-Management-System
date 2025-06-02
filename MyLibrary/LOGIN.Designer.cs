namespace MYLIBRARY
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userlb = new System.Windows.Forms.Label();
            this.usertxbox = new System.Windows.Forms.TextBox();
            this.pswlb = new System.Windows.Forms.Label();
            this.passtxbox = new System.Windows.Forms.TextBox();
            this.adminlb = new System.Windows.Forms.Label();
            this.loginbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(520, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // userlb
            // 
            this.userlb.AutoSize = true;
            this.userlb.Location = new System.Drawing.Point(372, 298);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(105, 20);
            this.userlb.TabIndex = 2;
            this.userlb.Text = "USER NAME";
            this.userlb.Click += new System.EventHandler(this.label1_Click);
            // 
            // usertxbox
            // 
            this.usertxbox.Location = new System.Drawing.Point(505, 292);
            this.usertxbox.Name = "usertxbox";
            this.usertxbox.Size = new System.Drawing.Size(190, 26);
            this.usertxbox.TabIndex = 3;
            this.usertxbox.TextChanged += new System.EventHandler(this.usertxbox_TextChanged);
            // 
            // pswlb
            // 
            this.pswlb.AutoSize = true;
            this.pswlb.Location = new System.Drawing.Point(374, 343);
            this.pswlb.Name = "pswlb";
            this.pswlb.Size = new System.Drawing.Size(103, 20);
            this.pswlb.TabIndex = 4;
            this.pswlb.Text = "PASSWORD";
            this.pswlb.Click += new System.EventHandler(this.label2_Click);
            // 
            // passtxbox
            // 
            this.passtxbox.Location = new System.Drawing.Point(505, 337);
            this.passtxbox.Name = "passtxbox";
            this.passtxbox.Size = new System.Drawing.Size(190, 26);
            this.passtxbox.TabIndex = 5;
            this.passtxbox.TextChanged += new System.EventHandler(this.passtxbox_TextChanged);
            // 
            // adminlb
            // 
            this.adminlb.AutoSize = true;
            this.adminlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlb.Location = new System.Drawing.Point(515, 245);
            this.adminlb.Name = "adminlb";
            this.adminlb.Size = new System.Drawing.Size(81, 25);
            this.adminlb.TabIndex = 6;
            this.adminlb.Text = "ADMIN";
            this.adminlb.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginbut
            // 
            this.loginbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbut.Location = new System.Drawing.Point(485, 398);
            this.loginbut.Name = "loginbut";
            this.loginbut.Size = new System.Drawing.Size(155, 42);
            this.loginbut.TabIndex = 8;
            this.loginbut.Text = "LOGIN";
            this.loginbut.UseVisualStyleBackColor = true;
            this.loginbut.Click += new System.EventHandler(this.loginbut_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.loginbut);
            this.Controls.Add(this.adminlb);
            this.Controls.Add(this.passtxbox);
            this.Controls.Add(this.pswlb);
            this.Controls.Add(this.usertxbox);
            this.Controls.Add(this.userlb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LOGIN";
            this.Text = "LOGIN Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label userlb;
        private System.Windows.Forms.TextBox usertxbox;
        private System.Windows.Forms.Label pswlb;
        private System.Windows.Forms.TextBox passtxbox;
        private System.Windows.Forms.Label adminlb;
        private System.Windows.Forms.Button loginbut;
    }
}

