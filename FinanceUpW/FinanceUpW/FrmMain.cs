using FinanceUpW.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinanceUpW
{
    public partial class FrmMain : Form
    {
        private string _username;
        private List<Ingreso> ingresos;
        private List<Egreso> egresos;
        private string connectionString = "Server=DESKTOP-T2EC9OV\\TEW_SQLEXPRESS;Database=FinanceUpDB;Trusted_Connection=True;";


        public FrmMain()
        {
            InitializeComponent();
            CargarDashboard();
        }

        // Constructor con usuario
        public FrmMain(string username)
        {
            InitializeComponent();
            _username = username;
            lblWelcome.Text = $"Bienvenido, {_username}!";
            CargarDatosDesdeDB();
            InicializarDashboard();

        }

        private void CargarDashboard()
        {
            try

            {
                using (var connection = FinanceUpW.Data.DbHelper.GetConnection())
                {
                    connection.Open();
                    // Obtener ingresos y egresos del mes actual

                    DateTime inicioMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime finMes = inicioMes.AddMonths(1).AddDays(-1);

            decimal ingresosMes = 0;
            decimal egresosMes = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ingresos del mes
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(Monto), 0) FROM Ingresos WHERE Fecha BETWEEN @inicio AND @fin", conn))
                {
                    cmd.Parameters.AddWithValue("@inicio", inicioMes);
                    cmd.Parameters.AddWithValue("@fin", finMes);
                    ingresosMes = (decimal)cmd.ExecuteScalar();
                }

                // Egresos del mes
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(Monto), 0) FROM Egresos WHERE Fecha BETWEEN @inicio AND @fin", conn))
                {
                    cmd.Parameters.AddWithValue("@inicio", inicioMes);
                    cmd.Parameters.AddWithValue("@fin", finMes);
                    egresosMes = (decimal)cmd.ExecuteScalar();
                }

                // Balance general
                decimal balance = ingresosMes - egresosMes;

                lblIngresosMes.Text = $"Ingresos del mes: {ingresosMes:C}";
                lblEgresosMes.Text = $"Egresos del mes: {egresosMes:C}";
                lblBalance.Text = $"Balance: {balance:C}";

                        // Desglose por tipo de egreso
                        using (SqlCommand cmd = new SqlCommand(
                    @"SELECT te.Nombre, ISNULL(SUM(e.Monto),0) AS Total
                      FROM TiposEgreso te
                      LEFT JOIN Egresos e ON e.TipoEgresoId = te.Id AND e.Fecha BETWEEN @inicio AND @fin
                      GROUP BY te.Nombre", conn))
                {
                    cmd.Parameters.AddWithValue("@inicio", inicioMes);
                    cmd.Parameters.AddWithValue("@fin", finMes);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    chartEgresos.Series.Clear();
                    Series serieEgresos = new Series("Egresos")
                    {
                        ChartType = SeriesChartType.Pie
                    };
                    chartEgresos.Series.Add(serieEgresos);

                    foreach (DataRow row in dt.Rows)
                    {
                        serieEgresos.Points.AddXY(row["Nombre"], row["Total"]);
                    }
                }

                // Evolución últimos 6 meses
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT FORMAT(Fecha, 'yyyy-MM') AS Mes,
                             SUM(Monto) AS Total, 'Ingreso' AS Tipo
                      FROM Ingresos
                      WHERE Fecha >= DATEADD(MONTH, -5, @hoy)
                      GROUP BY FORMAT(Fecha, 'yyyy-MM')
                      UNION ALL
                      SELECT FORMAT(Fecha, 'yyyy-MM') AS Mes,
                             SUM(Monto) * -1 AS Total, 'Egreso' AS Tipo
                      FROM Egresos
                      WHERE Fecha >= DATEADD(MONTH, -5, @hoy)
                      GROUP BY FORMAT(Fecha, 'yyyy-MM')", conn))
                {
                    cmd.Parameters.AddWithValue("@hoy", DateTime.Now);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    var resumen = dt.AsEnumerable()
                        .GroupBy(r => r["Mes"])
                        .Select(g => new
                        {
                            Mes = g.Key.ToString(),
                            Balance = g.Sum(r => Convert.ToDecimal(r["Total"]))
                        })
                        .OrderBy(x => x.Mes);

                    chartEvolucion.Series.Clear();
                    Series serieBalance = new Series("Balance")
                    {
                        ChartType = SeriesChartType.Column
                    };
                    chartEvolucion.Series.Add(serieBalance);

                    foreach (var mes in resumen)
                    {
                        serieBalance.Points.AddXY(mes.Mes, mes.Balance);
                    }
                }
            }

            // Mostrar etiquetas
            lblIngresosMes.Text = $"Ingresos: {ingresosMes:C}";
            lblEgresosMes.Text = $"Egresos: {egresosMes:C}";
            lblBalance.Text = $"Balance: {(ingresosMes - egresosMes):C}";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar dashboard: " + ex.Message);
            }
        }


        private void CargarDatosDesdeDB()
        {
            // TODO: Reemplazar con tu lógica real de lectura desde DB
            // Por ahora, datos de ejemplo
            ingresos = new List<Ingreso>();
            egresos = new List<Egreso>();

            /*ingresos = new List<Ingreso>
            {
                new Ingreso { Fecha = DateTime.Now.AddDays(-10), Monto = 1500, TipoIngreso = "Salario" },
                new Ingreso { Fecha = DateTime.Now.AddDays(-5), Monto = 300, TipoIngreso = "Extra" }
            };

            egresos = new List<Egreso>
            {
                new Egreso { Fecha = DateTime.Now.AddDays(-8), Monto = 200, TipoEgreso = "Supermercado" },
                new Egreso { Fecha = DateTime.Now.AddDays(-3), Monto = 100, TipoEgreso = "Transporte" }
            };*/

            CargarDashboard();
        }

        private void InicializarDashboard()
        {
            // Calcular totales
            decimal totalIngresos = ingresos.Sum(i => i.Monto);
            decimal totalEgresos = egresos.Sum(e => e.Monto);
            decimal balance = totalIngresos - totalEgresos;

            decimal ingresosMes = ingresos.Where(i => i.Fecha.Month == DateTime.Now.Month && i.Fecha.Year == DateTime.Now.Year).Sum(i => i.Monto);
            decimal egresosMes = egresos.Where(e => e.Fecha.Month == DateTime.Now.Month && e.Fecha.Year == DateTime.Now.Year).Sum(e => e.Monto);

            lblBalance.Text = $"Balance Total: {balance:C}";
            lblIngresosMes.Text = $"Ingresos del Mes: {ingresosMes:C}";
            lblEgresosMes.Text = $"Egresos del Mes: {egresosMes:C}";

            // Configurar gráficas
            ConfigurarGraficoEgresos();
            ConfigurarGraficoEvolucion();
        }

        private void ConfigurarGraficoEgresos()
        {
            chartEgresos.Series.Clear();
            chartEgresos.Titles.Clear();
            chartEgresos.Titles.Add("Distribución de Egresos");

            var series = new Series
            {
                Name = "Egresos",
                ChartType = SeriesChartType.Pie
            };

            var egresosPorCategoria = egresos
                .GroupBy(e => e.TipoEgreso)
                .Select(g => new { Categoria = g.Key, Total = g.Sum(e => e.Monto) });

            foreach (var item in egresosPorCategoria)
            {
                series.Points.AddXY(item.Categoria, item.Total);
            }

            chartEgresos.Series.Add(series);
        }

        private void ConfigurarGraficoEvolucion()
        {
            chartEvolucion.Series.Clear();
            chartEvolucion.Titles.Clear();
            chartEvolucion.Titles.Add("Evolución Mensual");

            var serieIngresos = new Series("Ingresos") { ChartType = SeriesChartType.Column };
            var serieEgresos = new Series("Egresos") { ChartType = SeriesChartType.Column };

            var meses = Enumerable.Range(1, 12);

            foreach (var mes in meses)
            {
                decimal totalIngresosMes = ingresos.Where(i => i.Fecha.Month == mes).Sum(i => i.Monto);
                decimal totalEgresosMes = egresos.Where(e => e.Fecha.Month == mes).Sum(e => e.Monto);

                serieIngresos.Points.AddXY(mes, totalIngresosMes);
                serieEgresos.Points.AddXY(mes, totalEgresosMes);
            }

            chartEvolucion.Series.Add(serieIngresos);
            chartEvolucion.Series.Add(serieEgresos);
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frm = new FrmGestionUsuarios();
            frm.ShowDialog();
        }
    }
}   
