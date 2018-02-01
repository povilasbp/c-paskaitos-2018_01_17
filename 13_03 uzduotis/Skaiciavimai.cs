using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_03_uzduotis
{
    public partial class Skaiciavimai : Form
    {
        public Skaiciavimai(List<Telefonas> Telefonai)
        {
            InitializeComponent();
            textBox1.Text = Seniausias(Telefonai).Metai.ToString();
        }

        public Telefonas Seniausias(List<Telefonas> telefonai)
        {
            var seniausias = telefonai.First();

            foreach (var tel in telefonai)
            {
                if(tel.Metai < seniausias.Metai)
                {
                    seniausias = tel;
                }
            }


            return seniausias;
        }
    }
}
