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
    public partial class PrintStatistics : Form
    {
        Bitmap bmp;
        MySQL sql;
        Config config;
        public PrintStatistics()
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
            column.Width = 70;
            column = dataGridView1.Columns[1];
            column.Width = 200;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height - 80, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void PrintStatistics_Load(object sender, EventArgs e)
        {
            string query = "select statistika.UDKBroj, knjige.Naslov, knjige.GodinaIzdanja, autori.ImePrezime as Autor, izdavaci.Naziv as Izdavač, kategorije.Naziv as PredmetnaOdrednica, statistika.BrojIznajmljivanja from statistika inner join knjige on statistika.UDKBroj = knjige.UDKBroj inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra ORDER BY statistika.BrojIznajmljivanja desc";
            SearchBooks(query);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
