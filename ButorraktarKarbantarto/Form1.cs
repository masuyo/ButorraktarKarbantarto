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
    public partial class Form1 : Form
    {
        Raktar Raktar = new Raktar();
        
        public Form1()
        {
            Feloltes();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(Raktar);
            form.Show();
        }

        private void Feloltes()
        {
            foreach (Butor butor in Raktar.Butorok)
            {
                listBox1.Items.Add(butor);
            }
        }
    }
}
