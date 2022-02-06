using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*Napište metodu JeAlfanum, která pro zadaný řetězec zjistí, 
             * zda je alfanumerický (obsahuje pouze písmena a číslice), 
             * kolik obsahuje malých písmen,
             * kolik obsahuje velkých písmen 
             * a kolik obsahuje jiných znaků než alfanumerických.
*/
            InitializeComponent();
        }

        public int pocetMalych = 0;
        public int pocetVelkych = 0;
        public int pocetOstatnich = 0;

        public void JeAlfanum(char x)
        {
            if (x >= 'a' && x <= 'z') { pocetMalych++; }
            else if (x >= 'A' && x <= 'Z') { pocetVelkych++; }
            else if (x >= '0' && x <= '9') { }
            else { pocetOstatnich++; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pocetMalych = 0;
            pocetOstatnich = 0;
            pocetVelkych = 0;
            string text = textBox1.Text;
            foreach(char x in text)
            {
                JeAlfanum(x);
            }
            MessageBox.Show("Řetězec " + (pocetOstatnich==0 ? "je" : "není") + " alfanumerický");
            label1.Text = pocetMalych.ToString();
            label2.Text = pocetVelkych.ToString();
            label3.Text = pocetOstatnich.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
