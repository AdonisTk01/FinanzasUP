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
    public partial class FrmRegistrarEgreso : Form
    {
        public FrmRegistrarEgreso()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEgreso_Load(object sender, EventArgs e)
        {
            // Llenar los ComboBox con los datos globales
            cmbTipoEgreso.DataSource = GlobalData.TiposEgresos.Select(x => x.Nombre).ToList();
            cmbTipoPagoEgreso.DataSource = GlobalData.TiposPago.Select(x => x.Nombre).ToList();

            dtpFechaEgreso.Value = DateTime.Now;
        }

        private void btnGuardarEgreso_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (cmbTipoEgreso.SelectedItem == null || cmbTipoPagoEgreso.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de egreso y un tipo de pago.");
                return;
            }

            string tipoEgreso = cmbTipoEgreso.SelectedItem.ToString();
            string tipoPago = cmbTipoPagoEgreso.SelectedItem.ToString();
            string descripcion = txtDescripcionEgreso.Text.Trim();
            decimal monto = numMontoEgreso.Value;
            DateTime fecha = dtpFechaEgreso.Value;

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor que cero.");
                return;
            }

            // Crear el egreso
            Egreso nuevoEgreso = new Egreso
            {
                TipoEgreso = tipoEgreso,
                TipoPago = tipoPago,
                Descripcion = descripcion,
                Monto = monto,
                Fecha = fecha
            };

            // Guardar en la lista global
            GlobalData.Egresos.Add(nuevoEgreso);

            MessageBox.Show("Egreso registrado correctamente.");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
