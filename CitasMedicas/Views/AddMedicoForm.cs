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
    public partial class AddMedicoForm : Form
    {
        private readonly MedicoService _medicoService;
        private readonly EspecialidadRepository _especialidadRepo;

        public AddMedicoForm()
        {
            InitializeComponent();
            _medicoService = new MedicoService();
            _especialidadRepo = new EspecialidadRepository();

            CargarEspecialidades();
            btnGuardar.Click += BtnGuardar_Click;
        }

        private void CargarEspecialidades()
        {
            cmbEspecialidad.DataSource = _especialidadRepo.ObtenerEspecialidades();
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "IdEspecialidad";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico nuevoMedico = new Medico { Nombre = txtNombre.Text };
                int idEspecialidadSeleccionada = (int)cmbEspecialidad.SelectedValue;

                _medicoService.GuardarMedico(nuevoMedico, idEspecialidadSeleccionada);
                MessageBox.Show("Médico guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
