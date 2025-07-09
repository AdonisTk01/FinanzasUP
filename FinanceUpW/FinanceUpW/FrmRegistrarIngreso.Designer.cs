namespace FinanceUpW
{
    partial class FrmRegistrarIngreso
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
            this.btnGuardarIngreso = new System.Windows.Forms.Button();
            this.numMontoIngreso = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcionIngreso = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.cmbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarIngreso
            // 
            this.btnGuardarIngreso.Location = new System.Drawing.Point(88, 257);
            this.btnGuardarIngreso.Name = "btnGuardarIngreso";
            this.btnGuardarIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarIngreso.TabIndex = 21;
            this.btnGuardarIngreso.Text = "Guardar Ingreso";
            this.btnGuardarIngreso.UseVisualStyleBackColor = true;
            // 
            // numMontoIngreso
            // 
            this.numMontoIngreso.Location = new System.Drawing.Point(187, 151);
            this.numMontoIngreso.Name = "numMontoIngreso";
            this.numMontoIngreso.Size = new System.Drawing.Size(120, 22);
            this.numMontoIngreso.TabIndex = 20;
            // 
            // txtDescripcionIngreso
            // 
            this.txtDescripcionIngreso.Location = new System.Drawing.Point(187, 114);
            this.txtDescripcionIngreso.Name = "txtDescripcionIngreso";
            this.txtDescripcionIngreso.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionIngreso.TabIndex = 19;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(187, 79);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoPago.TabIndex = 18;
            // 
            // cmbTipoIngreso
            // 
            this.cmbTipoIngreso.FormattingEnabled = true;
            this.cmbTipoIngreso.Location = new System.Drawing.Point(187, 41);
            this.cmbTipoIngreso.Name = "cmbTipoIngreso";
            this.cmbTipoIngreso.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoIngreso.TabIndex = 17;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(130, 196);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaIngreso.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de Ingreso";
            // 
            // FrmRegistrarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarIngreso);
            this.Controls.Add(this.numMontoIngreso);
            this.Controls.Add(this.txtDescripcionIngreso);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.cmbTipoIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarIngreso";
            this.Text = "FrmRegistrarIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.numMontoIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarIngreso;
        private System.Windows.Forms.NumericUpDown numMontoIngreso;
        private System.Windows.Forms.TextBox txtDescripcionIngreso;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.ComboBox cmbTipoIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}