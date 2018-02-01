using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_04_skaiciuotuvas__mano_susigalvota_
{
    public partial class Form1 : Form
    {
        public List<string> skaiciai = new List<string>();
        //public List<char> veiksmai = new List<char>();

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAtsakymas_Click(object sender, EventArgs e, List<int> skaiciai)
        {
            //textBox1.Text = Convert.ToString(skaiciai[1]);
        }

        private void buttonVienas_Click(object sender, EventArgs e)
        {
            skaiciai.Add("1");
            RodytiVeiksmus();
            //MessageBox.Show(Convert.ToString(skaiciai.Last()));
        }

        private void buttonDu_Click(object sender, EventArgs e)
        {
            skaiciai.Add("2");
            RodytiVeiksmus();
            //MessageBox.Show(Convert.ToString(skaiciai.Last()));
        }

        private void buttonTrys_Click(object sender, EventArgs e)
        {
            skaiciai.Add("3");
            RodytiVeiksmus();
            //MessageBox.Show(Convert.ToString(skaiciai.Last()));
        }

        private void buttonAtsakymas_Click(object sender, EventArgs e)
        {
            RodytiVeiksmus();
            Skaiciuoti();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            skaiciai.Add("+");
            RodytiVeiksmus();
        }

        private void buttonSkirtumas_Click(object sender, EventArgs e)
        {
            skaiciai.Add("-");
            RodytiVeiksmus();
        }

        private void RodytiVeiksmus()
        {
            string SkaiciuTekstas = "";
            foreach (var skaic in skaiciai)
            {
                SkaiciuTekstas += Convert.ToString(skaic) + " ";
            }
            // MessageBox.Show(t);
            textBox1.Text = SkaiciuTekstas;
        }

        private void Skaiciuoti()
        {


            //string skaiciai = textBox1.Text;
            //List<char> skyr = new List<char> { '+', '-', '*', '/' };
            //char[] skaiciuMasyvas = new char[200];
            //skaiciuMasyvas = skaiciai.ToCharArray();
            //MessageBox.Show(Convert.ToString(skaiciuMasyvas[1]));
            var veiksmai = textBox1.Text;
            var skaiciai = veiksmai.Split('+', '-', '*', '/');
            var asIntegers = skaiciai.Select(s => int.Parse(s)).ToArray();
            var zenklai = veiksmai.Split('1', '2', '3', '4','5','6','7','8','9','0');

            int atsakymas = 0;
            int skaiciuIndex = 0;

            switch (zenklai[1])
            {
                case "+":
                    atsakymas = asIntegers[skaiciuIndex] + asIntegers[skaiciuIndex + 1];
                    break;
                case "-":
                    atsakymas = asIntegers[skaiciuIndex] - asIntegers[skaiciuIndex + 1];
                    break;
                case "*":
                    atsakymas = asIntegers[skaiciuIndex] * asIntegers[skaiciuIndex + 1];
                    break;
                case "/":
                    atsakymas = asIntegers[skaiciuIndex] / asIntegers[skaiciuIndex + 1];
                    break;
                default:
                    break;
            }
            skaiciuIndex++;
            for (int i = 2; i < asIntegers.Length; i++)
            {
                switch (zenklai[i])
                {
                    case "+":
                        atsakymas += asIntegers[skaiciuIndex+1];
                        break;
                    case "-":
                        atsakymas -= asIntegers[skaiciuIndex+1];
                        break;
                    case "*":
                        atsakymas *= asIntegers[skaiciuIndex+1];
                        break;
                    case "/":
                        atsakymas /= asIntegers[skaiciuIndex+1];
                        break;
                    default:
                        break;
                }
                skaiciuIndex++;
            }
            textBox1.Text = atsakymas.ToString();
            MessageBox.Show(atsakymas.ToString());
        }

        private void buttonKeturi_Click(object sender, EventArgs e)
        {

        }

        private void buttonPenki_Click(object sender, EventArgs e)
        {

        }

        private void buttonSesi_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeptyni_Click(object sender, EventArgs e)
        {

        }

        private void buttonAstuoni_Click(object sender, EventArgs e)
        {

        }

        private void buttonDevyni_Click(object sender, EventArgs e)
        {

        }
    }
}
