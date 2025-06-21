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
    public partial class RegisterForm: Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newUser = txtNewUser.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(newUser) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.");
                return;
            }

            if (LoginForm.RegisteredUsers.ContainsKey(newUser))
            {
                MessageBox.Show("El usuario ya existe.");
                return;
            }

            LoginForm.RegisteredUsers.Add(newUser, newPassword);
            MessageBox.Show("Usuario registrado exitosamente.");
            this.Close();
        }
    }
}
