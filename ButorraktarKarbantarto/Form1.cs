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
        Raktar Raktar;
        public ListBox ListBoxRef { get; set; }
        public ListBox TartozekokBox { get; set; }
        public Butor KivalasztottButor { get; set; }

        public Form1()
        {
            Raktar = new Raktar();
          
            InitializeComponent();

            //listBox1.Items = Raktar.Butorok;
            ListBoxRef = butorok;
            TartozekokBox = tartozekok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(Raktar, this);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(Raktar, this);
            form.Show();
        }

        private void ButorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KivalasztottButor = butorok.SelectedItem as Butor;
            tartozekok.DataSource = KivalasztottButor.Tartozekok;
        }
    }
}
