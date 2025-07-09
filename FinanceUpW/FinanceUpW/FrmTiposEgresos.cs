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
    public partial class FrmTiposEgresos : Form
    {
    
            public FrmTiposEgresos()
            {
                InitializeComponent();
            }

            private void FrmTiposEgresos_Load(object sender, EventArgs e)
            {
                CargarDatos();
            }

            private void CargarDatos()
            {
                dgvTiposEgresos.DataSource = null;
                dgvTiposEgresos.DataSource = GlobalData.TiposEgresos.ToList();
            }

            private void btnAgregarEgreso_Click(object sender, EventArgs e)
            {
                string nombre = txtNombreEgreso.Text.Trim();

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Por favor ingresa un nombre.");
                    return;
                }

                // Validar si ya existe ese tipo
                bool yaExiste = GlobalData.TiposEgresos.Any(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
                if (yaExiste)
                {
                    MessageBox.Show("Este tipo de egreso ya existe.");
                    return;
                }

                GlobalData.TiposEgresos.Add(new TipoEgreso { Nombre = nombre });
                CargarDatos();
                txtNombreEgreso.Clear();
            }
        
    }
}
