namespace VTSBiblioteka
{
    partial class RediscoverBooks
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
            this.btnRediscover = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchIndexNumber = new System.Windows.Forms.Button();
            this.btnSearchMembershipCard = new System.Windows.Forms.Button();
            this.txtIndexNumber = new System.Windows.Forms.TextBox();
            this.txtMembershipCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUDK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRediscover
            // 
            this.btnRediscover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRediscover.Enabled = false;
            this.btnRediscover.Location = new System.Drawing.Point(788, 127);
            this.btnRediscover.Name = "btnRediscover";
            this.btnRediscover.Size = new System.Drawing.Size(184, 46);
            this.btnRediscover.TabIndex = 5;
            this.btnRediscover.Text = "Razduži";
            this.btnRediscover.UseVisualStyleBackColor = false;
            this.btnRediscover.Click += new System.EventHandler(this.btnRediscover_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(960, 303);
            this.dataGridView1.TabIndex = 41;
            // 
            // comboSearch
            // 
            this.comboSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "po serijskom broju",
            "po nazivu",
            "po autoru"});
            this.comboSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "",
            "po Clanskoj Karti",
            "po Broju Indeksa",
            "po Imenu",
            "po Prezimenu",
            "po Inventarnom Broju",
            "po UDK Broju",
            "po ISBN Broju",
            "po Naslovu Knjige"});
            this.comboSearch.Location = new System.Drawing.Point(82, 209);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(133, 29);
            this.comboSearch.TabIndex = 7;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(221, 209);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(751, 29);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Pretraga";
            // 
            // btnSearchIndexNumber
            // 
            this.btnSearchIndexNumber.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchIndexNumber.Location = new System.Drawing.Point(556, 60);
            this.btnSearchIndexNumber.Name = "btnSearchIndexNumber";
            this.btnSearchIndexNumber.Size = new System.Drawing.Size(190, 29);
            this.btnSearchIndexNumber.TabIndex = 3;
            this.btnSearchIndexNumber.Text = "Pretraga po Broju Indeksa";
            this.btnSearchIndexNumber.UseVisualStyleBackColor = true;
            this.btnSearchIndexNumber.Click += new System.EventHandler(this.btnSearchIndexNumber_Click);
            // 
            // btnSearchMembershipCard
            // 
            this.btnSearchMembershipCard.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchMembershipCard.Location = new System.Drawing.Point(556, 18);
            this.btnSearchMembershipCard.Name = "btnSearchMembershipCard";
            this.btnSearchMembershipCard.Size = new System.Drawing.Size(189, 29);
            this.btnSearchMembershipCard.TabIndex = 1;
            this.btnSearchMembershipCard.Text = "Pretraga po Članskoj Karti";
            this.btnSearchMembershipCard.UseVisualStyleBackColor = true;
            this.btnSearchMembershipCard.Click += new System.EventHandler(this.btnSearchMembershipCard_Click);
            // 
            // txtIndexNumber
            // 
            this.txtIndexNumber.Location = new System.Drawing.Point(134, 61);
            this.txtIndexNumber.Name = "txtIndexNumber";
            this.txtIndexNumber.Size = new System.Drawing.Size(416, 29);
            this.txtIndexNumber.TabIndex = 2;
            this.txtIndexNumber.TextChanged += new System.EventHandler(this.txtIndexNumber_TextChanged);
            // 
            // txtMembershipCard
            // 
            this.txtMembershipCard.Location = new System.Drawing.Point(134, 19);
            this.txtMembershipCard.Name = "txtMembershipCard";
            this.txtMembershipCard.Size = new System.Drawing.Size(416, 29);
            this.txtMembershipCard.TabIndex = 0;
            this.txtMembershipCard.TextChanged += new System.EventHandler(this.txtMembershipCard_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Broj Indeksa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Članska Karta *";
            // 
            // txtUDK
            // 
            this.txtUDK.Location = new System.Drawing.Point(134, 104);
            this.txtUDK.Name = "txtUDK";
            this.txtUDK.Size = new System.Drawing.Size(416, 29);
            this.txtUDK.TabIndex = 4;
            this.txtUDK.TextChanged += new System.EventHandler(this.txtUDK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "UDKBroj Knjige *";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClean.Location = new System.Drawing.Point(421, 144);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(129, 29);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Očisti";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // RediscoverBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtUDK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchIndexNumber);
            this.Controls.Add(this.btnSearchMembershipCard);
            this.Controls.Add(this.txtIndexNumber);
            this.Controls.Add(this.txtMembershipCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRediscover);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RediscoverBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Razduživanje knjiga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RediscoverBooks_FormClosing);
            this.Load += new System.EventHandler(this.RediscoverBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRediscover;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchIndexNumber;
        private System.Windows.Forms.Button btnSearchMembershipCard;
        private System.Windows.Forms.TextBox txtIndexNumber;
        private System.Windows.Forms.TextBox txtMembershipCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClean;
    }
}