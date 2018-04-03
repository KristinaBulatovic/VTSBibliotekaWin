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
    public partial class ChangePassword : Form
    {
        MySQL sql;
        public ChangePassword()
        {
            InitializeComponent();
            sql = new MySQL();
        }

        private void changePass (string username, string currentPass, string newPass, string confirmPass, bool showPass)
        {
            txtUsername.Text = username;
            txtCurrentPassword.Text = currentPass;
            txtNewPassword.Text = newPass;
            txtConfirmPassword.Text = confirmPass;
            cbShowPassword.Checked = showPass;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Connection();
                bool t = sql.LoginRead(txtUsername.Text, txtCurrentPassword.Text, "prijavljivanje");
                sql.Close();
                if (t == true)
                {
                    if (txtUsername.Text != "praksa" && txtUsername.Text != "studenti")
                    {
                        if (txtNewPassword.Text != "")
                        {
                            if (txtNewPassword.Text == txtConfirmPassword.Text)
                            {
                                sql.Connection();
                                bool updatePass = sql.PasswordUpdate(txtUsername.Text, txtNewPassword.Text, "prijavljivanje");
                                sql.Close();
                                if (updatePass)
                                {
                                    MessageBox.Show("Uspešno ste promenili lozinku!!!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else MessageBox.Show("Greška pri promeni lozinke!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                changePass("", "", "", "", false);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Greška pri potvrdi lozinke!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNewPassword.Text = "";
                                txtConfirmPassword.Text = "";
                                cbShowPassword.Checked = false;
                            }
                        }
                        else MessageBox.Show("Unesite novu lozinku!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ne možete promeniti lozinku za ovog korisnika!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        changePass("", "", "", "", false);
                    }
                }
                else
                {
                    MessageBox.Show("Unesite ispravnog korisnika i lozinku!!!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changePass("", "", "", "", false);
                }
                sql.Close();
            }
            catch
            {
                MessageBox.Show("Greška pri konekciji! Proverite internet!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtCurrentPassword.UseSystemPasswordChar = false;
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPassword.UseSystemPasswordChar = true;
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            changePass("", "", "", "", false);
        }
    }
}
