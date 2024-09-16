using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double wynik;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Kalkulator";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void buttonDzi_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            wynik = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            label3.Text = wynik.ToString();
        }

        private void buttonMno_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            wynik = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
            label3.Text = wynik.ToString();
        }

        private void buttonOde_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            wynik = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            label3.Text = wynik.ToString();
        }

        private void buttonDod_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            wynik = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            label3.Text = wynik.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
