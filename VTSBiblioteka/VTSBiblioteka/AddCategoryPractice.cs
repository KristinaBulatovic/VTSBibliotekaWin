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
    public partial class AddCategoryPractice : Form
    {
        MySQL sql;
        Config config;
        public AddCategoryPractice()
        {
            InitializeComponent();
            sql = new MySQL();
            config = new Config();
        }

        public void SearchCategory(string query)
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
        public void Category(string code, string name)
        {
            txtCode.Text = code;
            txtName.Text = name;
        }

        private void AddCategoryPractice_Load(object sender, EventArgs e)
        {
            string query = "select Sifra, Naziv from kategorije_praksa ORDER BY Naziv asc";
            SearchCategory(query);
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
                    string query = "select Sifra, Naziv from kategorije_praksa where LOWER(Sifra) LIKE '%" + search_books.ToLower() + "%' ORDER BY Naziv asc";
                    SearchCategory(query);
                }
                else if (comboSearch.Text == "po Nazivu")
                {
                    string query = "select Sifra, Naziv from kategorije_praksa where LOWER(Naziv) LIKE '%" + search_books.ToLower() + "%' ORDER BY Naziv asc";
                    SearchCategory(query);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select Sifra, Naziv from kategorije_praksa ORDER BY Naziv asc";
                SearchCategory(query);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Category("", "");
        }

        private void AddCategoryPractice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Category("", "");
            comboSearch.SelectedIndex = 0;
        }

        private void btnSearchCode_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadCategory(txtCode.Text, "kategorije_praksa");
            sql.Close();
            if (result)
            {
                Category(sql.category_sql[0], sql.category_sql[1]);
            }
            else
            {
                Category("", "");
                MessageBox.Show("Šifra ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool categoryRead = sql.CategoryRead(txtCode.Text, "kategorije_praksa");
            sql.Close();
            if (!categoryRead)
            {
                sql.Connection();
                bool result = sql.InsertCategory(txtCode.Text, txtName.Text, "kategorije_praksa");
                sql.Close();
                if (result)
                {
                    Category("", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select Sifra, Naziv from kategorije_praksa ORDER BY Naziv asc";
                    SearchCategory(query);
                    MessageBox.Show("Uspešno ste dodali kategoriju!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri dodavanju kategorije!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Kategorija već postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool categoryRead = sql.CategoryRead(txtCode.Text, "kategorije_praksa");
            sql.Close();
            if (categoryRead)
            {
                sql.Connection();
                bool result = sql.UpdateCategory(txtCode.Text, txtName.Text, "kategorije_praksa");
                sql.Close();
                if (result)
                {
                    Category("", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select Sifra, Naziv from kategorije_praksa ORDER BY Naziv asc";
                    SearchCategory(query);
                    MessageBox.Show("Uspešno ste izmenili kategoriju!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri izmeni kategorije!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Kategorija ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.DeleteCode(txtCode.Text, "kategorije_praksa");
            sql.Close();
            if (result)
            {
                Category("", "");
                comboSearch.SelectedIndex = 0;
                string query = "select Sifra, Naziv from kategorije_praksa ORDER BY Naziv asc";
                SearchCategory(query);
                MessageBox.Show("Uspešno ste obrisali kategoriju!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Greška pri brisanju kategorije!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
