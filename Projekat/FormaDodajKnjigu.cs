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
    public partial class FormaDodajKnjigu : Form
    {
        dsKnjizaraTableAdapters.KnjigaTableAdapter da;
        public FormaDodajKnjigu()
        {
            InitializeComponent();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            da = new dsKnjizaraTableAdapters.KnjigaTableAdapter();
            da.Insert(nazivTextBox.Text, autorTextBox.Text, double.Parse(cenaTextBox.Text), int.Parse(popustTextBox.Text), (int)comboBox1.SelectedValue);
            MessageBox.Show("Uspesno upisano u bazu!");
        }

        private void FormaDodajKnjigu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKnjizara.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.dsKnjizara.Kategorija);

        }
    }
}
