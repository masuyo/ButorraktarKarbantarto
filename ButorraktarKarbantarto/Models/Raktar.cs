using ButorraktarKarbantarto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorraktarKarbantarto.Models
{
    public class Raktar
    {
        public BindingList<Butor> Butorok { get; }

        public Raktar()
        {
            Butorok = new BindingList<Butor>();
        }

        public bool Hozzaad(Butor butor)
        {
            if (!MegnevezesLetezik(butor.Megnevezes))
            {
                Butorok.Add(butor);
                return true;
            }
            return false;
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
