namespace MYLIBRARY
{
    partial class Add_Bo_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Bo_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addlb = new System.Windows.Forms.Label();
            this.bid_nmae = new System.Windows.Forms.Label();
            this.BorowerId_txbox = new System.Windows.Forms.TextBox();
            this.Bo_Name_Lb = new System.Windows.Forms.Label();
            this.nameTxbox = new System.Windows.Forms.TextBox();
            this.emailLb = new System.Windows.Forms.Label();
            this.Emailtxbox = new System.Windows.Forms.TextBox();
            this.savebut = new System.Windows.Forms.Button();
            this.backbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneTxBox = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(219, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // addlb
            // 
            this.addlb.AutoSize = true;
            this.addlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlb.Location = new System.Drawing.Point(290, 44);
            this.addlb.Name = "addlb";
            this.addlb.Size = new System.Drawing.Size(203, 25);
            this.addlb.TabIndex = 16;
            this.addlb.Text = "ADD BORROWERS";
            // 
            // bid_nmae
            // 
            this.bid_nmae.AutoSize = true;
            this.bid_nmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid_nmae.Location = new System.Drawing.Point(133, 120);
            this.bid_nmae.Name = "bid_nmae";
            this.bid_nmae.Size = new System.Drawing.Size(133, 20);
            this.bid_nmae.TabIndex = 71;
            this.bid_nmae.Text = "BORROWERID";
            // 
            // BorowerId_txbox
            // 
            this.BorowerId_txbox.Location = new System.Drawing.Point(285, 117);
            this.BorowerId_txbox.Name = "BorowerId_txbox";
            this.BorowerId_txbox.Size = new System.Drawing.Size(190, 26);
            this.BorowerId_txbox.TabIndex = 72;
            this.BorowerId_txbox.TextChanged += new System.EventHandler(this.BorowerId_txbox_TextChanged);
            // 
            // Bo_Name_Lb
            // 
            this.Bo_Name_Lb.AutoSize = true;
            this.Bo_Name_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bo_Name_Lb.Location = new System.Drawing.Point(207, 174);
            this.Bo_Name_Lb.Name = "Bo_Name_Lb";
            this.Bo_Name_Lb.Size = new System.Drawing.Size(59, 20);
            this.Bo_Name_Lb.TabIndex = 73;
            this.Bo_Name_Lb.Text = "NAME";
            // 
            // nameTxbox
            // 
            this.nameTxbox.Location = new System.Drawing.Point(285, 168);
            this.nameTxbox.Name = "nameTxbox";
            this.nameTxbox.Size = new System.Drawing.Size(190, 26);
            this.nameTxbox.TabIndex = 74;
            this.nameTxbox.TextChanged += new System.EventHandler(this.nameTxbox_TextChanged);
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLb.Location = new System.Drawing.Point(203, 225);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(63, 20);
            this.emailLb.TabIndex = 75;
            this.emailLb.Text = "EMAIL";
            // 
            // Emailtxbox
            // 
            this.Emailtxbox.Location = new System.Drawing.Point(285, 219);
            this.Emailtxbox.Name = "Emailtxbox";
            this.Emailtxbox.Size = new System.Drawing.Size(190, 26);
            this.Emailtxbox.TabIndex = 76;
            this.Emailtxbox.TextChanged += new System.EventHandler(this.Emailtxbox_TextChanged);
            // 
            // savebut
            // 
            this.savebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebut.Location = new System.Drawing.Point(147, 345);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(155, 54);
            this.savebut.TabIndex = 77;
            this.savebut.Text = "SAVE";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // backbut
            // 
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbut.Location = new System.Drawing.Point(415, 345);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(155, 54);
            this.backbut.TabIndex = 78;
            this.backbut.Text = "BACK";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "PHONE";
            // 
            // PhoneTxBox
            // 
            this.PhoneTxBox.Location = new System.Drawing.Point(285, 261);
            this.PhoneTxBox.Name = "PhoneTxBox";
            this.PhoneTxBox.Size = new System.Drawing.Size(190, 26);
            this.PhoneTxBox.TabIndex = 80;
            this.PhoneTxBox.TextChanged += new System.EventHandler(this.PhoneTxBox_TextChanged);
            this.PhoneTxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTxBox_KeyPress);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn.Location = new System.Drawing.Point(496, 108);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(127, 37);
            this.GenerateBtn.TabIndex = 81;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // Add_Bo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.PhoneTxBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.Emailtxbox);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.nameTxbox);
            this.Controls.Add(this.Bo_Name_Lb);
            this.Controls.Add(this.BorowerId_txbox);
            this.Controls.Add(this.bid_nmae);
            this.Controls.Add(this.addlb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Add_Bo_Form";
            this.Text = "ADD BORROWERS FORM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label addlb;
        private System.Windows.Forms.Label bid_nmae;
        private System.Windows.Forms.TextBox BorowerId_txbox;
        private System.Windows.Forms.Label Bo_Name_Lb;
        private System.Windows.Forms.TextBox nameTxbox;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.TextBox Emailtxbox;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneTxBox;
        private System.Windows.Forms.Button GenerateBtn;
    }
}