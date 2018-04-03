namespace VTSBiblioteka
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labStudent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labIndex = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearchIndexNumber = new System.Windows.Forms.Button();
            this.btnSearchMembershipCard = new System.Windows.Forms.Button();
            this.txtIndexNumber = new System.Windows.Forms.TextBox();
            this.txtMembershipCard = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(661, 465);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 39);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Štampaj";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Izađi";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(613, 574);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 465);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "ВИСОКА ТЕХНОЛОШКА ШКОЛА СТРУКОВНИХ СТУДИЈА - АРАНЂЕЛОВАЦ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(134, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 32);
            this.label2.TabIndex = 42;
            this.label2.Text = "ПОТВРДА О РАЗДУЖЕЊУ ИЗ БИБЛИОТЕКЕ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Студент/киња,";
            // 
            // labStudent
            // 
            this.labStudent.AutoSize = true;
            this.labStudent.Location = new System.Drawing.Point(159, 146);
            this.labStudent.Name = "labStudent";
            this.labStudent.Size = new System.Drawing.Size(346, 21);
            this.labStudent.TabIndex = 44;
            this.labStudent.Text = "________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "нема задужења у библиотеци Високе технолошке школе струковних";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Број индекса";
            // 
            // labIndex
            // 
            this.labIndex.AutoSize = true;
            this.labIndex.Location = new System.Drawing.Point(149, 267);
            this.labIndex.Name = "labIndex";
            this.labIndex.Size = new System.Drawing.Size(232, 21);
            this.labIndex.TabIndex = 47;
            this.labIndex.Text = "_____________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 21);
            this.label8.TabIndex = 48;
            this.label8.Text = "Библиотекарка, Драгана Вуковић";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 21);
            this.label9.TabIndex = 49;
            this.label9.Text = "_____________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-21, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(826, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "_________________________________________________________________________________" +
    "_______________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Датум";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(113, 639);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(411, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(556, 146);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 21);
            this.label13.TabIndex = 59;
            this.label13.Text = "студија - Аранђеловац.";
            // 
            // btnSearchIndexNumber
            // 
            this.btnSearchIndexNumber.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchIndexNumber.Location = new System.Drawing.Point(334, 460);
            this.btnSearchIndexNumber.Name = "btnSearchIndexNumber";
            this.btnSearchIndexNumber.Size = new System.Drawing.Size(190, 29);
            this.btnSearchIndexNumber.TabIndex = 3;
            this.btnSearchIndexNumber.Text = "Pretraga po Broju Indeksa";
            this.btnSearchIndexNumber.UseVisualStyleBackColor = true;
            this.btnSearchIndexNumber.Click += new System.EventHandler(this.btnSearchIndexNumber_Click_1);
            // 
            // btnSearchMembershipCard
            // 
            this.btnSearchMembershipCard.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchMembershipCard.Location = new System.Drawing.Point(335, 419);
            this.btnSearchMembershipCard.Name = "btnSearchMembershipCard";
            this.btnSearchMembershipCard.Size = new System.Drawing.Size(189, 29);
            this.btnSearchMembershipCard.TabIndex = 1;
            this.btnSearchMembershipCard.Text = "Pretraga po Članskoj Karti";
            this.btnSearchMembershipCard.UseVisualStyleBackColor = true;
            this.btnSearchMembershipCard.Click += new System.EventHandler(this.btnSearchMembershipCard_Click_1);
            // 
            // txtIndexNumber
            // 
            this.txtIndexNumber.Location = new System.Drawing.Point(114, 462);
            this.txtIndexNumber.Name = "txtIndexNumber";
            this.txtIndexNumber.Size = new System.Drawing.Size(214, 29);
            this.txtIndexNumber.TabIndex = 2;
            // 
            // txtMembershipCard
            // 
            this.txtMembershipCard.Location = new System.Drawing.Point(114, 420);
            this.txtMembershipCard.Name = "txtMembershipCard";
            this.txtMembershipCard.Size = new System.Drawing.Size(214, 29);
            this.txtMembershipCard.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 21);
            this.label12.TabIndex = 65;
            this.label12.Text = "Broj Indeksa *";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 21);
            this.label14.TabIndex = 64;
            this.label14.Text = "Članska Karta";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 504);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(238, 29);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(113, 545);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 29);
            this.txtLastName.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 69;
            this.label11.Text = "Prezime *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 507);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 21);
            this.label15.TabIndex = 68;
            this.label15.Text = "Ime *";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClean.Location = new System.Drawing.Point(367, 586);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(80, 29);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Očisti";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(113, 586);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(238, 29);
            this.date.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 592);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 21);
            this.label16.TabIndex = 72;
            this.label16.Text = "Datum *";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(105, 306);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(238, 21);
            this.labDate.TabIndex = 73;
            this.labDate.Text = "______________________________________";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 684);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSearchIndexNumber);
            this.Controls.Add(this.btnSearchMembershipCard);
            this.Controls.Add(this.txtIndexNumber);
            this.Controls.Add(this.txtMembershipCard);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labIndex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrint);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Print_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearchIndexNumber;
        private System.Windows.Forms.Button btnSearchMembershipCard;
        private System.Windows.Forms.TextBox txtIndexNumber;
        private System.Windows.Forms.TextBox txtMembershipCard;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labDate;
    }
}