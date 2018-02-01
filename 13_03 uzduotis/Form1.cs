using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_03_uzduotis
{
    public partial class Form1 : Form
    {
        public List<Telefonas> Telefonai { get; private set; } // galima buvo apsirasyti new List ir cia

        public Form1()
        {
            InitializeComponent();
            Telefonai = new List<Telefonas>(); // arba cia, kaip kam patogiau
        }

        private void baigtiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close(); // uzdaro forma nuspaudus baigti
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkimoLangas = new OpenFileDialog())
            {
                failoPasirinkimoLangas.Filter = "csv failai (*.csv)|*.csv";

                if (failoPasirinkimoLangas.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(failoPasirinkimoLangas.FileName);

                    // nuskaitymas
                    using (var skaitytuvas = new StreamReader(failoPasirinkimoLangas.FileName))
                    {
                        string eilute;
                        var eil = 0;

                        while ((eilute = skaitytuvas.ReadLine()) != null)
                        {
                            if (eil == 0)
                            {
                                eil++;
                                continue;
                            }
                            
                            // MessageBox.Show(eilute);
                            var telefonas = new Telefonas(eilute);
                            Telefonai.Add(telefonas);
                        }
                        dataGridView1.DataSource = Telefonai;
                    }
                }

            }
        }

        private void skaiciavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Skaiciavimai(Telefonai);
            forma.ShowDialog();
        }
    }
}
