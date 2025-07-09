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
    public partial class FrmRegistrarIngreso : Form
    {
        public FrmRegistrarIngreso()
        {
            InitializeComponent();
        }

        private void FrmRegistrarIngreso_Load(object sender, EventArgs e)
        {
            // Llenar los ComboBox con los datos globales
            cmbTipoIngreso.DataSource = GlobalData.TiposIngresos.Select(x => x.Nombre).ToList();
            cmbTipoPago.DataSource = GlobalData.TiposPago.Select(x => x.Nombre).ToList();

            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            // Validar que los combos no estén vacíos
            if (cmbTipoIngreso.SelectedItem == null || cmbTipoPago.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de ingreso y un tipo de pago.");
                return;
            }

            string tipoIngreso = cmbTipoIngreso.SelectedItem.ToString();
            string tipoPago = cmbTipoPago.SelectedItem.ToString();
            string descripcion = txtDescripcionIngreso.Text.Trim();
            decimal monto = numMontoIngreso.Value;
            DateTime fecha = dtpFechaIngreso.Value;

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor que cero.");
                return;
            }

            // Crear el ingreso
            Ingreso nuevoIngreso = new Ingreso
            {
                TipoIngreso = tipoIngreso,
                TipoPago = tipoPago,
                Descripcion = descripcion,
                Monto = monto,
                Fecha = fecha
            };

            // Guardar en la lista global
            GlobalData.Ingresos.Add(nuevoIngreso);

            MessageBox.Show("Ingreso registrado correctamente.");
            this.Close();
        }
    }
}
