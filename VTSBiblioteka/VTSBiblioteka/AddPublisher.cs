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
    public partial class AddPublisher : Form
    {
        MySQL sql;
        Config config;
        public AddPublisher()
        {
            InitializeComponent();
            sql = new MySQL();
            config = new Config();
        }

        public void SearchPublisher(string query)
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
            column.Width = 200;
        }
        public void Publisher(string code, string name, string location, string address, string phone, string web, string email)
        {
            txtCode.Text = code;
            txtName.Text = name;
            txtLocation.Text = location;
            txtAddress.Text = address;
            txtPhone.Text = phone;
            txtWeb.Text = web;
            txtEmail.Text = email;
        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {
            string query = "select Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email from izdavaci ORDER BY Naziv asc";
            SearchPublisher(query);
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

                if (comboSearch.Text == "po Šifri")
                {
                    string query = "select Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email from izdavaci where LOWER(Sifra) LIKE '%" + search_books.ToLower() + "%' ORDER BY Naziv asc";
                    SearchPublisher(query);
                }
                else if (comboSearch.Text == "po Nazivu")
                {
                    string query = "select Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email from izdavaci where LOWER(Naziv) LIKE '%" + search_books.ToLower() + "%' ORDER BY Naziv asc";
                    SearchPublisher(query);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email from izdavaci ORDER BY Naziv asc";
                SearchPublisher(query);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Publisher("", "", "", "", "", "", "");
        }

        private void AddPublisher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Publisher("", "", "", "", "", "", "");
            comboSearch.SelectedIndex = 0;
        }

        private void btnSearchCode_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadPublisher(txtCode.Text, "izdavaci");
            sql.Close();
            if (result)
            {
                Publisher(sql.publisher_sql[0], sql.publisher_sql[1], sql.publisher_sql[2], sql.publisher_sql[3], sql.publisher_sql[4], sql.publisher_sql[5], sql.publisher_sql[6]);
            }
            else
            {
                Publisher("", "", "", "", "", "", "");
                MessageBox.Show("Šifra ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool publisherRead = sql.PublisherRead(txtCode.Text, "izdavaci");
            sql.Close();
            if (!publisherRead)
            {
                sql.Connection();
                bool result = sql.InsertPublisher(txtCode.Text, txtName.Text, txtLocation.Text, txtAddress.Text, txtPhone.Text, txtWeb.Text, txtEmail.Text, "izdavaci");
                sql.Close();
                if (result)
                {
                    Publisher("", "", "", "", "", "", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email from izdavaci ORDER BY Naziv asc";
                    SearchPublisher(query);
                    MessageBox.Show("Uspešno ste dodali izdavača!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri dodavanju izdavača!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Izdavač već postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool publisherRead = sql.PublisherRead(txtCode.Text, "izdavaci");
            sql.Close();
            if (publisherRead)
            {
                sql.Connection();
                bool result = sql.UpdatePublisher(txtCode.Text, txtName.Text, txtLocation.Text, txtAddress.Text, txtPhone.Text, txtWeb.Text, txtEmail.Text, "izdavaci");
                sql.Close();
                if (result)
                {
                    Publisher("", "", "", "", "", "", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email from izdavaci ORDER BY Naziv asc";
                    SearchPublisher(query);
                    MessageBox.Show("Uspešno ste izmenili izdavača!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri izmeni izdavača!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Izdavač ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.DeleteCode(txtCode.Text, "izdavaci");
            sql.Close();
            if (result)
            {
                Publisher("", "", "", "", "", "", "");
                comboSearch.SelectedIndex = 0;
                string query = "select Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email from izdavaci ORDER BY Naziv asc";
                SearchPublisher(query);
                MessageBox.Show("Uspešno ste obrisali izdavača!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Greška pri brisanju izdavača!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text != "" && txtName.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }

                if (txtCode.Text != "")
            {
                btnDelete.Enabled = true;
            }
            else btnDelete.Enabled = false; 
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text != "" && txtName.Text != "")
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
    }
}
