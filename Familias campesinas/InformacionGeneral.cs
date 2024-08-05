using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Familias_campesinas
{
    public partial class InformacionGeneral : Form
    {
        public InformacionGeneral()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMunicipio.Text) || string.IsNullOrEmpty(txtSubregion.Text) || string.IsNullOrEmpty(txtVereda.Text) || string.IsNullOrEmpty(txtNombrePredio.Text) || string.IsNullOrEmpty(txtDistanciaPredio.Text))
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ComponenteSocialP1 componenteSocialP1 = new ComponenteSocialP1();
                componenteSocialP1.Show();
                this.Hide();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioDeSesion inicioDeSesion = new InicioDeSesion();
            inicioDeSesion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
