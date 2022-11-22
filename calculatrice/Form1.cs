using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        private object textBox_resultat;

        public Form1()
        {
            InitializeComponent();
        }
        string operateur;
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  "5";
        }

        private void un_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void deux_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  "2";
        }

        private void trois_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  "3";
        }

        private void quatre_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  "4";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  "6";
        }

        private void sept_Click(object sender, EventArgs e)
        {
            textBox1.Text +=   "7";
        }

        private void huit_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void neuf_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("+");
            operateur = "+";
        }

        private void moins_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            operateur = "-";
        }

        private void divi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "÷";
            operateur = "÷";
        }

        private void suppremer_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (operateur == "+")
            {
                string[] chaine = textBox1.Text.Split('+');
                textBox1.Text+= Environment.NewLine +"="+ Environment.NewLine +(double.Parse(chaine[0]) + double.Parse(chaine[1]));
            }
            if (operateur == "-")
            {
                string[] chaine = textBox1.Text.Split('-');
                textBox1.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) - double.Parse(chaine[1]));
            }
            if (operateur == "÷")
            {
                string[] chaine = textBox1.Text.Split('÷');
                textBox1.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) / double.Parse(chaine[1]));
            }

            if (operateur == "˟")
            {
                string[] chaine = textBox1.Text.Split('˟');
                textBox1.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) * double.Parse(chaine[1]));
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void xcarre_Click(object sender, EventArgs e)
        {
           
        }

        private void multiplucation_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("˟");
            operateur = "˟";
        }
    }
}
