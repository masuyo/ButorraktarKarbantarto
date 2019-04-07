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
    public partial class TartozekForm : Form
    {
        private MainForm _main;
        private Butor _butor;
        private TartozekTipusok tipus = TartozekTipusok.TartoElem;
        private Anyagfelek anyag = Anyagfelek.Fa;

        public TartozekForm(Butor butor, MainForm main)
        {
            _main = main;
            _butor = butor;
            InitializeComponent();
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            Tartozek tartozek = new Tartozek(tipus, Convert.ToInt16(ar.Value), anyag);
            _butor.TartozekHozzaad(tartozek);
        }

        private void TartozekTipusValaszto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Name)
            {
                case "tartoelem":
                    tipus = TartozekTipusok.TartoElem;
                    break;
                case "extraelem":
                    tipus = TartozekTipusok.ExtraElem;
                    break;
                case "dekorelem":
                    tipus = TartozekTipusok.DekorElem;
                    break;
                default:
                    break;
            }
        }

        private void AnyagValaszto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Name)
            {
                case "fa":
                    anyag = Anyagfelek.Fa;
                    break;
                case "fem":
                    anyag = Anyagfelek.Fem;
                    break;
                case "egyeb":
                    anyag = Anyagfelek.Egyeb;
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