using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_02_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Skaiciuoti_Click(object sender, EventArgs e)
        {
            var A = Convert.ToDouble(textBoxA.Text);
            var B = Convert.ToDouble(textBoxB.Text);
            var C = Convert.ToDouble(textBoxC.Text);
            var pusperimetris = (A + B + C) / 2;
            var plotas = Math.Sqrt(pusperimetris * (pusperimetris - A) * pusperimetris*(pusperimetris - B) * pusperimetris * (pusperimetris - C));
            plotas = Math.Round(plotas, 2);
            textBoxAtsakymas.Text = Convert.ToString(plotas);
        }
    }
}
