using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Collections;

namespace View
{
    public partial class Form1 : Form
    {
        private PartijCollection _partijCollection = new PartijCollection();
        public Form1()
        {
            InitializeComponent();
            Update_LSB_Partijen();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string orde =tb_Orde.Text;
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
                    Update_LSB_Partijen();
                    EmmtyInputPartij();
                }
                else
                {
                    MessageBox.Show("Partij kon niet worden toegevoegd", "Error");
                }
            }
        }

        private void Update_LSB_Partijen()
        {
            lsb_Partijen.DataSource = null;
            lsb_Partijen.DataSource = _partijCollection.GetAllePartijen();
        }

        private void EmmtyInputPartij()
        {
            tb_Lijsttrekker.Text = null;
            tb_Orde.Text = null;
            tb_naam.Text = null;
        }
    }
}
