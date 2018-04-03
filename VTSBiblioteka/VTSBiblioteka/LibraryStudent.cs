using System;
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
    public partial class LibraryStudent : Form
    {
        MySQL sql;
        Config config;
        public LibraryStudent()
        {
            InitializeComponent();
            sql = new MySQL();
            config = new Config();
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
            column = dataGridView1.Columns[4];
            column.Width = 60;
            column = dataGridView1.Columns[8];
            column.Width = 60;
            column = dataGridView1.Columns[9];
            column.Width = 60;
        }

        private void LibraryStudent_Load(object sender, EventArgs e)
        {
            string query = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, jezik.Naziv as Jezik, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra ORDER BY knjige.Naslov asc";
            SearchBooks(query);
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

        private void LibraryStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
