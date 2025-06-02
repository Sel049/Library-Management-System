namespace MYLIBRARY
{
    partial class search_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_form));
            this.searchbtn = new System.Windows.Forms.Button();
            this.SearchDataGridView = new System.Windows.Forms.DataGridView();
            this.backbut = new System.Windows.Forms.Button();
            this.displayALLbtn = new System.Windows.Forms.Button();
            this.search_viewLB = new System.Windows.Forms.Label();
            this.searchTxBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bid_nmae = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(537, 146);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(103, 39);
            this.searchbtn.TabIndex = 60;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // SearchDataGridView
            // 
            this.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGridView.Location = new System.Drawing.Point(29, 200);
            this.SearchDataGridView.Name = "SearchDataGridView";
            this.SearchDataGridView.RowHeadersWidth = 62;
            this.SearchDataGridView.RowTemplate.Height = 28;
            this.SearchDataGridView.Size = new System.Drawing.Size(819, 375);
            this.SearchDataGridView.TabIndex = 59;
            this.SearchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchDataGridView_CellContentClick);
            // 
            // backbut
            // 
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbut.Location = new System.Drawing.Point(914, 417);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(155, 54);
            this.backbut.TabIndex = 58;
            this.backbut.Text = "BACK";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // displayALLbtn
            // 
            this.displayALLbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayALLbtn.Location = new System.Drawing.Point(903, 299);
            this.displayALLbtn.Name = "displayALLbtn";
            this.displayALLbtn.Size = new System.Drawing.Size(175, 54);
            this.displayALLbtn.TabIndex = 57;
            this.displayALLbtn.Text = "DISPLAY ALL";
            this.displayALLbtn.UseVisualStyleBackColor = true;
            this.displayALLbtn.Click += new System.EventHandler(this.displayALLbtn_Click);
            // 
            // search_viewLB
            // 
            this.search_viewLB.AutoSize = true;
            this.search_viewLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_viewLB.Location = new System.Drawing.Point(463, 93);
            this.search_viewLB.Name = "search_viewLB";
            this.search_viewLB.Size = new System.Drawing.Size(248, 25);
            this.search_viewLB.TabIndex = 56;
            this.search_viewLB.Text = "SEARCH/VIEW BOOKS";
            // 
            // searchTxBox
            // 
            this.searchTxBox.Location = new System.Drawing.Point(341, 152);
            this.searchTxBox.Name = "searchTxBox";
            this.searchTxBox.Size = new System.Drawing.Size(190, 26);
            this.searchTxBox.TabIndex = 55;
            this.searchTxBox.TextChanged += new System.EventHandler(this.searchTxBox_TextChanged);
            this.searchTxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxBox_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // bid_nmae
            // 
            this.bid_nmae.AutoSize = true;
            this.bid_nmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid_nmae.Location = new System.Drawing.Point(188, 155);
            this.bid_nmae.Name = "bid_nmae";
            this.bid_nmae.Size = new System.Drawing.Size(132, 20);
            this.bid_nmae.TabIndex = 61;
            this.bid_nmae.Text = "BOOKID/NAME";
            // 
            // search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.bid_nmae);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.SearchDataGridView);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.displayALLbtn);
            this.Controls.Add(this.search_viewLB);
            this.Controls.Add(this.searchTxBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "search_form";
            this.Text = "SEARCH/VIEW BOOKS";
            this.Load += new System.EventHandler(this.search_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView SearchDataGridView;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Button displayALLbtn;
        private System.Windows.Forms.Label search_viewLB;
        private System.Windows.Forms.TextBox searchTxBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bid_nmae;
    }
}