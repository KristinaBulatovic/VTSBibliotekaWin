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
    public partial class BorrowingBooks : Form
    {
        MySQL sql;
        public BorrowingBooks()
        {
            InitializeComponent();
            sql = new MySQL();
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

        public bool changeState(string udk, string table)
        {
            try
            {
                sql.Connection();
                string state = sql.ReadState(udk, table);
                sql.Close();
                if (state != "")
                {
                    int s = Convert.ToInt32(state);
                    s--;
                    if (s >= 0)
                    {
                        string newState = s.ToString();
                        sql.Connection();
                        sql.UpdateBookState(udk, newState, table);
                        sql.Close();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else return false;
            }
            catch
            {
                return false;
            }
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            Members("", "", "", "", "", "", "");
        }

        private void BorrowingBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Members("", "", "", "", "", "", "");
            txtUdk.Text = "";
            dateBorrowing.Text = "";
            dateReturn.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql.Connection();
            bool membersRead = sql.MembersRead(txtMembershipCard.Text, "clanovi");
            sql.Close();
            if (membersRead)
            {
                if (sql.BookRead(txtUdk.Text, "knjige"))
                {
                    if (changeState(txtUdk.Text, "knjige"))
                    {
                        sql.Connection();
                        bool result = sql.InsertBorrowingBooks(txtMembershipCard.Text, txtUdk.Text, dateBorrowing.Text, dateReturn.Text, "zaduzivanje_knjiga");
                        sql.Close();
                        if (result)
                        {
                            sql.Statistic(txtUdk.Text, "statistika");
                            MessageBox.Show("Uspešno ste zadužili knjigu!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUdk.Text = "";
                            dateBorrowing.Text = "";
                            dateReturn.Text = "";
                        }
                        else MessageBox.Show("Greška pri zaduživanju!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtUdk.Text = "";
                        MessageBox.Show("Knjiga se trenutno ne nalazi na stanju!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtUdk.Text = "";
                    MessageBox.Show("Knjiga ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                sql.Connection();
                bool result = sql.InsertMembers(txtMembershipCard.Text, txtIndexNumber.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, "clanovi");
                sql.Close();
                if (result)
                {
                    if (sql.BookRead(txtUdk.Text, "knjige"))
                    {
                        if (changeState(txtUdk.Text, "knjige"))
                        {
                            sql.Connection();
                            bool r = sql.InsertBorrowingBooks(txtMembershipCard.Text, txtUdk.Text, dateBorrowing.Text, dateReturn.Text, "zaduzivanje_knjiga");
                            sql.Close();
                            if (r)
                            {
                                sql.Statistic(txtUdk.Text, "statistika");
                                MessageBox.Show("Uspešno ste zadužili knjigu!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUdk.Text = "";
                                dateBorrowing.Text = "";
                                dateReturn.Text = "";
                            }
                            else MessageBox.Show("Greška pri zaduživanju!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            txtUdk.Text = "";
                            MessageBox.Show("Knjiga se trenutno ne nalazi na stanju!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        txtUdk.Text = "";
                        MessageBox.Show("Knjiga ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Members("", "", "", "", "", "", "");
                    MessageBox.Show("Greška pri unosu člana", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMembershipCard_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtUdk.Text != "")
            {
                btnSave.Enabled = true;
            }
            else btnSave.Enabled = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtUdk.Text != "")
            {
                btnSave.Enabled = true;
            }
            else btnSave.Enabled = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtUdk.Text != "")
            {
                btnSave.Enabled = true;
            }
            else btnSave.Enabled = false;
        }

        private void txtUdk_TextChanged(object sender, EventArgs e)
        {
            if (txtMembershipCard.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtUdk.Text != "")
            {
                btnSave.Enabled = true;
            }
            else btnSave.Enabled = false;
        }
    }
}
