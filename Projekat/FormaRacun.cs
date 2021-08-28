using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FormaRacun : Form
    {
        double cena;
        dsKnjizaraTableAdapters.RacunTableAdapter da = new dsKnjizaraTableAdapters.RacunTableAdapter();
        public FormaRacun()
        {
            InitializeComponent();
        }

        public FormaRacun(double cena) : this()
        {

            this.cena = cena;

        }
        private void btnUpisi_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.UtcNow;
            da.Insert(cena, datum.Date, DateTime.Now.ToShortTimeString());
            MessageBox.Show("Uspesno upisano u bazu!");
        }

        private void FormaRacun_Load(object sender, EventArgs e)
        {
            textBox1.Text = cena.ToString();
        }
    }
}
