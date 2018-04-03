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
using System.IO;

namespace VTSBiblioteka
{
    public partial class Login : Form
    {
        MySQL sql;
        ChangePassword changePass;
        Library library;
        LibraryStudent libStudent;
        RecordOfBooksPractice robPractice;
        Config config;
        public Login()
        {
            InitializeComponent();
            sql = new MySQL();
            changePass = new ChangePassword();
            library = new Library();
            libStudent = new LibraryStudent();
            robPractice = new RecordOfBooksPractice();
            config = new Config();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Connection();
                bool t = sql.LoginRead(comboUsername.Text, txtPassword.Text, "prijavljivanje");
                sql.Close();
                if (t == true)
                {
                    if (comboUsername.Text == "studenti")
                    {
                        this.Hide();
                        libStudent.ShowDialog();
                    }
                    else if (comboUsername.Text == "praksa")
                    {
                        this.Hide();
                        robPractice.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        library.ShowDialog();
                    }
                }
                else
                {
                    comboUsername.SelectedIndex = 0;
                    txtPassword.Text = "";
                    cbShowPassword.Checked = false;
                    MessageBox.Show("Unesite ispravno korisničko ime i lozinku!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch
            {
                MessageBox.Show("Greška pri konekciji! Proverite internet!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

        private void labChangePassword_Click(object sender, EventArgs e)
        {
            comboUsername.SelectedIndex = 0;
            txtPassword.Text = "";
            cbShowPassword.Checked = false;
            changePass.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                sql.Connection();
                sql.ReadTable("KorisnickoIme", "prijavljivanje");
                sql.Close();
                int login_lenght = sql.login.Count;
                comboUsername.Items.Add(" ");
                for (int i = 0; i < login_lenght; i++)
                {
                    comboUsername.Items.Add(sql.login[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška pri konekciji! Proverite internet!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void comboUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUsername.Text == "Dragana")
            {
                labChangePassword.Enabled = true;
            }
            else
            {
                labChangePassword.Enabled = false;
            }
        }
    }
}
