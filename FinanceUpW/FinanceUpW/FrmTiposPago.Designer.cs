namespace FinanceUpW
{
    partial class FrmTiposPago
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
            this.dgvTiposPago = new System.Windows.Forms.DataGridView();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.txtNombrePago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposPago)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del Tipo de Pago";
            // 
            // dgvTiposPago
            // 
            this.dgvTiposPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposPago.Location = new System.Drawing.Point(110, 188);
            this.dgvTiposPago.Name = "dgvTiposPago";
            this.dgvTiposPago.RowHeadersWidth = 51;
            this.dgvTiposPago.RowTemplate.Height = 24;
            this.dgvTiposPago.Size = new System.Drawing.Size(584, 150);
            this.dgvTiposPago.TabIndex = 10;
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Location = new System.Drawing.Point(256, 149);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPago.TabIndex = 9;
            this.btnAgregarPago.Text = "Agregar";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            // 
            // txtNombrePago
            // 
            this.txtNombrePago.Location = new System.Drawing.Point(110, 149);
            this.txtNombrePago.Name = "txtNombrePago";
            this.txtNombrePago.Size = new System.Drawing.Size(100, 22);
            this.txtNombrePago.TabIndex = 8;
            // 
            // FrmTiposPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTiposPago);
            this.Controls.Add(this.btnAgregarPago);
            this.Controls.Add(this.txtNombrePago);
            this.Name = "FrmTiposPago";
            this.Text = "FrmTiposPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTiposPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.TextBox txtNombrePago;
    }
}