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
    public partial class MainForm : Form
    {
        private Raktar raktar;
        private Butor kivalasztottButor;

        public MainForm()
        {
            raktar = new Raktar();
            
            InitializeComponent();
            butorok.DataSource = raktar.Butorok;
        }

        private void ButorFelvitel_Click(object sender, EventArgs e)
        {
            ButorForm form = new ButorForm(raktar, this);
            form.Show();
        }

        private void TartozekFelvitel_Click(object sender, EventArgs e)
        {
            TartozekForm form = new TartozekForm(kivalasztottButor, this);
            form.Show();
        }

        private void ButorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kivalasztottButor = butorok.SelectedItem as Butor;
            if (kivalasztottButor != null)
            {
                tartozekok.DataSource = kivalasztottButor.Tartozekok;
            }
        }

        public void ButorListaFrissit(Butor butor)
        {
            tartozekok.DataSource = butor.Tartozekok;
        }
    }
}
