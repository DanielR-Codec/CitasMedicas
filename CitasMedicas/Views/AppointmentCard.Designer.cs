namespace CitasMedicas
{
    partial class AppointmentCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPaciente.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(5, 5);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(3);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Padding = new System.Windows.Forms.Padding(5);
            this.lblPaciente.Size = new System.Drawing.Size(92, 34);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Nombre";
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMotivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.Color.DimGray;
            this.lblMotivo.Location = new System.Drawing.Point(5, 39);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(3);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Padding = new System.Windows.Forms.Padding(5);
            this.lblMotivo.Size = new System.Drawing.Size(78, 32);
            this.lblMotivo.TabIndex = 1;
            this.lblMotivo.Text = "Motivo";
            // 
            // AppointmentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lblPaciente);
            this.Name = "AppointmentCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(150, 80);
            this.Click += new System.EventHandler(this.Tarjeta_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblMotivo;
    }
}
