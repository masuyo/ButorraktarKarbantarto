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
    public partial class Form3 : Form
    {
        public Raktar Raktar { get; set; }
        public Form1 Form1 { get; set; }
        private TartozekTipusok tipus = TartozekTipusok.DekorElem;
        private Anyagfelek anyag = Anyagfelek.Fa;
        public Form3(Raktar raktar, Form1 form1)
        {
            Raktar = raktar;
            Form1 = form1;
            InitializeComponent();
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            Tartozek tartozek = new Tartozek(tipus, Convert.ToInt16(ar.Value), anyag);
            Form1.KivalasztottButor.TartozekHozzaad(tartozek);
            Form1.TartozekokBox.Items.Add(tartozek);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}