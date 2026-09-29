namespace CitasMedicas
{
    partial class ManageAppointmentForm
    {
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
            this.dtpNuevaFecha = new System.Windows.Forms.DateTimePicker();
            this.btnReprogramar = new System.Windows.Forms.Button();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(315, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reprogramar Cita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNuevaFecha
            // 
            this.dtpNuevaFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNuevaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNuevaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNuevaFecha.Location = new System.Drawing.Point(15, 104);
            this.dtpNuevaFecha.Name = "dtpNuevaFecha";
            this.dtpNuevaFecha.Size = new System.Drawing.Size(288, 29);
            this.dtpNuevaFecha.TabIndex = 7;
            // 
            // btnReprogramar
            // 
            this.btnReprogramar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReprogramar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprogramar.Location = new System.Drawing.Point(133, 184);
            this.btnReprogramar.Name = "btnReprogramar";
            this.btnReprogramar.Size = new System.Drawing.Size(170, 44);
            this.btnReprogramar.TabIndex = 10;
            this.btnReprogramar.Text = "Reprogramar";
            this.btnReprogramar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarCita.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCita.Location = new System.Drawing.Point(12, 184);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(115, 44);
            this.btnCancelarCita.TabIndex = 11;
            this.btnCancelarCita.Text = "Cancelar";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // ManageAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 278);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.btnReprogramar);
            this.Controls.Add(this.dtpNuevaFecha);
            this.Controls.Add(this.label1);
            this.Name = "ManageAppointmentForm";
            this.Text = "ManageAppointmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNuevaFecha;
        private System.Windows.Forms.Button btnReprogramar;
        private System.Windows.Forms.Button btnCancelarCita;
    }
}