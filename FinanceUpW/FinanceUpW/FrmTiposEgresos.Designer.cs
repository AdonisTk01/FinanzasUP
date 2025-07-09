namespace FinanceUpW
{
    partial class FrmTiposEgresos
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
            this.txtNombreEgreso = new System.Windows.Forms.TextBox();
            this.btnAgregarEgreso = new System.Windows.Forms.Button();
            this.dgvTiposEgresos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEgreso
            // 
            this.txtNombreEgreso.Location = new System.Drawing.Point(78, 165);
            this.txtNombreEgreso.Name = "txtNombreEgreso";
            this.txtNombreEgreso.Size = new System.Drawing.Size(100, 22);
            this.txtNombreEgreso.TabIndex = 0;
            // 
            // btnAgregarEgreso
            // 
            this.btnAgregarEgreso.Location = new System.Drawing.Point(224, 165);
            this.btnAgregarEgreso.Name = "btnAgregarEgreso";
            this.btnAgregarEgreso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEgreso.TabIndex = 1;
            this.btnAgregarEgreso.Text = "Agregar";
            this.btnAgregarEgreso.UseVisualStyleBackColor = true;
            // 
            // dgvTiposEgresos
            // 
            this.dgvTiposEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposEgresos.Location = new System.Drawing.Point(78, 204);
            this.dgvTiposEgresos.Name = "dgvTiposEgresos";
            this.dgvTiposEgresos.RowHeadersWidth = 51;
            this.dgvTiposEgresos.RowTemplate.Height = 24;
            this.dgvTiposEgresos.Size = new System.Drawing.Size(584, 150);
            this.dgvTiposEgresos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Egreso";
            // 
            // FrmTiposEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTiposEgresos);
            this.Controls.Add(this.btnAgregarEgreso);
            this.Controls.Add(this.txtNombreEgreso);
            this.Name = "FrmTiposEgresos";
            this.Text = "FrmTiposEgresos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEgreso;
        private System.Windows.Forms.Button btnAgregarEgreso;
        private System.Windows.Forms.DataGridView dgvTiposEgresos;
        private System.Windows.Forms.Label label1;
    }
}