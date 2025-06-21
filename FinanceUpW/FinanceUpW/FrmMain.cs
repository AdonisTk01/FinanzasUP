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

            // configure the label
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = $"Welcome, {_username}!";
            //lblWelcome.Location = new Point(10, 10); // Set position on the form
            lblWelcome.AutoSize = true;

            // Add the label to the form's controls
            this.Controls.Add(lblWelcome);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Use the passed username (e.g., display it)
            lblWelcome.Text = $"Welcome, {_username}!";
        }

       
    }

}
