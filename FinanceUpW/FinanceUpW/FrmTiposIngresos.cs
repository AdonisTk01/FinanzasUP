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
    public partial class FrmTiposIngresos : Form
    {
        public FrmTiposIngresos()
        {
            InitializeComponent();
        }

        private void FrmTiposIngresos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvTiposIngresos.DataSource = null;
            dgvTiposIngresos.DataSource = GlobalData.TiposIngresos.ToList();
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreIngreso.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingresa un nombre.");
                return;
            }

            // Verificar que no exista
            bool yaExiste = GlobalData.TiposIngresos.Any(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (yaExiste)
            {
                MessageBox.Show("Este tipo de ingreso ya existe.");
                return;
            }

            GlobalData.TiposIngresos.Add(new TipoIngreso { Nombre = nombre });
            CargarDatos();
            txtNombreIngreso.Clear();
        }
    }
}
