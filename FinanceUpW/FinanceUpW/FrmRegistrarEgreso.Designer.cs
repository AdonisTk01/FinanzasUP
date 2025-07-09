namespace FinanceUpW
{
    partial class FrmRegistrarEgreso
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoEgreso = new System.Windows.Forms.ComboBox();
            this.cmbTipoPagoEgreso = new System.Windows.Forms.ComboBox();
            this.txtDescripcionEgreso = new System.Windows.Forms.TextBox();
            this.numMontoEgreso = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarEgreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoEgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Ingreso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Location = new System.Drawing.Point(110, 187);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEgreso.TabIndex = 5;
            // 
            // cmbTipoEgreso
            // 
            this.cmbTipoEgreso.FormattingEnabled = true;
            this.cmbTipoEgreso.Location = new System.Drawing.Point(167, 32);
            this.cmbTipoEgreso.Name = "cmbTipoEgreso";
            this.cmbTipoEgreso.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoEgreso.TabIndex = 6;
            // 
            // cmbTipoPagoEgreso
            // 
            this.cmbTipoPagoEgreso.FormattingEnabled = true;
            this.cmbTipoPagoEgreso.Location = new System.Drawing.Point(167, 70);
            this.cmbTipoPagoEgreso.Name = "cmbTipoPagoEgreso";
            this.cmbTipoPagoEgreso.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoPagoEgreso.TabIndex = 7;
            // 
            // txtDescripcionEgreso
            // 
            this.txtDescripcionEgreso.Location = new System.Drawing.Point(167, 105);
            this.txtDescripcionEgreso.Name = "txtDescripcionEgreso";
            this.txtDescripcionEgreso.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionEgreso.TabIndex = 8;
            // 
            // numMontoEgreso
            // 
            this.numMontoEgreso.Location = new System.Drawing.Point(167, 142);
            this.numMontoEgreso.Name = "numMontoEgreso";
            this.numMontoEgreso.Size = new System.Drawing.Size(120, 22);
            this.numMontoEgreso.TabIndex = 9;
            // 
            // btnGuardarEgreso
            // 
            this.btnGuardarEgreso.Location = new System.Drawing.Point(68, 248);
            this.btnGuardarEgreso.Name = "btnGuardarEgreso";
            this.btnGuardarEgreso.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEgreso.TabIndex = 10;
            this.btnGuardarEgreso.Text = "Guardar Ingreso";
            this.btnGuardarEgreso.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrarEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarEgreso);
            this.Controls.Add(this.numMontoEgreso);
            this.Controls.Add(this.txtDescripcionEgreso);
            this.Controls.Add(this.cmbTipoPagoEgreso);
            this.Controls.Add(this.cmbTipoEgreso);
            this.Controls.Add(this.dtpFechaEgreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarEgreso";
            this.Text = "FrmRegistrarEgreso";
            ((System.ComponentModel.ISupportInitialize)(this.numMontoEgreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private System.Windows.Forms.ComboBox cmbTipoEgreso;
        private System.Windows.Forms.ComboBox cmbTipoPagoEgreso;
        private System.Windows.Forms.TextBox txtDescripcionEgreso;
        private System.Windows.Forms.NumericUpDown numMontoEgreso;
        private System.Windows.Forms.Button btnGuardarEgreso;
    }
}