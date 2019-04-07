using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorraktarKarbantarto.Models
{
    public class Tartozek
    {
        public TartozekTipusok Tipus { get; }
        public int Ar { get; set; }
        public Anyagfelek Anyaga { get; }

        public Tartozek(TartozekTipusok tipus, int ar, Anyagfelek anyaga)
        {
            Tipus = tipus;
            Ar = ar;
            Anyaga = anyaga;
        }

        public override string ToString()
        {
            string tartozekFormatum = "Tipus: " + Tipus + ", Ar: " + Ar + ", Anyag: " + Anyaga;
            return tartozekFormatum;
        }
    }
}
