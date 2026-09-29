namespace CitasMedicas
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnNuevaCita);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaCita.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.Location = new System.Drawing.Point(1114, 3);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(119, 57);
            this.btnNuevaCita.TabIndex = 1;
            this.btnNuevaCita.Text = "Nueva Cita";
            this.btnNuevaCita.UseVisualStyleBackColor = false;
            this.btnNuevaCita.Click += new System.EventHandler(this.BtnNuevaCita_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 63);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1236, 594);
            this.pnlContenedor.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(86, 63);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacienteToolStripMenuItem,
            this.registrarMedicoToolStripMenuItem,
            this.registrarEspecialidadToolStripMenuItem});
            this.registroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // registrarPacienteToolStripMenuItem
            // 
            this.registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            this.registrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.registrarPacienteToolStripMenuItem.Text = "Registrar Paciente";
            this.registrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.BtnRegistrarPaciente_Click);
            // 
            // registrarMedicoToolStripMenuItem
            // 
            this.registrarMedicoToolStripMenuItem.Name = "registrarMedicoToolStripMenuItem";
            this.registrarMedicoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.registrarMedicoToolStripMenuItem.Text = "Registrar Medico";
            this.registrarMedicoToolStripMenuItem.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // registrarEspecialidadToolStripMenuItem
            // 
            this.registrarEspecialidadToolStripMenuItem.Name = "registrarEspecialidadToolStripMenuItem";
            this.registrarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.registrarEspecialidadToolStripMenuItem.Text = "Registrar Especialidad";
            this.registrarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.btnRegistrarEspecialidad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 657);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEspecialidadToolStripMenuItem;
    }
}