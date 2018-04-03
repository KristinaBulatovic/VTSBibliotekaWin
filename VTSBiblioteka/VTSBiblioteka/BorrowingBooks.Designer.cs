namespace VTSBiblioteka
{
    partial class BorrowingBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowingBooks));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUdk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSearchMembershipCard = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIndexNumber = new System.Windows.Forms.TextBox();
            this.txtMembershipCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchIndexNumber = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateBorrowing = new System.Windows.Forms.DateTimePicker();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(573, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUdk
            // 
            this.txtUdk.Location = new System.Drawing.Point(149, 386);
            this.txtUdk.Name = "txtUdk";
            this.txtUdk.Size = new System.Drawing.Size(393, 29);
            this.txtUdk.TabIndex = 9;
            this.txtUdk.TextChanged += new System.EventHandler(this.txtUdk_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "UDKBroj Knjige *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 60;
            this.label7.Text = "Broj Telefona";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 59;
            this.label8.Text = "Email";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClean.Location = new System.Drawing.Point(428, 324);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(114, 29);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Očisti";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(126, 278);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(416, 29);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(416, 29);
            this.txtEmail.TabIndex = 7;
            // 
            // btnSearchMembershipCard
            // 
            this.btnSearchMembershipCard.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchMembershipCard.Location = new System.Drawing.Point(563, 16);
            this.btnSearchMembershipCard.Name = "btnSearchMembershipCard";
            this.btnSearchMembershipCard.Size = new System.Drawing.Size(189, 29);
            this.btnSearchMembershipCard.TabIndex = 1;
            this.btnSearchMembershipCard.Text = "Pretraga po Članskoj Karti";
            this.btnSearchMembershipCard.UseVisualStyleBackColor = true;
            this.btnSearchMembershipCard.Click += new System.EventHandler(this.btnSearchMembershipCard_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(126, 186);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(416, 29);
            this.txtAddress.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(416, 29);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(126, 141);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(416, 29);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtIndexNumber
            // 
            this.txtIndexNumber.Location = new System.Drawing.Point(126, 59);
            this.txtIndexNumber.Name = "txtIndexNumber";
            this.txtIndexNumber.Size = new System.Drawing.Size(416, 29);
            this.txtIndexNumber.TabIndex = 2;
            // 
            // txtMembershipCard
            // 
            this.txtMembershipCard.Location = new System.Drawing.Point(126, 17);
            this.txtMembershipCard.Name = "txtMembershipCard";
            this.txtMembershipCard.Size = new System.Drawing.Size(416, 29);
            this.txtMembershipCard.TabIndex = 0;
            this.txtMembershipCard.TextChanged += new System.EventHandler(this.txtMembershipCard_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Prezime *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ime *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Broj Indeksa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Članska Karta *";
            // 
            // btnSearchIndexNumber
            // 
            this.btnSearchIndexNumber.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchIndexNumber.Location = new System.Drawing.Point(562, 58);
            this.btnSearchIndexNumber.Name = "btnSearchIndexNumber";
            this.btnSearchIndexNumber.Size = new System.Drawing.Size(190, 29);
            this.btnSearchIndexNumber.TabIndex = 3;
            this.btnSearchIndexNumber.Text = "Pretraga po Broju Indeksa";
            this.btnSearchIndexNumber.UseVisualStyleBackColor = true;
            this.btnSearchIndexNumber.Click += new System.EventHandler(this.btnSearchIndexNumber_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 433);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 63;
            this.label9.Text = "Datum zaduživanja *";
            // 
            // dateBorrowing
            // 
            this.dateBorrowing.Location = new System.Drawing.Point(149, 427);
            this.dateBorrowing.Name = "dateBorrowing";
            this.dateBorrowing.Size = new System.Drawing.Size(393, 29);
            this.dateBorrowing.TabIndex = 10;
            // 
            // dateReturn
            // 
            this.dateReturn.Location = new System.Drawing.Point(148, 468);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(393, 29);
            this.dateReturn.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 474);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 66;
            this.label10.Text = "Datum vraćanja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 233);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // BorrowingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateBorrowing);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSearchIndexNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSearchMembershipCard);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtIndexNumber);
            this.Controls.Add(this.txtMembershipCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUdk);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "BorrowingBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaduživanje knjiga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrowingBooks_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUdk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSearchMembershipCard;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIndexNumber;
        private System.Windows.Forms.TextBox txtMembershipCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchIndexNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateBorrowing;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}