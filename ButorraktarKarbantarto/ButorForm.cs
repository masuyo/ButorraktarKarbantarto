using ButorraktarKarbantarto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButorraktarKarbantarto
{
    public partial class ButorForm : Form
    {
        private Raktar _raktar;
        private Anyagfelek anyag = Anyagfelek.Fa;
        private Helysegek elhelyezes;
        private MainForm _main;

        public ButorForm(Raktar raktar, MainForm main)
        {
            _raktar = raktar;
            _main = main;
            InitializeComponent();
        }

        private void hozzaAd_Click(object sender, EventArgs e)
        {
            Meret meret = new Meret(int.Parse(xTxb.Text), int.Parse(yTxb.Text), int.Parse(zTxb.Text));
            Butor butor = new Butor(megnevezesTxb.Text, meret, anyag, elhelyezes, Convert.ToInt16(darab.Value));

            if (_raktar.Hozzaad(butor))
            {
                _main.ButorListaFrissit(butor);
            }
            
        }

        private void Anyag_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Name)
            {
                case "fem":
                    anyag = Anyagfelek.Fem;
                    break;
                case "fa":
                    anyag = Anyagfelek.Fa;
                    break;
                case "egyeb":
                    anyag = Anyagfelek.Egyeb;
                    break;
                default:
                    break;
            }
        }

        private void Elhelyezes_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Name)
            {
                case "furdo":
                    elhelyezes = Helysegek.Furdo;
                    break;
                case "nappali":
                    elhelyezes = Helysegek.Nappali;
                    break;
                case "konyha":
                    elhelyezes = Helysegek.Konyha;
                    break;
                default:
                    break;
            }
        }

        private void Megse_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
