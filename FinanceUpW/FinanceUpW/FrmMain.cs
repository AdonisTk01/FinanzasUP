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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private string _username;

        // Constructor to accept username
        public FrmMain(string username)
        {
            InitializeComponent();
            _username = username;

            // Display the passed username
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = $"Bienvenido, {_username}!";
            //lblWelcome.Location = new Point(10, 10); // Set position on the form
            lblWelcome.AutoSize = true;

            // Add the label to the form's controls
            this.Controls.Add(lblWelcome);
        }

       

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTiposIngresos_Click(object sender, EventArgs e)
        {
            FrmTiposIngresos formulario = new FrmTiposIngresos();
            formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                FrmTiposEgresos formulario = new FrmTiposEgresos();
                formulario.ShowDialog();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTiposPago formulario = new FrmTiposPago();
            formulario.ShowDialog();
        }

        private void btnRegistroIngreso_Click(object sender, EventArgs e)
        {

            FrmRegistrarIngreso formulario = new FrmRegistrarIngreso();
            formulario.ShowDialog();
        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            
            FrmRegistrarEgreso formulario = new FrmRegistrarEgreso();
            formulario.ShowDialog();
        }
    }   
}
