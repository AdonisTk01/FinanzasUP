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
    public partial class FrmGestionUsuarios : Form
    {
        private string connectionString = "Server=DESKTOP-T2EC9OV\\TEW_SQLEXPRESS;Database=FinanceUpDB;Trusted_Connection=True;";

        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }


        private void CargarUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nombre, Usuario, Rol FROM Usuarios", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                CargarUsuarios();
            }
        }


    }
}
