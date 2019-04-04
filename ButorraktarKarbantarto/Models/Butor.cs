using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorraktarKarbantarto.Models
{
    public class Butor
    {
        public string Megnevezes { get; }
        public Meret Meret { get; }
        public Anyagfelek Anyaga { get; }
        public Helysegek Elhelyezes { get; }
        public int Darabszam { get; set; }
        public List<Tartozek> Tartozekok { get; }

        public Butor(string megnevezes, Meret meret, Anyagfelek anyaga, Helysegek elhelyezes, int darabszam)
        {
            Megnevezes = megnevezes;
            Meret = meret;
            Anyaga = anyaga;
            Elhelyezes = elhelyezes;
            Darabszam = darabszam;
            Tartozekok = new List<Tartozek>(50);
        }

        public int Ar()
        {
            int ar = Meret.X * Meret.Y * Meret.Z * 100 + TartozekokAra();
            return ar;
        }

        public void Mentes()
        {
            // TODO: csv-be mentés
        }

        private int TartozekokAra()
        {
            int osszesAr = 0;

            foreach (Tartozek tartozek in Tartozekok)
            {
                osszesAr += tartozek.Ar;
            }

            return osszesAr;
        }

    }
}
