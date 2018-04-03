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
    public partial class Print : Form
    {
        MySQL sql;
        Bitmap bmp;
        Dictionary<string, string> slova = new Dictionary<string, string>();
        public Print()
        {
            InitializeComponent();
            sql = new MySQL();
            slova.Add("Љ", "Lj");
            slova.Add("Њ", "Nj");
            slova.Add("Џ", "Dž");
            slova.Add("љ", "lj");
            slova.Add("њ", "nj");
            slova.Add("џ", "dž");
            slova.Add("а", "a");
            slova.Add("б", "b");
            slova.Add("в", "v");
            slova.Add("г", "g");
            slova.Add("д", "d");
            slova.Add("ђ", "đ");
            slova.Add("е", "e");
            slova.Add("ж", "ž");
            slova.Add("з", "z");
            slova.Add("и", "i");
            slova.Add("ј", "j");
            slova.Add("к", "k");
            slova.Add("л", "l");
            slova.Add("м", "m");
            slova.Add("н", "n");
            slova.Add("о", "o");
            slova.Add("п", "p");
            slova.Add("р", "r");
            slova.Add("с", "s");
            slova.Add("т", "t");
            slova.Add("ћ", "ć");
            slova.Add("у", "u");
            slova.Add("ф", "f");
            slova.Add("х", "h");
            slova.Add("ц", "c");
            slova.Add("ч", "č");
            slova.Add("ш", "š");
        }

        public void Members(string membershipCard, string indexNumber, string firstName, string lastName, string datee)
        {
            txtMembershipCard.Text = membershipCard;
            txtIndexNumber.Text = indexNumber;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            date.Text = datee;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height - 270, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Method for latin to cyrillic
        private string Cyrillic(string text)
        {
            string source = text;
            foreach (KeyValuePair<string, string> pair in slova)
            {
                source = source.Replace(pair.Value, pair.Key);
                // For upper case
                source = source.Replace(pair.Value.ToUpper(),
                                        pair.Key.ToUpper());
            }
            return source;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql.Connection();
            string memCard = sql.ReadMembershipCard(txtIndexNumber.Text, "clanovi");
            sql.Close();

            string student = txtFirstName.Text + " " + txtLastName.Text;

            if (txtIndexNumber.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "")
            {

                if (memCard == "")
                {
                    labStudent.Text = Cyrillic(student);
                    labIndex.Text = txtIndexNumber.Text;
                    labDate.Text = Cyrillic(date.Text);
                }
                else
                {
                    sql.Connection();
                    if (!sql.MembersRead(memCard, "zaduzivanje_knjiga"))
                    {
                        labStudent.Text = Cyrillic(student);
                        labIndex.Text = txtIndexNumber.Text;
                        labDate.Text = Cyrillic(date.Text);
                    }
                    else
                    {
                        MessageBox.Show("Član nije vratio sve knjige u biblioteku!!");
                    }
                    sql.Close();
                }
            }
            else
            {
                labStudent.Text = "________________________________________________________";
                labIndex.Text = "_____________________________________";
                labDate.Text = Cyrillic(date.Text);
            }
        }

        private void btnSearchMembershipCard_Click_1(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadMembers(txtMembershipCard.Text, "clanovi", "MembershipCard");
            sql.Close();
            if (result)
            {
                Members(sql.members[0], sql.members[1], sql.members[2], sql.members[3], "");
            }
            else
            {
                Members("", "", "", "", "");
                MessageBox.Show("Članska karta ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchIndexNumber_Click_1(object sender, EventArgs e)
        {
            sql.Connection();
            bool result = sql.ReadMembers(txtIndexNumber.Text, "clanovi", "IndexNumber");
            sql.Close();
            if (result)
            {
                Members(sql.members[0], sql.members[1], sql.members[2], sql.members[3], "");
            }
            else
            {
                MessageBox.Show("Broj indeksa ne postoji!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Members("", "", "", "", "");
        }

        private void Print_FormClosing(object sender, FormClosingEventArgs e)
        {
            Members("", "", "", "", "");
            labStudent.Text = "________________________________________________________";
            labIndex.Text = "_____________________________________";
            labDate.Text = "______________________________________";
        }
    }
}
