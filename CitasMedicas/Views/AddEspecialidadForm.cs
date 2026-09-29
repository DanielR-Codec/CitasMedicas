using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMedicas
{
    public partial class AddEspecialidadForm : Form
    {
        private readonly EspecialidadService _service;

        public AddEspecialidadForm()
        {
            InitializeComponent();
            _service = new EspecialidadService();
            btnGuardar.Click += BtnGuardar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad nuevaEspecialidad = new Especialidad { Nombre = txtNombre.Text };
                _service.GuardarEspecialidad(nuevaEspecialidad);
                MessageBox.Show("Especialidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
