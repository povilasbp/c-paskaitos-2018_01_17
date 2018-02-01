using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_05_kontrolinis
{
    public partial class Form1 : Form
    {
        Pasaulis Zeme = new Pasaulis();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Kontrolinio uzduotis 18/02/01, povbuk";
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FailoPasirinkimas = new OpenFileDialog();
            using (FailoPasirinkimas)
            {
                FailoPasirinkimas.Filter = "csv failai (*.csv) | *.csv";
                FailoPasirinkimas.Multiselect = true;

                if (FailoPasirinkimas.ShowDialog() == DialogResult.OK)
                {
                    foreach (var failas in FailoPasirinkimas.FileNames)
                    {
                        Salis SaliesObjektas = new Salis(failas);
                        Zeme.SaliuSarasas.Add(SaliesObjektas);

                        var skirtukas = new TabPage(String.Format("{0} [{1}]", SaliesObjektas.Pavadinimas, SaliesObjektas.Zemynas));
                        tabControl1.Controls.Add(skirtukas);

                        skirtukas.Controls.Add(new DataGridView()
                        {
                            Dock = DockStyle.Fill,
                            DataSource = Zeme.SaliuSarasas.Last().MiestuSarasas
                        });
                    }
                }
            }
            skaiciavimaiToolStripMenuItem.Enabled = true; // leidzia skaiciuoti
        }// using pabaiga

        private void skaiciavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxAtsakymas.Visible = true;
            tabControl1.Dock = DockStyle.Fill;
            groupBoxAtsakymas.Text = "ATSAKYMAI";
            groupBoxAtsakymas.Dock = DockStyle.Bottom;
            string ats1 = Zeme.DaugiausiaiGyventoju().Pavadinimas + " " + Zeme.DaugiausiaiGyventoju().GyventojuSkaicius;
            Salis daugiausiaMiestu = Zeme.DaugiausiaiMiestu();
            string ats2 = daugiausiaMiestu.Pavadinimas + " " + daugiausiaMiestu.MiestuSkaicius();
            labelAtsakymas1.Text = "Daugiausiai gyventoju:";
            labelAtsakymas2.Text = "Daugiausiai miestu:";
            textBoxAtsakymas1.Text = ats1;
            textBoxAtsakymas2.Text = ats2;
            //MessageBox.Show(ats1, "Daugiausiai gyventoju");
            //MessageBox.Show(ats2, "Daugiausiai miestu");
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baigti arTikraiBaigtiLentele = new baigti();
            arTikraiBaigtiLentele.ShowDialog();
        }
    }
}
