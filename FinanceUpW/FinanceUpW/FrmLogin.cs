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


            //////////*************

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
