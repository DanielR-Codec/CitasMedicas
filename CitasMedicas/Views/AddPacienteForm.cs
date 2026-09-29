using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMedicas.Views
{
    public partial class AddPacienteForm : Form
    {
        private readonly PacienteService _service;

        public AddPacienteForm()
        {
            InitializeComponent();
            _service = new PacienteService();
            btnGuardar.Click += BtnGuardar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente nuevo = new Paciente
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text
                };

                _service.GuardarPaciente(nuevo);
                MessageBox.Show("Paciente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
