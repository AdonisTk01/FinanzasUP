namespace FinanceUpW
{
    partial class FrmIngresos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TipoIngreso = new System.Windows.Forms.Label();
            this.cbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(57, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(78, 139);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(44, 16);
            this.Monto.TabIndex = 2;
            this.Monto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(57, 158);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(288, 16);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(45, 16);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // TipoIngreso
            // 
            this.TipoIngreso.AutoSize = true;
            this.TipoIngreso.Location = new System.Drawing.Point(64, 208);
            this.TipoIngreso.Name = "TipoIngreso";
            this.TipoIngreso.Size = new System.Drawing.Size(102, 16);
            this.TipoIngreso.TabIndex = 6;
            this.TipoIngreso.Text = "Tipo de Ingreso";
            // 
            // cbTipoIngreso
            // 
            this.cbTipoIngreso.FormattingEnabled = true;
            this.cbTipoIngreso.Location = new System.Drawing.Point(57, 227);
            this.cbTipoIngreso.Name = "cbTipoIngreso";
            this.cbTipoIngreso.Size = new System.Drawing.Size(121, 24);
            this.cbTipoIngreso.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(68, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbTipoIngreso);
            this.Controls.Add(this.TipoIngreso);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label Monto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label TipoIngreso;
        private System.Windows.Forms.ComboBox cbTipoIngreso;
        private System.Windows.Forms.Button btnGuardar;
    }
}