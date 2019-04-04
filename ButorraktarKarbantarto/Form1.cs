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
        public ListBox ListBoxRef;
        
        public Form1()
        {
            Raktar = new Raktar();
          
            InitializeComponent();

            //listBox1.Items = Raktar.Butorok;
            ListBoxRef = listBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(Raktar, this);
            form.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
