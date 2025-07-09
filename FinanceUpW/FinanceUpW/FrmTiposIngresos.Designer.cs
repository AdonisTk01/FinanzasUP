namespace FinanceUpW
{
    partial class FrmTiposIngresos
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
            this.dgvTiposIngresos = new System.Windows.Forms.DataGridView();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.txtNombreIngreso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del Ingreso";
            // 
            // dgvTiposIngresos
            // 
            this.dgvTiposIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposIngresos.Location = new System.Drawing.Point(110, 188);
            this.dgvTiposIngresos.Name = "dgvTiposIngresos";
            this.dgvTiposIngresos.RowHeadersWidth = 51;
            this.dgvTiposIngresos.RowTemplate.Height = 24;
            this.dgvTiposIngresos.Size = new System.Drawing.Size(584, 150);
            this.dgvTiposIngresos.TabIndex = 6;
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Location = new System.Drawing.Point(256, 149);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIngreso.TabIndex = 5;
            this.btnAgregarIngreso.Text = "Agregar";
            this.btnAgregarIngreso.UseVisualStyleBackColor = true;
            // 
            // txtNombreIngreso
            // 
            this.txtNombreIngreso.Location = new System.Drawing.Point(110, 149);
            this.txtNombreIngreso.Name = "txtNombreIngreso";
            this.txtNombreIngreso.Size = new System.Drawing.Size(100, 22);
            this.txtNombreIngreso.TabIndex = 4;
            // 
            // FrmTiposIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTiposIngresos);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.txtNombreIngreso);
            this.Name = "FrmTiposIngresos";
            this.Text = "FrmTiposIngresos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTiposIngresos;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.TextBox txtNombreIngreso;
    }
}