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
    public partial class Form2 : Form
    {
        public Raktar Raktar { get; set; }
        public Anyagfelek Anyag { get; set; }
        public Helysegek Elhelyezes { get; set; }
        public Form2(Raktar raktar)
        {
            Raktar = raktar;
            Anyag = Anyagfelek.Fa;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void hozzaAd_Click(object sender, EventArgs e)
        {
            Meret meret = new Meret(int.Parse(xTxb.Text), int.Parse(yTxb.Text), int.Parse(zTxb.Text));
            Butor butor = new Butor(megnevezesTxb.Text, meret, Anyag, Elhelyezes, int.Parse(darab.Text));
            Raktar.Hozzaad(butor);
        }

        private void Anyag_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Name)
            {
                case "fem":
                    Anyag = Anyagfelek.Fem;
                    break;
                case "fa":
                    Anyag = Anyagfelek.Fa;
                    break;
                case "egyeb":
                    Anyag = Anyagfelek.Egyeb;
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
                    Elhelyezes = Helysegek.Furdo;
                    break;
                case "nappali":
                    Elhelyezes = Helysegek.Nappali;
                    break;
                case "konyha":
                    Elhelyezes = Helysegek.Konyha;
                    break;
                default:
                    break;
            }
        }

    }
}
