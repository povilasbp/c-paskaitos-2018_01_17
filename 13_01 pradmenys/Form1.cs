using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_01_pradmenys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Labas");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4Skaiciuotuvas_Enter(object sender, EventArgs e)
        {

        }

        private void button1GautiReiksme_Click(object sender, EventArgs e)
        {
            var reiksme = textBox1Reiksme.Text;
            label1Reiksme.Text = reiksme;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1Skaiciuoti_Click(object sender, EventArgs e)
        {
            var suma = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox4.Text);
            textBox5.Text = Convert.ToString(suma);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3NaujasLangas_Enter(object sender, EventArgs e)
        {

        }

        private void button1NaujasLangas_Click(object sender, EventArgs e)
        {
            var forma = new InformacijosLangas();
            forma.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var reiksme = textBoxSiusti.Text;
            var forma = new SkaiciavimuForma(reiksme);
            forma.ShowDialog();
        }

        private void labelIvedimas_Click(object sender, EventArgs e)
        {

        }

        private void buttonIvedimas_Click(object sender, EventArgs e)
        {
            using (var forma = new IvedimoForma())
            {
                forma.ShowDialog();

                if(forma.DialogResult == DialogResult.OK)
                {
                    var zodis = forma.Zodis;
                    labelIvedimas.Text = zodis;
                }
            }
        }
    }
}
