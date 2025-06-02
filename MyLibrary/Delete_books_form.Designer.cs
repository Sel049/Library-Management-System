namespace MYLIBRARY
{
    partial class DeleteFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFrame));
            this.searchbtn = new System.Windows.Forms.Button();
            this.DeleteDataGridView = new System.Windows.Forms.DataGridView();
            this.backbut = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.deleteLb = new System.Windows.Forms.Label();
            this.searchTxBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bid_nmae = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(555, 139);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(103, 41);
            this.searchbtn.TabIndex = 52;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // DeleteDataGridView
            // 
            this.DeleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataGridView.Location = new System.Drawing.Point(29, 200);
            this.DeleteDataGridView.Name = "DeleteDataGridView";
            this.DeleteDataGridView.RowHeadersWidth = 62;
            this.DeleteDataGridView.RowTemplate.Height = 28;
            this.DeleteDataGridView.Size = new System.Drawing.Size(819, 375);
            this.DeleteDataGridView.TabIndex = 51;
            this.DeleteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteDataGridView_CellContentClick);
            // 
            // backbut
            // 
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbut.Location = new System.Drawing.Point(903, 414);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(155, 54);
            this.backbut.TabIndex = 50;
            this.backbut.Text = "BACK";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(903, 299);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(155, 54);
            this.deletebtn.TabIndex = 49;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // deleteLb
            // 
            this.deleteLb.AutoSize = true;
            this.deleteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLb.Location = new System.Drawing.Point(463, 93);
            this.deleteLb.Name = "deleteLb";
            this.deleteLb.Size = new System.Drawing.Size(179, 25);
            this.deleteLb.TabIndex = 48;
            this.deleteLb.Text = "DELETE BOOKS";
            // 
            // searchTxBox
            // 
            this.searchTxBox.Location = new System.Drawing.Point(341, 152);
            this.searchTxBox.Name = "searchTxBox";
            this.searchTxBox.Size = new System.Drawing.Size(190, 26);
            this.searchTxBox.TabIndex = 47;
            this.searchTxBox.TextChanged += new System.EventHandler(this.searchTxBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // bid_nmae
            // 
            this.bid_nmae.AutoSize = true;
            this.bid_nmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid_nmae.Location = new System.Drawing.Point(194, 155);
            this.bid_nmae.Name = "bid_nmae";
            this.bid_nmae.Size = new System.Drawing.Size(132, 20);
            this.bid_nmae.TabIndex = 62;
            this.bid_nmae.Text = "BOOKID/NAME";
            // 
            // DeleteFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.bid_nmae);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.DeleteDataGridView);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.deleteLb);
            this.Controls.Add(this.searchTxBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeleteFrame";
            this.Text = "DELETE BOOKS ";
            this.Load += new System.EventHandler(this.DeleteFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView DeleteDataGridView;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label deleteLb;
        private System.Windows.Forms.TextBox searchTxBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bid_nmae;
    }
}