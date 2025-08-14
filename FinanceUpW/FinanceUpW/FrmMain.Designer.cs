using System;


namespace FinanceUpW
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbCatalogos = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTiposIngresos = new System.Windows.Forms.Button();
            this.gbMovimientos = new System.Windows.Forms.GroupBox();
            this.btnVerTransacciones = new System.Windows.Forms.Button();
            this.btnRegistrarEgreso = new System.Windows.Forms.Button();
            this.btnRegistroIngreso = new System.Windows.Forms.Button();
            this.gbReportes = new System.Windows.Forms.GroupBox();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCorteMensual = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIngresosMes = new System.Windows.Forms.Label();
            this.lblEgresosMes = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.chartEgresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEvolucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbCatalogos.SuspendLayout();
            this.gbMovimientos.SuspendLayout();
            this.gbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(390, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(186, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // gbCatalogos
            // 
            this.gbCatalogos.Controls.Add(this.button3);
            this.gbCatalogos.Controls.Add(this.button2);
            this.gbCatalogos.Controls.Add(this.button1);
            this.gbCatalogos.Controls.Add(this.btnTiposIngresos);
            this.gbCatalogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCatalogos.Location = new System.Drawing.Point(81, 448);
            this.gbCatalogos.Name = "gbCatalogos";
            this.gbCatalogos.Size = new System.Drawing.Size(230, 228);
            this.gbCatalogos.TabIndex = 1;
            this.gbCatalogos.TabStop = false;
            this.gbCatalogos.Text = "Catálogos";
            this.gbCatalogos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button3.Location = new System.Drawing.Point(17, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Usuarios\t";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button2.Location = new System.Drawing.Point(17, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tipos de Pago\t";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.Location = new System.Drawing.Point(17, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tipos de Egreso\t";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTiposIngresos
            // 
            this.btnTiposIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnTiposIngresos.Location = new System.Drawing.Point(17, 31);
            this.btnTiposIngresos.Name = "btnTiposIngresos";
            this.btnTiposIngresos.Size = new System.Drawing.Size(162, 31);
            this.btnTiposIngresos.TabIndex = 0;
            this.btnTiposIngresos.Text = "Tipos de Ingreso\t";
            this.btnTiposIngresos.UseVisualStyleBackColor = true;
            this.btnTiposIngresos.Click += new System.EventHandler(this.btnTiposIngresos_Click);
            // 
            // gbMovimientos
            // 
            this.gbMovimientos.Controls.Add(this.btnVerTransacciones);
            this.gbMovimientos.Controls.Add(this.btnRegistrarEgreso);
            this.gbMovimientos.Controls.Add(this.btnRegistroIngreso);
            this.gbMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimientos.Location = new System.Drawing.Point(381, 448);
            this.gbMovimientos.Name = "gbMovimientos";
            this.gbMovimientos.Size = new System.Drawing.Size(230, 228);
            this.gbMovimientos.TabIndex = 2;
            this.gbMovimientos.TabStop = false;
            this.gbMovimientos.Text = "Movimientos";
            // 
            // btnVerTransacciones
            // 
            this.btnVerTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnVerTransacciones.Location = new System.Drawing.Point(33, 105);
            this.btnVerTransacciones.Name = "btnVerTransacciones";
            this.btnVerTransacciones.Size = new System.Drawing.Size(162, 31);
            this.btnVerTransacciones.TabIndex = 6;
            this.btnVerTransacciones.Text = "Ver Transacciones";
            this.btnVerTransacciones.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEgreso
            // 
            this.btnRegistrarEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnRegistrarEgreso.Location = new System.Drawing.Point(33, 68);
            this.btnRegistrarEgreso.Name = "btnRegistrarEgreso";
            this.btnRegistrarEgreso.Size = new System.Drawing.Size(162, 31);
            this.btnRegistrarEgreso.TabIndex = 5;
            this.btnRegistrarEgreso.Text = "Registrar Egreso\t";
            this.btnRegistrarEgreso.UseVisualStyleBackColor = true;
            this.btnRegistrarEgreso.Click += new System.EventHandler(this.btnRegistrarEgreso_Click);
            // 
            // btnRegistroIngreso
            // 
            this.btnRegistroIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnRegistroIngreso.Location = new System.Drawing.Point(33, 31);
            this.btnRegistroIngreso.Name = "btnRegistroIngreso";
            this.btnRegistroIngreso.Size = new System.Drawing.Size(162, 31);
            this.btnRegistroIngreso.TabIndex = 4;
            this.btnRegistroIngreso.Text = "Registrar Ingreso\t";
            this.btnRegistroIngreso.UseVisualStyleBackColor = true;
            this.btnRegistroIngreso.Click += new System.EventHandler(this.btnRegistroIngreso_Click);
            // 
            // gbReportes
            // 
            this.gbReportes.Controls.Add(this.btnGestionUsuarios);
            this.gbReportes.Controls.Add(this.btnReportes);
            this.gbReportes.Controls.Add(this.btnCorteMensual);
            this.gbReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReportes.Location = new System.Drawing.Point(687, 448);
            this.gbReportes.Name = "gbReportes";
            this.gbReportes.Size = new System.Drawing.Size(230, 228);
            this.gbReportes.TabIndex = 3;
            this.gbReportes.TabStop = false;
            this.gbReportes.Text = "Reportes";
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnGestionUsuarios.Location = new System.Drawing.Point(34, 105);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(162, 31);
            this.btnGestionUsuarios.TabIndex = 9;
            this.btnGestionUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnReportes.Location = new System.Drawing.Point(34, 68);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(162, 31);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCorteMensual
            // 
            this.btnCorteMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnCorteMensual.Location = new System.Drawing.Point(34, 31);
            this.btnCorteMensual.Name = "btnCorteMensual";
            this.btnCorteMensual.Size = new System.Drawing.Size(162, 31);
            this.btnCorteMensual.TabIndex = 7;
            this.btnCorteMensual.Text = "Corte Mensual";
            this.btnCorteMensual.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(982, 635);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblIngresosMes
            // 
            this.lblIngresosMes.AutoSize = true;
            this.lblIngresosMes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIngresosMes.Location = new System.Drawing.Point(48, 66);
            this.lblIngresosMes.Name = "lblIngresosMes";
            this.lblIngresosMes.Size = new System.Drawing.Size(203, 28);
            this.lblIngresosMes.TabIndex = 0;
            this.lblIngresosMes.Text = "Ingresos del mes: 0.00";
            // 
            // lblEgresosMes
            // 
            this.lblEgresosMes.AutoSize = true;
            this.lblEgresosMes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEgresosMes.Location = new System.Drawing.Point(358, 66);
            this.lblEgresosMes.Name = "lblEgresosMes";
            this.lblEgresosMes.Size = new System.Drawing.Size(197, 28);
            this.lblEgresosMes.TabIndex = 1;
            this.lblEgresosMes.Text = "Egresos del mes: 0.00";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(651, 66);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(138, 28);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance: 0.00";
            // 
            // chartEgresos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEgresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEgresos.Legends.Add(legend1);
            this.chartEgresos.Location = new System.Drawing.Point(20, 120);
            this.chartEgresos.Name = "chartEgresos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEgresos.Series.Add(series1);
            this.chartEgresos.Size = new System.Drawing.Size(400, 300);
            this.chartEgresos.TabIndex = 3;
            this.chartEgresos.Text = "Egresos";
            // 
            // chartEvolucion
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEvolucion.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEvolucion.Legends.Add(legend2);
            this.chartEvolucion.Location = new System.Drawing.Point(450, 120);
            this.chartEvolucion.Name = "chartEvolucion";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartEvolucion.Series.Add(series2);
            this.chartEvolucion.Size = new System.Drawing.Size(500, 300);
            this.chartEvolucion.TabIndex = 4;
            this.chartEvolucion.Text = "Evolución";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 681);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbReportes);
            this.Controls.Add(this.gbMovimientos);
            this.Controls.Add(this.gbCatalogos);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblIngresosMes);
            this.Controls.Add(this.lblEgresosMes);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.chartEgresos);
            this.Controls.Add(this.chartEvolucion);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.gbCatalogos.ResumeLayout(false);
            this.gbMovimientos.ResumeLayout(false);
            this.gbReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRegistroIngreso_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnTiposIngresos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gbCatalogos;
        private System.Windows.Forms.GroupBox gbMovimientos;
        private System.Windows.Forms.GroupBox gbReportes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTiposIngresos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistroIngreso;
        private System.Windows.Forms.Button btnVerTransacciones;
        private System.Windows.Forms.Button btnRegistrarEgreso;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCorteMensual;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblIngresosMes;
        private System.Windows.Forms.Label lblEgresosMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEgresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvolucion;
        private System.Windows.Forms.Button btnGestionUsuarios;
    }
}