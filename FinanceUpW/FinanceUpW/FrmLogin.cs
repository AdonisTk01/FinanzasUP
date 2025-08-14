using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceUpW
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static Dictionary<string, string> RegisteredUsers = new Dictionary<string, string>
{
    { "admin", "admin" },
    { "user", "user" }
};


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String username = txtUser.Text;
            String password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }


            // Here you would typically check the credentials against a database or other storage
            string connectionString = "Server=DESKTOP-T2EC9OV\\TEW_SQLEXPRESS;Database=FinanceUpDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre, Rol FROM Usuarios WHERE Usuario=@Usuario AND Password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Guardar info del usuario logeado
                            int userId = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string rol = reader.GetString(2);

                            MessageBox.Show($"Bienvenido {nombre}");

                            // Abrir MainForm y pasar datos del usuario
                            FrmMain mainForm = new FrmMain(username);
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                }
            }
            //////////*************
/*
            if (RegisteredUsers.ContainsKey(username) && RegisteredUsers[username] == password)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                FrmMain mainForm = new FrmMain(username);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Aquí puedes abrir un nuevo formulario de registro
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }

}
