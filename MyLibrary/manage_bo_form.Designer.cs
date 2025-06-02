namespace MYLIBRARY
{
    partial class manage_bo_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_bo_form));
            this.bid_nmae = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SearchDataGridView = new System.Windows.Forms.DataGridView();
            this.backbut = new System.Windows.Forms.Button();
            this.addBoBtn = new System.Windows.Forms.Button();
            this.manage_lb = new System.Windows.Forms.Label();
            this.searchTxBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditBoBtn = new System.Windows.Forms.Button();
            this.deleteBoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bid_nmae
            // 
            this.bid_nmae.AutoSize = true;
            this.bid_nmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid_nmae.Location = new System.Drawing.Point(129, 155);
            this.bid_nmae.Name = "bid_nmae";
            this.bid_nmae.Size = new System.Drawing.Size(188, 20);
            this.bid_nmae.TabIndex = 70;
            this.bid_nmae.Text = "BORROWERID/NAME";
            this.bid_nmae.Click += new System.EventHandler(this.bid_nmae_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(549, 141);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(103, 44);
            this.searchbtn.TabIndex = 69;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // SearchDataGridView
            // 
            this.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGridView.Location = new System.Drawing.Point(27, 222);
            this.SearchDataGridView.Name = "SearchDataGridView";
            this.SearchDataGridView.RowHeadersWidth = 62;
            this.SearchDataGridView.RowTemplate.Height = 28;
            this.SearchDataGridView.Size = new System.Drawing.Size(839, 375);
            this.SearchDataGridView.TabIndex = 68;
            this.SearchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchDataGridView_CellContentClick);
            // 
            // backbut
            // 
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbut.Location = new System.Drawing.Point(903, 535);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(175, 54);
            this.backbut.TabIndex = 67;
            this.backbut.Text = "BACK";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // addBoBtn
            // 
            this.addBoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBoBtn.Location = new System.Drawing.Point(903, 222);
            this.addBoBtn.Name = "addBoBtn";
            this.addBoBtn.Size = new System.Drawing.Size(175, 54);
            this.addBoBtn.TabIndex = 66;
            this.addBoBtn.Text = "Add Borrower";
            this.addBoBtn.UseVisualStyleBackColor = true;
            this.addBoBtn.Click += new System.EventHandler(this.addBoBtn_Click);
            // 
            // manage_lb
            // 
            this.manage_lb.AutoSize = true;
            this.manage_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_lb.Location = new System.Drawing.Point(463, 93);
            this.manage_lb.Name = "manage_lb";
            this.manage_lb.Size = new System.Drawing.Size(251, 25);
            this.manage_lb.TabIndex = 65;
            this.manage_lb.Text = "MANAGE BORROWERS";
            // 
            // searchTxBox
            // 
            this.searchTxBox.Location = new System.Drawing.Point(341, 152);
            this.searchTxBox.Name = "searchTxBox";
            this.searchTxBox.Size = new System.Drawing.Size(190, 26);
            this.searchTxBox.TabIndex = 64;
            this.searchTxBox.TextChanged += new System.EventHandler(this.searchTxBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // EditBoBtn
            // 
            this.EditBoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBoBtn.Location = new System.Drawing.Point(903, 318);
            this.EditBoBtn.Name = "EditBoBtn";
            this.EditBoBtn.Size = new System.Drawing.Size(175, 54);
            this.EditBoBtn.TabIndex = 71;
            this.EditBoBtn.Text = "Edit Borrower";
            this.EditBoBtn.UseVisualStyleBackColor = true;
            this.EditBoBtn.Click += new System.EventHandler(this.EditBoBtn_Click);
            // 
            // deleteBoBtn
            // 
            this.deleteBoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBoBtn.Location = new System.Drawing.Point(885, 416);
            this.deleteBoBtn.Name = "deleteBoBtn";
            this.deleteBoBtn.Size = new System.Drawing.Size(221, 55);
            this.deleteBoBtn.TabIndex = 72;
            this.deleteBoBtn.Text = "Delete Borrower";
            this.deleteBoBtn.UseVisualStyleBackColor = true;
            this.deleteBoBtn.Click += new System.EventHandler(this.deleteBoBtn_Click);
            // 
            // manage_bo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.deleteBoBtn);
            this.Controls.Add(this.EditBoBtn);
            this.Controls.Add(this.bid_nmae);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.SearchDataGridView);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.addBoBtn);
            this.Controls.Add(this.manage_lb);
            this.Controls.Add(this.searchTxBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "manage_bo_form";
            this.Text = "MANAGE BORROWER FORM";
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bid_nmae;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView SearchDataGridView;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Button addBoBtn;
        private System.Windows.Forms.Label manage_lb;
        private System.Windows.Forms.TextBox searchTxBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EditBoBtn;
        private System.Windows.Forms.Button deleteBoBtn;
    }
}