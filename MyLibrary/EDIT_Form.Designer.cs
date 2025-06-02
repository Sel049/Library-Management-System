namespace MYLIBRARY
{
    partial class Edit_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_book));
            this.backbut = new System.Windows.Forms.Button();
            this.savebut = new System.Windows.Forms.Button();
            this.editLb = new System.Windows.Forms.Label();
            this.EditTxbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditDataGridView = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.bid_nmae = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backbut
            // 
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbut.Location = new System.Drawing.Point(903, 414);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(155, 54);
            this.backbut.TabIndex = 42;
            this.backbut.Text = "BACK";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // savebut
            // 
            this.savebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebut.Location = new System.Drawing.Point(903, 299);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(155, 54);
            this.savebut.TabIndex = 33;
            this.savebut.Text = "SAVE";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // editLb
            // 
            this.editLb.AutoSize = true;
            this.editLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLb.Location = new System.Drawing.Point(463, 93);
            this.editLb.Name = "editLb";
            this.editLb.Size = new System.Drawing.Size(145, 25);
            this.editLb.TabIndex = 32;
            this.editLb.Text = "EDIT BOOKS";
            // 
            // EditTxbox
            // 
            this.EditTxbox.Location = new System.Drawing.Point(341, 152);
            this.EditTxbox.Name = "EditTxbox";
            this.EditTxbox.Size = new System.Drawing.Size(190, 26);
            this.EditTxbox.TabIndex = 29;
            this.EditTxbox.TextChanged += new System.EventHandler(this.EditTxbox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // EditDataGridView
            // 
            this.EditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditDataGridView.Location = new System.Drawing.Point(29, 200);
            this.EditDataGridView.Name = "EditDataGridView";
            this.EditDataGridView.RowHeadersWidth = 62;
            this.EditDataGridView.RowTemplate.Height = 28;
            this.EditDataGridView.Size = new System.Drawing.Size(819, 375);
            this.EditDataGridView.TabIndex = 43;
            this.EditDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditDataGridView_CellContentClick);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(556, 140);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(103, 47);
            this.searchbtn.TabIndex = 44;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // bid_nmae
            // 
            this.bid_nmae.AutoSize = true;
            this.bid_nmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid_nmae.Location = new System.Drawing.Point(179, 155);
            this.bid_nmae.Name = "bid_nmae";
            this.bid_nmae.Size = new System.Drawing.Size(132, 20);
            this.bid_nmae.TabIndex = 62;
            this.bid_nmae.Text = "BOOKID/NAME";
            // 
            // Edit_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.bid_nmae);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.EditDataGridView);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.editLb);
            this.Controls.Add(this.EditTxbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Edit_book";
            this.Text = "EDIT BOOKS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Label editLb;
        private System.Windows.Forms.TextBox EditTxbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView EditDataGridView;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label bid_nmae;
    }
}