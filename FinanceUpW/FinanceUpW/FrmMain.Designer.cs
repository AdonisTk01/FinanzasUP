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
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbCatalogos = new System.Windows.Forms.GroupBox();
            this.gbMovimientos = new System.Windows.Forms.GroupBox();
            this.gbReportes = new System.Windows.Forms.GroupBox();
            this.btnTiposIngresos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRegistroIngreso = new System.Windows.Forms.Button();
            this.btnRegistrarEgreso = new System.Windows.Forms.Button();
            this.btnVerTransacciones = new System.Windows.Forms.Button();
            this.btnCorteMensual = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.gbCatalogos.SuspendLayout();
            this.gbMovimientos.SuspendLayout();
            this.gbReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(27, 39);
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
            this.gbCatalogos.Location = new System.Drawing.Point(34, 123);
            this.gbCatalogos.Name = "gbCatalogos";
            this.gbCatalogos.Size = new System.Drawing.Size(230, 228);
            this.gbCatalogos.TabIndex = 1;
            this.gbCatalogos.TabStop = false;
            this.gbCatalogos.Text = "Catálogos";
            this.gbCatalogos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbMovimientos
            // 
            this.gbMovimientos.Controls.Add(this.btnVerTransacciones);
            this.gbMovimientos.Controls.Add(this.btnRegistrarEgreso);
            this.gbMovimientos.Controls.Add(this.btnRegistroIngreso);
            this.gbMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimientos.Location = new System.Drawing.Point(279, 123);
            this.gbMovimientos.Name = "gbMovimientos";
            this.gbMovimientos.Size = new System.Drawing.Size(230, 228);
            this.gbMovimientos.TabIndex = 2;
            this.gbMovimientos.TabStop = false;
            this.gbMovimientos.Text = "Movimientos";
            // 
            // gbReportes
            // 
            this.gbReportes.Controls.Add(this.btnReportes);
            this.gbReportes.Controls.Add(this.btnCorteMensual);
            this.gbReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReportes.Location = new System.Drawing.Point(525, 123);
            this.gbReportes.Name = "gbReportes";
            this.gbReportes.Size = new System.Drawing.Size(230, 228);
            this.gbReportes.TabIndex = 3;
            this.gbReportes.TabStop = false;
            this.gbReportes.Text = "Reportes";
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(34, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbReportes);
            this.Controls.Add(this.gbMovimientos);
            this.Controls.Add(this.gbCatalogos);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.gbCatalogos.ResumeLayout(false);
            this.gbMovimientos.ResumeLayout(false);
            this.gbReportes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}