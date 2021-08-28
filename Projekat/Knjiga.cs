using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    class Knjiga
    {
        int id_knjige;
        string naziv;
        string autor;
        double cena;
        int popust;
        int id_kat;
        int kolicina;
        public Knjiga(int id_knjige, string naziv, string autor, double cena, int popust, int id)
        {
            this.id_knjige = id_knjige;
            this.naziv = naziv;
            this.autor = autor;
            this.cena = cena;
            this.popust = popust;
            this.id_kat = id;


        }

        public int Id_knjige { get => id_knjige; set => id_knjige = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
        public double Cena { get => cena; set => cena = value; }
        public int Popust { get => popust; set => popust = value; }
        public int Id_kat { get => id_kat; set => id_kat = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }

        public override string ToString()
        {
            return id_knjige + "-" + naziv + "-" + autor + "-" + cena + "-" + popust;
        }
    }
}
