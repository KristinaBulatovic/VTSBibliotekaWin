namespace VTSBiblioteka
{
    partial class RecordOfBooksPractice
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYearPublication = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInventoryNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPublisher = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboAuthor = new System.Windows.Forms.ComboBox();
            this.btnSearchInventoryNum = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtUDK = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labBookNum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNote.Location = new System.Drawing.Point(598, 189);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(276, 98);
            this.txtNote.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(514, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 86;
            this.label12.Text = "Napomena";
            // 
            // txtYearPublication
            // 
            this.txtYearPublication.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtYearPublication.Location = new System.Drawing.Point(125, 154);
            this.txtYearPublication.Name = "txtYearPublication";
            this.txtYearPublication.Size = new System.Drawing.Size(357, 29);
            this.txtYearPublication.TabIndex = 5;
            this.txtYearPublication.TextChanged += new System.EventHandler(this.txtYearPublication_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(14, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 21);
            this.label11.TabIndex = 85;
            this.label11.Text = "Godina Izdanja *";
            // 
            // txtInventoryNum
            // 
            this.txtInventoryNum.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInventoryNum.Location = new System.Drawing.Point(125, 12);
            this.txtInventoryNum.Name = "txtInventoryNum";
            this.txtInventoryNum.Size = new System.Drawing.Size(221, 29);
            this.txtInventoryNum.TabIndex = 0;
            this.txtInventoryNum.TextChanged += new System.EventHandler(this.txtInventoryNum_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(14, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 21);
            this.label10.TabIndex = 84;
            this.label10.Text = "Inventarni Broj *";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtISBN.Location = new System.Drawing.Point(125, 83);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(221, 29);
            this.txtISBN.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(14, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 83;
            this.label9.Text = "ISBN Broj";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddCategory.Location = new System.Drawing.Point(880, 83);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(130, 29);
            this.btnAddCategory.TabIndex = 11;
            this.btnAddCategory.Text = "Dodaj Kategoriju";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddPublisher.Location = new System.Drawing.Point(880, 48);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(130, 29);
            this.btnAddPublisher.TabIndex = 9;
            this.btnAddPublisher.Text = "Dodaj Izdavača";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddAuthor.Location = new System.Drawing.Point(880, 12);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(130, 29);
            this.btnAddAuthor.TabIndex = 7;
            this.btnAddAuthor.Text = "Dodaj Autora";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // comboLanguage
            // 
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Location = new System.Drawing.Point(598, 119);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(276, 29);
            this.comboLanguage.TabIndex = 13;
            this.comboLanguage.SelectedIndexChanged += new System.EventHandler(this.comboLanguage_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(514, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 82;
            this.label8.Text = "Jezik *";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(598, 82);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(276, 29);
            this.comboCategory.TabIndex = 10;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(514, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 81;
            this.label7.Text = "Kategorija *";
            // 
            // comboPublisher
            // 
            this.comboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPublisher.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboPublisher.FormattingEnabled = true;
            this.comboPublisher.Location = new System.Drawing.Point(598, 47);
            this.comboPublisher.Name = "comboPublisher";
            this.comboPublisher.Size = new System.Drawing.Size(276, 29);
            this.comboPublisher.TabIndex = 8;
            this.comboPublisher.SelectedIndexChanged += new System.EventHandler(this.comboPublisher_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(514, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 80;
            this.label6.Text = "Izdavač *";
            // 
            // comboAuthor
            // 
            this.comboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthor.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboAuthor.FormattingEnabled = true;
            this.comboAuthor.Location = new System.Drawing.Point(598, 12);
            this.comboAuthor.Name = "comboAuthor";
            this.comboAuthor.Size = new System.Drawing.Size(276, 29);
            this.comboAuthor.TabIndex = 6;
            this.comboAuthor.SelectedIndexChanged += new System.EventHandler(this.comboAuthor_SelectedIndexChanged);
            // 
            // btnSearchInventoryNum
            // 
            this.btnSearchInventoryNum.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchInventoryNum.Location = new System.Drawing.Point(352, 12);
            this.btnSearchInventoryNum.Name = "btnSearchInventoryNum";
            this.btnSearchInventoryNum.Size = new System.Drawing.Size(130, 29);
            this.btnSearchInventoryNum.TabIndex = 1;
            this.btnSearchInventoryNum.Text = "Pretraga";
            this.btnSearchInventoryNum.UseVisualStyleBackColor = true;
            this.btnSearchInventoryNum.Click += new System.EventHandler(this.btnSearchInventoryNum_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.Enabled = false;
            this.btnChange.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChange.Location = new System.Drawing.Point(212, 245);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(153, 42);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Izmeni Knjigu";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtState.Location = new System.Drawing.Point(598, 154);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(276, 29);
            this.txtState.TabIndex = 14;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // txtUDK
            // 
            this.txtUDK.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUDK.Location = new System.Drawing.Point(125, 48);
            this.txtUDK.Name = "txtUDK";
            this.txtUDK.Size = new System.Drawing.Size(221, 29);
            this.txtUDK.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(125, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 29);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 79;
            this.label5.Text = "Naslov *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(514, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 78;
            this.label4.Text = "Stanje *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(514, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Autor *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "UDK Broj";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(413, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 42);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Obriši Knjigu";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(18, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 42);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Dodaj Knjigu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboSearch
            // 
            this.comboSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "po serijskom broju",
            "po nazivu",
            "po autoru"});
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "",
            "po Inventarnom Broju",
            "po UDK Broju",
            "po ISBN Broju",
            "po Naslovu",
            "po Autoru",
            "po Izdavaču",
            "po Predmetnoj Odrednici"});
            this.comboSearch.Location = new System.Drawing.Point(76, 350);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(170, 29);
            this.comboSearch.TabIndex = 20;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(254, 350);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(620, 29);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "Pretraga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 393);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 223);
            this.dataGridView1.TabIndex = 74;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClean.Location = new System.Drawing.Point(949, 252);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(130, 29);
            this.btnClean.TabIndex = 19;
            this.btnClean.Text = "Očisti";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(1016, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 100);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Osveži";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labBookNum
            // 
            this.labBookNum.AutoSize = true;
            this.labBookNum.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBookNum.Location = new System.Drawing.Point(165, 305);
            this.labBookNum.Name = "labBookNum";
            this.labBookNum.Size = new System.Drawing.Size(0, 25);
            this.labBookNum.TabIndex = 88;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(13, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 25);
            this.label13.TabIndex = 87;
            this.label13.Text = "Ukupan broj knjiga:";
            // 
            // RecordOfBooksPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 622);
            this.Controls.Add(this.labBookNum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtYearPublication);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInventoryNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.comboLanguage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboPublisher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboAuthor);
            this.Controls.Add(this.btnSearchInventoryNum);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtUDK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "RecordOfBooksPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija Knjiga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecordOfBooksPractice_FormClosing);
            this.Load += new System.EventHandler(this.RecordOfBooksPractice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYearPublication;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInventoryNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboAuthor;
        private System.Windows.Forms.Button btnSearchInventoryNum;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtUDK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labBookNum;
        private System.Windows.Forms.Label label13;
    }
}