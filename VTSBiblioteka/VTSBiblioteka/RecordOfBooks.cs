﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VTSBiblioteka
{
    public partial class RecordOfBooks : Form
    {
        MySQL sql;
        AddAuthor add_author;
        AddCategory add_category;
        AddPublisher add_publisher;
        Statistics statistics;
        Config config;
        public RecordOfBooks()
        {
            InitializeComponent();
            sql = new MySQL();
            add_author = new AddAuthor();
            add_category = new AddCategory();
            add_publisher = new AddPublisher();
            statistics = new Statistics();
            config = new Config();
        }

        public void BookNum()
        {
            sql.Connection();
            sql.ReadID("knjige");
            sql.Close();
            int id = 0;
            for (int i = 0; i < sql.id.Count; i++)
            {
                id++;
            }

            labBookNum.Text = id.ToString();
        }

        public void SearchBooks(string query)
        {
            string connString = "Server=" + config.servername + ";Port=3306;Database=" + config.db + ";Uid= " + config.username + ";password=" + config.password + ";CharSet=utf8;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 60;
            column = dataGridView1.Columns[1];
            column.Width = 60;
            column = dataGridView1.Columns[2];
            column.Width = 60;
            column = dataGridView1.Columns[3];
            column.Width = 200;
            column = dataGridView1.Columns[4];
            column.Width = 60;
            column = dataGridView1.Columns[6];
            column.Width = 150;
            column = dataGridView1.Columns[7];
            column.Width = 150;
            column = dataGridView1.Columns[8];
            column.Width = 60;
            column = dataGridView1.Columns[9];
            column.Width = 60;
        }

        public void Book(string inventoryNum, string udk, string isbn, string name, string yearPublication, string author, string publisher, string category, string language, string state, string note)
        {
            txtInventoryNum.Text = inventoryNum;
            txtUDK.Text = udk;
            txtISBN.Text = isbn;
            txtName.Text = name;
            txtYearPublication.Text = yearPublication;
            comboAuthor.Text = author;
            comboPublisher.Text = publisher;
            comboCategory.Text = category;
            comboLanguage.Text = language;
            txtState.Text = state;
            txtNote.Text = note;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool bookRead = sql.BookRead(txtUDK.Text, "knjige");
            sql.Close();
            if (!bookRead)
            {
                if (sql.AuthorPublisherCategoryLanguageRead(comboAuthor.Text, "autori"))
                {
                    if (sql.AuthorPublisherCategoryLanguageRead(comboPublisher.Text, "izdavaci"))
                    {
                        if (sql.AuthorPublisherCategoryLanguageRead(comboCategory.Text, "kategorije"))
                        {
                            if (sql.AuthorPublisherCategoryLanguageRead(comboLanguage.Text, "jezik"))
                            {
                                sql.Connection();
                                bool result = sql.InsertBook(txtInventoryNum.Text, txtUDK.Text, txtISBN.Text, txtName.Text, txtYearPublication.Text, comboAuthor.Text, comboPublisher.Text, comboCategory.Text, comboLanguage.Text, txtState.Text, txtNote.Text, "knjige");
                                sql.Close();
                                if (result)
                                {
                                    comboAuthor.SelectedIndex = 0;
                                    comboPublisher.SelectedIndex = 0;
                                    comboCategory.SelectedIndex = 0;
                                    comboLanguage.SelectedIndex = 0;
                                    comboSearch.SelectedIndex = 0;
                                    Book("", "", "", "", "", "", "", "", "", "", "");
                                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra ORDER BY knjige.Naslov asc";
                                    SearchBooks(query);
                                    BookNum();
                                    MessageBox.Show("Uspešno ste dodali knjigu!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else MessageBox.Show("Greška pri dodavanju knjige!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Molimo Vas dodajte neki od ponuđenih jezika!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Molimo Vas dodajte neku od ponuđenih kategorija!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Molimo Vas dodajte nekog od ponuđenih izdavača!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Molimo Vas dodajte nekog od ponuđenih autora!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Knjiga već postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool bookRead = sql.BookRead(txtUDK.Text, "knjige");
            sql.Close();
            if (bookRead)
            {
                if (sql.AuthorPublisherCategoryLanguageRead(comboAuthor.Text, "autori"))
                {
                    if (sql.AuthorPublisherCategoryLanguageRead(comboPublisher.Text, "izdavaci"))
                    {
                        if (sql.AuthorPublisherCategoryLanguageRead(comboCategory.Text, "kategorije"))
                        {
                            if (sql.AuthorPublisherCategoryLanguageRead(comboLanguage.Text, "jezik"))
                            {
                                sql.Connection();
                                bool result = sql.UpdateBook(txtInventoryNum.Text, txtUDK.Text, txtISBN.Text, txtName.Text, txtYearPublication.Text, comboAuthor.Text, comboPublisher.Text, comboCategory.Text, comboLanguage.Text, txtState.Text, txtNote.Text, "knjige");
                                sql.Close();
                                if (result)
                                {
                                    comboAuthor.SelectedIndex = 0;
                                    comboPublisher.SelectedIndex = 0;
                                    comboCategory.SelectedIndex = 0;
                                    comboLanguage.SelectedIndex = 0;
                                    comboSearch.SelectedIndex = 0;
                                    Book("", "", "", "", "", "", "", "", "", "", "");
                                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra ORDER BY knjige.Naslov asc";
                                    SearchBooks(query);
                                    MessageBox.Show("Uspešno ste izmenili knjigu!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else MessageBox.Show("Greška pri izmeni knjige!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Molimo Vas dodajte neki od ponuđenih jezika!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Molimo Vas dodajte neku od ponuđenih kategorija!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Molimo Vas dodajte nekog od ponuđenih izdavača!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Molimo Vas dodajte nekog od ponuđenih autora!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Knjiga ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.DeleteBook(txtUDK.Text, "knjige");
            sql.Close();
            if (result)
            {
                comboAuthor.SelectedIndex = 0;
                comboPublisher.SelectedIndex = 0;
                comboCategory.SelectedIndex = 0;
                comboLanguage.SelectedIndex = 0;
                comboSearch.SelectedIndex = 0;
                Book("", "", "", "", "", "", "", "", "", "", "");
                string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra ORDER BY knjige.Naslov asc";
                SearchBooks(query);
                BookNum();
                MessageBox.Show("Uspešno ste obrisali knjigu!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Greška pri brisanju knjige!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RecordOfBooks_Load(object sender, EventArgs e)
        {
            BookNum();

            string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra ORDER BY knjige.Naslov asc";
            SearchBooks(query);

            sql.Connection();
            sql.ReadTable("ImePrezime", "autori");
            sql.Close();
            int author_lenght = sql.author.Count;
            comboAuthor.Items.Add(" ");
            for (int i = 0; i < author_lenght; i++)
            {
                comboAuthor.Items.Add(sql.author[i]);
            }

            sql.Connection();
            sql.ReadTable("Naziv","izdavaci");
            sql.Close();
            int publisher_lenght = sql.publisher.Count;
            comboPublisher.Items.Add(" ");
            for (int i = 0; i < publisher_lenght; i++)
            {
                comboPublisher.Items.Add(sql.publisher[i]);
            }

            sql.Connection();
            sql.ReadTable("Naziv","kategorije");
            sql.Close();
            int category_lenght = sql.category.Count;
            comboCategory.Items.Add(" ");
            for (int i = 0; i < category_lenght; i++)
            {
                comboCategory.Items.Add(sql.category[i]);
            }

            sql.Connection();
            sql.ReadTable("Naziv","jezik");
            sql.Close();
            int language_lenght = sql.language.Count;
            comboLanguage.Items.Add(" ");
            for (int i = 0; i < language_lenght; i++)
            {
                comboLanguage.Items.Add(sql.language[i]);
            }
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (comboSearch.Text != "" && comboSearch.Text != " ")
            {
                txtSearch.Enabled = true;
            }
            else
            {
                txtSearch.Text = "";
                txtSearch.Enabled = false;
            }
        }

        private void btnSearchUDK_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadBook(txtUDK.Text, "knjige");
            sql.Close();
            if (result)
            {
                Book(sql.book[0], sql.book[1], sql.book[2], sql.book[3], sql.book[4], sql.book[5], sql.book[6], sql.book[7], sql.book[8], sql.book[9], sql.book[10]);
            }
            else
            {
                comboAuthor.SelectedIndex = 0;
                comboPublisher.SelectedIndex = 0;
                comboCategory.SelectedIndex = 0;
                comboLanguage.SelectedIndex = 0;
                Book("", "", "", "", "", "", "", "", "", "", "");
                MessageBox.Show("UDK Broj ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridView1.DataSource = null;
                string search_books = txtSearch.Text;

                if (comboSearch.Text == "po Inventarnom Broju")
                {
                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra where LOWER(knjige.InventarniBroj) LIKE '%" + search_books.ToLower() + "%' ORDER BY knjige.Naslov asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po UDK Broju")
                {
                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra where LOWER(knjige.UDKBroj) LIKE '%" + search_books.ToLower() + "%' ORDER BY knjige.Naslov asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po ISBN Broju")
                {
                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra where LOWER(knjige.ISBNBroj) LIKE '%" + search_books.ToLower() + "%' ORDER BY knjige.Naslov asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Naslovu")
                {
                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra where LOWER(knjige.Naslov) LIKE '%" + search_books.ToLower() + "%' ORDER BY knjige.Naslov asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Autoru")
                {
                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra where LOWER(autori.ImePrezime) LIKE '%" + search_books.ToLower() + "%' ORDER BY knjige.Naslov asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Izdavaču")
                {
                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra where LOWER(izdavaci.Naziv) LIKE '%" + search_books.ToLower() + "%' ORDER BY knjige.Naslov asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Predmetnoj Odrednici")
                {
                    string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra where LOWER(kategorije.Naziv) LIKE '%" + search_books.ToLower() + "%' ORDER BY knjige.Naslov asc";
                    SearchBooks(query);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra ORDER BY knjige.Naslov asc";
                SearchBooks(query);
            }
        }

        private void RecordOfBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            comboAuthor.Items.Clear();
            comboPublisher.Items.Clear();
            comboCategory.Items.Clear();
            comboLanguage.Items.Clear();
            Book("", "", "", "", "", "", "", "", "", "", "");
            comboSearch.SelectedIndex = 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            comboAuthor.SelectedIndex = 0;
            comboPublisher.SelectedIndex = 0;
            comboCategory.SelectedIndex = 0;
            comboLanguage.SelectedIndex = 0;
            Book("", "", "", "", "", "", "", "", "", "", "");
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            add_author.ShowDialog();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            add_publisher.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            add_category.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboAuthor.Items.Clear();
            comboPublisher.Items.Clear();
            comboCategory.Items.Clear();

            sql.Connection();
            sql.ReadTable("ImePrezime", "autori");
            sql.Close();
            int author_lenght = sql.author.Count;
            comboAuthor.Items.Add(" ");
            for (int i = 0; i < author_lenght; i++)
            {
                comboAuthor.Items.Add(sql.author[i]);
            }

            sql.Connection();
            sql.ReadTable("Naziv", "izdavaci");
            sql.Close();
            int publisher_lenght = sql.publisher.Count;
            comboPublisher.Items.Add(" ");
            for (int i = 0; i < publisher_lenght; i++)
            {
                comboPublisher.Items.Add(sql.publisher[i]);
            }

            sql.Connection();
            sql.ReadTable("Naziv", "kategorije");
            sql.Close();
            int category_lenght = sql.category.Count;
            comboCategory.Items.Add(" ");
            for (int i = 0; i < category_lenght; i++)
            {
                comboCategory.Items.Add(sql.category[i]);
            }
        }

        private void txtUDK_TextChanged(object sender, EventArgs e)
        {
            if (txtUDK.Text != "" && txtName.Text != "" && comboAuthor.Text != "" && comboPublisher.Text != "" && comboCategory.Text != "" && comboLanguage.Text != "" && txtState.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }

            if (txtUDK.Text != "")
            {
                btnDelete.Enabled = true;
            }
            else btnDelete.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtUDK.Text != "" && txtName.Text != "" && comboAuthor.Text != "" && comboPublisher.Text != " " && comboCategory.Text != "" && comboLanguage.Text != " " && txtState.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void comboAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUDK.Text != "" && txtName.Text != "" && comboAuthor.Text != "" && comboPublisher.Text != " " && comboCategory.Text != "" && comboLanguage.Text != " " && txtState.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void comboPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUDK.Text != "" && txtName.Text != "" && comboAuthor.Text != "" && comboPublisher.Text != " " && comboCategory.Text != "" && comboLanguage.Text != " " && txtState.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUDK.Text != "" && txtName.Text != "" && comboAuthor.Text != "" && comboPublisher.Text != " " && comboCategory.Text != "" && comboLanguage.Text != " " && txtState.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUDK.Text != "" && txtName.Text != "" && comboAuthor.Text != "" && comboPublisher.Text != " " && comboCategory.Text != "" && comboLanguage.Text != " " && txtState.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            if (txtUDK.Text != "" && txtName.Text != "" && comboAuthor.Text != "" && comboPublisher.Text != " " && comboCategory.Text != "" && comboLanguage.Text != " " && txtState.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            statistics.ShowDialog();
        }
    }
}
