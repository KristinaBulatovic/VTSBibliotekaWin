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
    public partial class RediscoverBooks : Form
    {
        MySQL sql;
        Config config;
        public RediscoverBooks()
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
        }

        public void changeState(string udk, string table)
        {
            sql.Connection();
            string state = sql.ReadState(udk, table);
            sql.Close();
            int s = Convert.ToInt32(state);
            s++;
            string newState = s.ToString();
            sql.Connection();
            sql.UpdateBookState(udk, newState, table);
            sql.Close();
        }

        public void Rediscover(string membershipCard, string indexNumber, string udk)
        {
            txtMembershipCard.Text = membershipCard;
            txtIndexNumber.Text = indexNumber;
            txtUDK.Text = udk;
        }

        private void btnRediscover_Click(object sender, EventArgs e)
        {
            sql.Connection();
            string id = sql.IDMembersRead(txtMembershipCard.Text, txtUDK.Text, "zaduzivanje_knjiga");
            sql.Close();
            if (id != "")
            {
                sql.Connection();
                bool result = sql.DeleteBorrowStudent(id, "zaduzivanje_knjiga");
                sql.Close();
                if (result)
                {
                    changeState(txtUDK.Text, "knjige");
                    txtUDK.Text = "";
                    dataGridView1.DataSource = null;
                    string search_books = txtMembershipCard.Text;
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where clanovi.ClanskaKarta LIKE '%" + search_books + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                    MessageBox.Show("Hvala Vam na vraćenoj knjizi!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri razduživanju!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Greška!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RediscoverBooks_Load(object sender, EventArgs e)
        {
            string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra ORDER BY clanovi.Prezime, clanovi.Ime asc";
            SearchBooks(query);
        }

        private void btnSearchMembershipCard_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadRediscover(txtMembershipCard.Text, "zaduzivanje_knjiga", "MembershipCard");
            sql.Close();
            if (result)
            {
                Rediscover(sql.rediscover[0], sql.rediscover[1], sql.rediscover[2]);
            }
            else
            {
                Rediscover("", "", "");
                MessageBox.Show("Članska karta ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchIndexNumber_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadRediscover(txtIndexNumber.Text, "zaduzivanje_knjiga", "IndexNumber");
            sql.Close();
            if (result)
            {
                Rediscover(sql.rediscover[0], sql.rediscover[1], sql.rediscover[2]);
            }
            else
            {
                Rediscover("", "", "");
                MessageBox.Show("Broj indeksa ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMembershipCard_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtUDK.Text != "")
            {
                btnRediscover.Enabled = true;
            }
            else btnRediscover.Enabled = false;

            if (!string.IsNullOrEmpty(txtMembershipCard.Text))
            {
                dataGridView1.DataSource = null;
                string search_books = txtMembershipCard.Text;
                string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(clanovi.ClanskaKarta) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                SearchBooks(query);

            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra ORDER BY clanovi.Prezime, clanovi.Ime asc";
                SearchBooks(query);
            }
        }

        private void txtIndexNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIndexNumber.Text))
            {
                dataGridView1.DataSource = null;
                string search_books = txtIndexNumber.Text;
                string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(clanovi.BrojIndeksa) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                SearchBooks(query);

            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra ORDER BY clanovi.Prezime, clanovi.Ime asc";
                SearchBooks(query);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Rediscover("", "", "");
        }

        private void RediscoverBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rediscover("", "", "");
            comboSearch.SelectedIndex = 0;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridView1.DataSource = null;
                string search_books = txtSearch.Text;

                if (comboSearch.Text == "po Clanskoj Karti")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(clanovi.ClanskaKarta) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Broju Indeksa")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(clanovi.BrojIndeksa) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Imenu")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(clanovi.Ime) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Prezimenu")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(clanovi.Prezime) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Inventarnom Broju")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(knjige.ISBNBroj) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po UDK Broju")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(knjige.UDKBroj) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po ISBN Broju")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(knjige.ISBNBroj) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
                else if (comboSearch.Text == "po Naslovu Knjige")
                {
                    string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra where LOWER(knjige.Naslov) LIKE '%" + search_books.ToLower() + "%' ORDER BY clanovi.Prezime, clanovi.Ime asc";
                    SearchBooks(query);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select clanovi.ClanskaKarta, clanovi.BrojIndeksa, clanovi.Ime , clanovi.Prezime, clanovi.Email, clanovi.Telefon, knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, zk.DatumZaduzivanja, zk.DatumVracanja from clanovi inner join zaduzivanje_knjiga as zk on zk.ClanskaKarta = clanovi.ClanskaKarta inner join knjige on zk.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra ORDER BY clanovi.Prezime, clanovi.Ime asc";
                SearchBooks(query);
            }
        }

        private void txtUDK_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtUDK.Text != "")
            {
                btnRediscover.Enabled = true;
            }
            else btnRediscover.Enabled = false;
        }
    }
}
