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
    public partial class RecordOfMembers : Form
    {
        MySQL sql;
        Print print;
        Config config;
        public RecordOfMembers()
        {
            InitializeComponent();
            sql = new MySQL();
            print = new Print();
            config = new Config();
        }

        public void SearchMembers(string query)
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

            DataGridViewColumn column = dataGridView1.Columns[6];
            column.Width = 120;
        }

        public void Members(string membershipCard, string indexNumber, string firstName, string lastName, string address, string email, string phoneNumber)
        {
            txtMembershipCard.Text = membershipCard;
            txtIndexNumber.Text = indexNumber;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtAddress.Text = address;
            txtEmail.Text = email;
            txtPhoneNumber.Text = phoneNumber;
        }

        private void RecordOfMembers_Load(object sender, EventArgs e)
        {
            string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi ORDER BY Prezime, Ime asc";
            SearchMembers(query);
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

                if (comboSearch.Text == "po Članskoj Karti")
                {
                    string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi where LOWER(ClanskaKarta) LIKE '%" + search_books.ToLower() + "%' ORDER BY Prezime, Ime asc";
                    SearchMembers(query);
                }
                else if (comboSearch.Text == "po Broju Indeksa")
                {
                    string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi where LOWER(BrojIndeksa) LIKE '%" + search_books.ToLower() + "%' ORDER BY Prezime, Ime asc";
                    SearchMembers(query);
                }
                else if (comboSearch.Text == "po Imenu")
                {
                    string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi where LOWER(Ime) LIKE '%" + search_books.ToLower() + "%' ORDER BY Prezime, Ime asc";
                    SearchMembers(query);
                }
                else if (comboSearch.Text == "po Prezimenu")
                {
                    string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi where LOWER(Prezime) LIKE '%" + search_books.ToLower() + "%' ORDER BY Prezime, Ime asc";
                    SearchMembers(query);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi ORDER BY Prezime, Ime asc";
                SearchMembers(query);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Members("", "", "", "", "", "", "");
        }

        private void RecordOfMembers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Members("", "", "", "", "", "", "");
            comboSearch.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool membersRead = sql.MembersRead(txtMembershipCard.Text, "clanovi");
            sql.Close();
            if (!membersRead)
            {
                sql.Connection();
                bool result = sql.InsertMembers(txtMembershipCard.Text, txtIndexNumber.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, "clanovi");
                sql.Close();
                if (result)
                {
                    Members("", "", "", "", "", "", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi ORDER BY Prezime, Ime asc";
                    SearchMembers(query);
                    MessageBox.Show("Uspešno ste dodali člana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri dodavanju člana!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Član već postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool membersRead = sql.MembersRead(txtMembershipCard.Text, "clanovi");
            sql.Close();
            if (membersRead)
            {
                sql.Connection();
                bool result = sql.UpdateMembers(txtMembershipCard.Text, txtIndexNumber.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, "clanovi");
                sql.Close();
                if (result)
                {
                    Members("", "", "", "", "", "", "");
                    comboSearch.SelectedIndex = 0;
                    string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi ORDER BY Prezime, Ime asc";
                    SearchMembers(query);
                    MessageBox.Show("Uspešno ste izmenili člana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Greška pri izmeni člana!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Član ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.DeleteMembers(txtMembershipCard.Text, "clanovi");
            sql.Close();
            if (result)
            {
                Members("", "", "", "", "", "", "");
                comboSearch.SelectedIndex = 0;
                string query = "select ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon from clanovi ORDER BY Prezime, Ime asc";
                SearchMembers(query);
                MessageBox.Show("Uspešno ste obrisali člana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Greška pri brisanju člana!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearchMembershipCard_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadMembers(txtMembershipCard.Text, "clanovi", "MembershipCard");
            sql.Close();
            if (result)
            {
                Members(sql.members[0], sql.members[1], sql.members[2], sql.members[3], sql.members[4], sql.members[5], sql.members[6]);
            }
            else
            {
                Members("", "", "", "", "", "", "");
                MessageBox.Show("Članska karta ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchIndexNumber_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadMembers(txtIndexNumber.Text, "clanovi", "IndexNumber");
            sql.Close();
            if (result)
            {
                Members(sql.members[0], sql.members[1], sql.members[2], sql.members[3], sql.members[4], sql.members[5], sql.members[6]);
            }
            else
            {
                Members("", "", "", "", "", "", "");
                MessageBox.Show("Broj indeksa ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMembershipCard_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = false;
            }

                if (txtMembershipCard.Text != "")
            {
                btnDelete.Enabled = true;
            }
            else btnDelete.Enabled = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "")
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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "")
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

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            print.ShowDialog();
        }
    }
}
