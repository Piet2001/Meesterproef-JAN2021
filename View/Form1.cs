using System;
using System.Windows.Forms;
using Logic;
using Logic.Collections;

namespace View
{
    public partial class Form1 : Form
    {
        private PartijCollection _partijCollection = new PartijCollection();
        private VerkiezingCollection _verkiezingCollection = new VerkiezingCollection();

        // huidige selectie voor uitslaginvoer
        private Verkiezing huidigeVerkiezing;
        private Partij Huidigepartij;

        public Form1()
        {
            InitializeComponent();
            Update_Partijen();
            _verkiezingCollection.AddVerkiezing();
            cb_verkiezing.DataSource = _verkiezingCollection.GetAlleVerkiezingen();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string orde = tb_Orde.Text;
            string naam = tb_naam.Text;
            string lijsttrekker = tb_Lijsttrekker.Text;

            if (orde == "" || naam == "" || lijsttrekker == "")
            {
                MessageBox.Show("Vul alle gegevens in!", "Error");
            }
            else
            {
                if (_partijCollection.AddPartij(orde, naam, lijsttrekker))
                {
                    MessageBox.Show("Partij Toegevoegd", "Succes");
                    Update_Partijen();
                    EmmtyInputPartij();
                }
                else
                {
                    MessageBox.Show("Partij kon niet worden toegevoegd", "Error");
                }
            }
        }

        private void Update_Partijen()
        {
            lsb_Partijen.DataSource = null;
            lsb_Partijen.DataSource = _partijCollection.GetAllePartijen();

            cb_partijen.DataSource = null;
            cb_partijen.DataSource = _partijCollection.GetAllePartijen();
        }

        private void EmmtyInputPartij()
        {
            tb_Lijsttrekker.Text = null;
            tb_Orde.Text = null;
            tb_naam.Text = null;
        }

        private void cb_verkiezing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_verkiezing.SelectedItem is Verkiezing)
            {
                huidigeVerkiezing = cb_verkiezing.SelectedItem as Verkiezing;
                nud_zetels.Maximum = huidigeVerkiezing.VrijeZetels;
            }
        }

        private void cb_partijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_partijen.SelectedItem is Partij)
            {
                Huidigepartij = cb_partijen.SelectedItem as Partij;
            }
        }
    }
}
