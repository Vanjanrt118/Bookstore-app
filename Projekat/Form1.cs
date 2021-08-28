using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
 
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        List<Knjiga> knjige;
        double cena = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKnjizara.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.dsKnjizara.Racun);
            // TODO: This line of code loads data into the 'dsKnjizara.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.dsKnjizara.Kategorija);
       


        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            knjige = new List<Knjiga>();
            try
            {

                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vanja\OneDrive\Radna površina\TVP\Knjizara.accdb");
                OleDbCommand cmd = new OleDbCommand("select * from knjiga", conn);
                OleDbParameter p = new OleDbParameter();
                conn.Open();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id_knjiga = (int)rd["id_knjiga"];
                    string naziv = ((string)rd["naziv"]);
                    string autor = ((string)rd["autor"]);
                    double cena = (double)rd["cena"];
                    int popust = (int)rd["popust"];
                    int id_kategorija = (int)rd["id_kategorija"];
                    Knjiga k = new Knjiga(id_knjiga, naziv, autor, cena, popust, id_kategorija);
                    knjige.Add(k);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

            var q = knjige.Where(x => x.Id_kat == (int)comboBox1.SelectedValue).OrderBy(x => x.Autor).ToList();
            if (q.Count == 0) MessageBox.Show("Nijedna knjiga ne pripada ovoj kategoriji!");
            else listBox1.DataSource = q;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Knjiga k = listBox1.SelectedItem as Knjiga;
            if (k == null) MessageBox.Show("Morate izabrati neku knjigu!");
            else if (txtKolicina.Text.Length == 0) MessageBox.Show("Morate uneti kolicinu koju zelite da dodate!");
            else
            {
                listBox2.Items.Add(k);
                k.Kolicina = int.Parse(txtKolicina.Text);
                if (k.Popust != 0)
                {
                    cena += (k.Cena * k.Kolicina * (100 - k.Popust) / 100);
                }
                else { cena += (k.Cena * k.Kolicina); }
                txtUkupno.Text = cena.ToString();
            }
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            Knjiga k = listBox2.SelectedItem as Knjiga;
            if (k == null) MessageBox.Show("Morate izabrati knjigu koju zelite da izbacite!");
            else
            {
                if (k.Popust != 0)
                {
                    cena -= (k.Cena * k.Kolicina * (100 - k.Popust) / 100);

                }
                else
                {
                    cena -= (k.Cena * k.Kolicina);
                }
                listBox2.Items.Remove(k);
                txtUkupno.Text = cena.ToString();
            }
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            if (txtUkupno.Text.Length == 0 || cena == 0) MessageBox.Show("Vasa korpa je prazna!");
            else
            {
                FormaRacun r = new FormaRacun(cena);
                r.Show();
            }
        }

        private void btnNovaKnjiga_Click(object sender, EventArgs e)
        {

            FormaDodajKnjigu f = new FormaDodajKnjigu();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Knjiga> q;
            if (radioButton1.Checked == true)
            {
                q = knjige.Where(x => x.Autor == txtPretraga.Text).ToList();
                if (q.Count == 0) MessageBox.Show("Ne postoji knjiga sa takvim autorom!");

            }
            else
            {
                q = knjige.Where(x => x.Naziv == txtPretraga.Text).ToList();
                if (q.Count == 0) MessageBox.Show("Ne postoji knjiga sa takvim nazivom!");
            }

            listBox1.DataSource = q;
        }

        private void btnPrikazi2_Click(object sender, EventArgs e)
        {
         

            List<string> q = dsKnjizara.Racun.Where(x => x.datum >= dateTimePicker1.Value.Date && x.datum <= dateTimePicker2.Value.Date).Select(x => "Id: " + x.ID_racun + " " + "Cena: " + x.cena + " " + "Datum: " + x.datum.ToShortDateString() + " " + "Vreme: " + x.vreme).ToList();
            if (q.Count == 0) MessageBox.Show("Ne postoji  racun koji odgovara unesenim parametrima");
            listBox3.DataSource = q;

        }
    }
}
