using ButorraktarKarbantarto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorraktarKarbantarto
{
    public class Raktar
    {
        public List<Butor> Butorok { get; set; }

        public Raktar()
        {
            Butorok = new List<Butor>();
        }

        public void Hozzaad(Butor butor)
        {
            if (!MegnevezesLetezik(butor.Megnevezes))
            {
                Butorok.Add(butor);
            }
        }

        public bool MegnevezesLetezik(string megnevezes)
        {
            foreach (Butor butor in Butorok)
            {
                if (butor.Megnevezes == megnevezes)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
