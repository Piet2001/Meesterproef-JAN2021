using System;
using System.Linq;
using System.Windows.Forms;
using Logic;
using Logic.Collections;

namespace View
{
    public partial class CoalitieVormer : Form
    {
        #region Init
        private PartijCollection _partijCollection = new PartijCollection();
        private VerkiezingCollection _verkiezingCollection = new VerkiezingCollection();

        // huidige selectie voor uitslaginvoer
        private Verkiezing _huidigeVerkiezing;
        private Partij _huidigepartij;
        private Uitslagregel _huidigeUitslagregel;

        public CoalitieVormer()
        {
            InitializeComponent();
            Update_Partijen();
            _verkiezingCollection.VerkiezingAanmaken("Test Verkiezing", new DateTime(2021, 01, 19), 150);
            cb_verkiezing.DataSource = _verkiezingCollection.GetAlleVerkiezingen();
        }

        #endregion

        #region Buttons
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
                if (!_partijCollection.PartijToevoegen(orde, naam, lijsttrekker))
                {
                    if (_partijCollection.GetAllePartijen().Any(x => x.Orde == orde))
                    {
                        _partijCollection.UpdatePartij(orde, naam, lijsttrekker);
                    }
                    else
                    {
                        MessageBox.Show("Partij kon niet worden toegevoegd", "Error");
                    }
                }
                Update_Partijen();
                EmmtyInputPartij();
            }
        }

        private void bt_saveUitslag_Click(object sender, EventArgs e)
        {
            int stemmen = (int)nud_stemmen.Value;
            double percentage = (double)nud_percentage.Value;
            int zetels = (int)nud_zetels.Value;

            bool updated = _huidigeVerkiezing.AddUitslagregel(_huidigepartij, stemmen, percentage, zetels);

            if (!updated)
            {
                if (_huidigeVerkiezing.GetUitslagregels().Any(x => x.Partij.Orde == _huidigepartij.Orde))
                {
                    DialogResult result = MessageBox.Show($"Weet U zeker dat u de uitslag van {_huidigepartij.Orde} wilt aanpassen",
                        "waarschuwing", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _huidigeUitslagregel.Update(stemmen, percentage, zetels);
                    }
                }
                else
                {
                    MessageBox.Show("Uitslag is niet geaccepteerd", "Error");
                }
            }
            Update_Verkiezing();
            EmmtyInputVerkiezing();
        }

        private void bt_add_coalitie_Click(object sender, EventArgs e)
        {
            if (_huidigeVerkiezing.SelecteerRegel(_huidigeUitslagregel))
            {
                Update_Coalitie();
            }
        }

        private void bt_save_coalitie_Click(object sender, EventArgs e)
        {
            if (_huidigeVerkiezing.MaakCoalitie())
            {
                Coalitie coalitie = _huidigeVerkiezing.GetCoalitie();
                MessageBox.Show(coalitie.ToString());
            }
            else
            {
                MessageBox.Show("Coalitie voldoet niet aan de regels", "Error");
            }
        }

        #endregion

        #region ComboBoxes
        private void cb_verkiezing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_verkiezing.SelectedItem is Verkiezing)
            {
                _huidigeVerkiezing = cb_verkiezing.SelectedItem as Verkiezing;
                Update_Verkiezing();
            }
        }

        private void cb_partijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_partijen.SelectedItem is Partij)
            {
                _huidigepartij = cb_partijen.SelectedItem as Partij;
            }
        }

        private void cb_Uitslagregels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Uitslagregels.SelectedItem is Uitslagregel)
            {
                _huidigeUitslagregel = cb_Uitslagregels.SelectedItem as Uitslagregel;
            }

        }

        #endregion

        #region Updates
        private void Update_Partijen()
        {
            lsb_Partijen.DataSource = null;
            lsb_Partijen.DataSource = _partijCollection.GetAllePartijen();

            cb_partijen.DataSource = null;
            cb_partijen.DataSource = _partijCollection.GetAllePartijen();
        }

        private void EmmtyInputVerkiezing()
        {
            nud_stemmen.Value = 0;
            nud_percentage.Value = 0.00m;
            nud_zetels.Value = 0;
        }

        private void Update_Verkiezing()
        {
            lsb_uitslagen.DataSource = null;
            lsb_uitslagen.DataSource = _huidigeVerkiezing.GetUitslagregels();

            nud_zetels.Maximum = _huidigeVerkiezing.VrijeZetels;
            lb_maxZetels.Text = $"(max: {_huidigeVerkiezing.VrijeZetels})";

            cb_Uitslagregels.DataSource = null;
            cb_Uitslagregels.DataSource = _huidigeVerkiezing.GetUitslagregels();
        }

        private void EmmtyInputPartij()
        {
            tb_Lijsttrekker.Text = null;
            tb_Orde.Text = null;
            tb_naam.Text = null;
        }
        private void Update_Coalitie()
        {
            lsb_Coalitie.DataSource = null;
            lsb_Coalitie.DataSource = _huidigeVerkiezing.GetGeselecteerdeUitslagregels();
            bt_save_coalitie.Enabled = _huidigeVerkiezing.MinimaleAantalZetelsBehaald();
        }

        #endregion

        private void lsb_Partijen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var partij = lsb_Partijen.SelectedItem as Partij;
            tb_Orde.Text = partij.Orde;
            tb_naam.Text = partij.Naam;
            tb_Lijsttrekker.Text = partij.Lijsttrekker;
        }

        private void lsb_Coalitie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var Uitslagregel = lsb_Coalitie.SelectedItem as Uitslagregel;
            _huidigeVerkiezing.RemoveGeselecteerdUitslagregel(Uitslagregel);
            Update_Coalitie();
        }
    }
}
