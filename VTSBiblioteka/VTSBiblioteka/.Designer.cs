namespace VTSBiblioteka
{
    partial class StudentRecords
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrowing = new System.Windows.Forms.Button();
            this.btnRedundancy = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboSearch
            // 
            this.comboSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "po serijskom broju",
            "po nazivu",
            "po autoru"});
            this.comboSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "po UDKBroju",
            "po Nazivu",
            "po Autoru",
            "po Indeksu",
            "po ImenuStudenta",
            "po PrezimenuStudenta"});
            this.comboSearch.Location = new System.Drawing.Point(90, 143);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(194, 30);
            this.comboSearch.TabIndex = 29;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(296, 145);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(461, 29);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Pretraga";
            // 
            // btnBorrowing
            // 
            this.btnBorrowing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowing.Location = new System.Drawing.Point(90, 40);
            this.btnBorrowing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrowing.Name = "btnBorrowing";
            this.btnBorrowing.Size = new System.Drawing.Size(291, 51);
            this.btnBorrowing.TabIndex = 32;
            this.btnBorrowing.Text = "Zaduživanje studenata";
            this.btnBorrowing.UseVisualStyleBackColor = true;
            this.btnBorrowing.Click += new System.EventHandler(this.btnBorrowing_Click);
            // 
            // btnRedundancy
            // 
            this.btnRedundancy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedundancy.Location = new System.Drawing.Point(491, 40);
            this.btnRedundancy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRedundancy.Name = "btnRedundancy";
            this.btnRedundancy.Size = new System.Drawing.Size(291, 51);
            this.btnRedundancy.TabIndex = 33;
            this.btnRedundancy.Text = "Razduživanje studenata";
            this.btnRedundancy.UseVisualStyleBackColor = true;
            this.btnRedundancy.Click += new System.EventHandler(this.btnRedundancy_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(766, 141);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 35);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Osveži";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 533);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRedundancy);
            this.Controls.Add(this.btnBorrowing);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentRecords";
            this.Text = "Evidencija Studenata";
            this.Load += new System.EventHandler(this.StudentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBorrowing;
        private System.Windows.Forms.Button btnRedundancy;
        private System.Windows.Forms.Button btnRefresh;
    }
}