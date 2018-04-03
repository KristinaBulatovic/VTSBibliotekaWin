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
    public partial class AddAuthorPractice : Form
    {

        MySQL sql;
        Config config;
        public AddAuthorPractice()
        {
            InitializeComponent();
            sql = new MySQL();
            config = new Config();
        }

        public void SearchAuthor(string query)
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
            column = dataGridView1.Columns[2];
            column.Width = 60;
            column = dataGridView1.Columns[3];
            column.Width = 60;
            column = dataGridView1.Columns[4];
            column.Width = 150;
        }
        public void Author(string code, string name, string country, string years, string note)
        {
            txtCode.Text = code;
            txtName.Text = name;
            txtCountry.Text = country;
            txtYears.Text = years;
            txtNote.Text = note;
        }

        private void AddAuthorPractice_Load(object sender, EventArgs e)
        {
            string query = "select Sifra, ImePrezime, Zemlja, Godina, Napomena from autori_praksa ORDER BY ImePrezime asc";
            SearchAuthor(query);
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

                if (comboSearch.Text == "po Sifri")
                {
                    string query = "select Sifra, ImePrezime, Zemlja, Godina, Napomena from autori_praksa where LOWER(Sifra) LIKE '%" + search_books.ToLower() + "%' ORDER BY ImePrezime asc";
                    SearchAuthor(query);
                }
                else if (comboSearch.Text == "po Imenu i Prezimenu")
                {
                    string query = "select Sifra, ImePrezime, Zemlja, Godina, Napomena from autori_praksa where LOWER(ImePrezime) LIKE '%" + search_books.ToLower() + "%' ORDER BY ImePrezime asc";
                    SearchAuthor(query);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select Sifra, ImePrezime, Zemlja, Godina, Napomena from autori_praksa ORDER BY ImePrezime asc";
                SearchAuthor(query);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Author("", "", "", "", "");
        }

        private void AddAuthorPractice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Author("", "", "", "", "");
            comboSearch.SelectedIndex = 0;
        }

        private void btnSearchCode_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadAuthor(txtCode.Text, "autori_praksa");
            sql.Close();
            if (result)
            {
                Author(sql.author_sql[0], sql.author_sql[1], sql.author_sql[2], sql.author_sql[3], sql.author_sql[4]);
            }
            else
            {
                Author("", "", "", "", "");
                MessageBox.Show("Šifra ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool authorRead = sql.AuthorRead(txtCode.Text, "autori_praksa");
            sql.Close();
            if (!authorRead)
            {
                sql.Connection();
                bool result = sql.InsertAuthor(txtCode.Text, txtName.Text, txtCountry.Text, txtYears.Text, txtNote.Text, "autori_praksa");
                sql.Close();
                if (result)
                {
                    Author("", "", "", "", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select Sifra, ImePrezime, Zemlja, Godina, Napomena from autori_praksa ORDER BY ImePrezime asc";
                    SearchAuthor(query);
                    MessageBox.Show("Uspešno ste dodali autora!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri dodavanju autora!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Autor već postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool authorRead = sql.AuthorRead(txtCode.Text, "autori_praksa");
            sql.Close();
            if (authorRead)
            {
                sql.Connection();
                bool result = sql.UpdateAuthor(txtCode.Text, txtName.Text, txtCountry.Text, txtYears.Text, txtNote.Text, "autori_praksa");
                sql.Close();
                if (result)
                {
                    Author("", "", "", "", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select Sifra, ImePrezime, Zemlja, Godina, Napomena from autori_praksa ORDER BY ImePrezime asc";
                    SearchAuthor(query);
                    MessageBox.Show("Uspešno ste izmenili autora!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri izmeni autora!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Autor ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.DeleteCode(txtCode.Text, "autori_praksa");
            sql.Close();
            if (result)
            {
                Author("", "", "", "", "");
                comboSearch.SelectedIndex = 0;
                string query = "select Sifra, ImePrezime, Zemlja, Godina, Napomena from autori_praksa ORDER BY ImePrezime asc";
                SearchAuthor(query);
                MessageBox.Show("Uspešno ste obrisali autora!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Greška pri brisanju autora!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
