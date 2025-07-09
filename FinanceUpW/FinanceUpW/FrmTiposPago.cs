using FinanceUpW.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceUpW
{
    public partial class FrmTiposPago : Form
    {
        public FrmTiposPago()
        {
            InitializeComponent();
        }

        private void FrmTiposPago_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvTiposPago.DataSource = null;
            dgvTiposPago.DataSource = GlobalData.TiposPago.ToList();
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePago.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingresa un nombre.");
                return;
            }

            bool yaExiste = GlobalData.TiposPago.Any(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (yaExiste)
            {
                MessageBox.Show("Este tipo de pago ya existe.");
                return;
            }

            GlobalData.TiposPago.Add(new TipoPago { Nombre = nombre });
            CargarDatos();
            txtNombrePago.Clear();
        }
    }
}
