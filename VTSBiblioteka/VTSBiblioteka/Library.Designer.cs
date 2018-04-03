namespace VTSBiblioteka
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.btnRecordOfBooks = new System.Windows.Forms.Button();
            this.btnRecordOfMembers = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.btnRediscoverBooks = new System.Windows.Forms.Button();
            this.btnBorrowingBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecordOfBooks
            // 
            this.btnRecordOfBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordOfBooks.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecordOfBooks.Location = new System.Drawing.Point(867, 480);
            this.btnRecordOfBooks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRecordOfBooks.Name = "btnRecordOfBooks";
            this.btnRecordOfBooks.Size = new System.Drawing.Size(169, 70);
            this.btnRecordOfBooks.TabIndex = 5;
            this.btnRecordOfBooks.Text = "Evidencija Knjiga";
            this.btnRecordOfBooks.UseVisualStyleBackColor = true;
            this.btnRecordOfBooks.Click += new System.EventHandler(this.btnRecordOfBooks_Click);
            // 
            // btnRecordOfMembers
            // 
            this.btnRecordOfMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordOfMembers.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecordOfMembers.Location = new System.Drawing.Point(867, 391);
            this.btnRecordOfMembers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRecordOfMembers.Name = "btnRecordOfMembers";
            this.btnRecordOfMembers.Size = new System.Drawing.Size(169, 70);
            this.btnRecordOfMembers.TabIndex = 4;
            this.btnRecordOfMembers.Text = "Evidencija Članova";
            this.btnRecordOfMembers.UseVisualStyleBackColor = true;
            this.btnRecordOfMembers.Click += new System.EventHandler(this.btnRecordOfMembers_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(251, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(495, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pretraga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(846, 482);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(762, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 31);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Osveži";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboSearch
            // 
            this.comboSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "po serijskom broju",
            "po naslovu",
            "po autoru"});
            this.comboSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            " ",
            "po Inventarnom Broju",
            "po UDK Broju",
            "po ISBN Broju",
            "po Naslovu",
            "po Autoru",
            "po Izdavaču",
            "po Predmetnoj Odrednici"});
            this.comboSearch.Location = new System.Drawing.Point(72, 23);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(173, 29);
            this.comboSearch.TabIndex = 0;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged_1);
            // 
            // btnRediscoverBooks
            // 
            this.btnRediscoverBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRediscoverBooks.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRediscoverBooks.Location = new System.Drawing.Point(867, 152);
            this.btnRediscoverBooks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRediscoverBooks.Name = "btnRediscoverBooks";
            this.btnRediscoverBooks.Size = new System.Drawing.Size(169, 70);
            this.btnRediscoverBooks.TabIndex = 3;
            this.btnRediscoverBooks.Text = "Razduživanje knjiga";
            this.btnRediscoverBooks.UseVisualStyleBackColor = true;
            this.btnRediscoverBooks.Click += new System.EventHandler(this.btnRediscoverBooks_Click);
            // 
            // btnBorrowingBooks
            // 
            this.btnBorrowingBooks.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrowingBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowingBooks.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBorrowingBooks.Location = new System.Drawing.Point(867, 66);
            this.btnBorrowingBooks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBorrowingBooks.Name = "btnBorrowingBooks";
            this.btnBorrowingBooks.Size = new System.Drawing.Size(169, 70);
            this.btnBorrowingBooks.TabIndex = 2;
            this.btnBorrowingBooks.Text = "Zaduživanje knjiga";
            this.btnBorrowingBooks.UseVisualStyleBackColor = true;
            this.btnBorrowingBooks.Click += new System.EventHandler(this.btnBorrowingBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(857, 250);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 561);
            this.Controls.Add(this.btnRediscoverBooks);
            this.Controls.Add(this.btnBorrowingBooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRecordOfBooks);
            this.Controls.Add(this.btnRecordOfMembers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTS Biblioteka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Library_FormClosing);
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordOfBooks;
        private System.Windows.Forms.Button btnRecordOfMembers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRediscoverBooks;
        private System.Windows.Forms.Button btnBorrowingBooks;
    }
}