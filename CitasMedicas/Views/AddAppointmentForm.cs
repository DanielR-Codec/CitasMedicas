using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitasMedicas;

namespace CitasMedicas
{
    public partial class AddAppointmentForm : Form
    {
        private readonly CitaService _citaService;
        private readonly CitaRepository _citaRepository;
        private readonly PacienteRepository _pacienteRepo;

        public AddAppointmentForm()
        {
            InitializeComponent(); 
            _citaService = new CitaService(new NotificadorCorreo());
            _citaRepository = new CitaRepository();
            _pacienteRepo = new PacienteRepository();

            CargarMedicos();
            CargarPacientes();

            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => this.Close();
        }

        private void CargarMedicos()
        {
            cmbMedico.DataSource = _citaRepository.ObtenerMedicos();
            cmbMedico.DisplayMember = "Nombre";
            cmbMedico.ValueMember = "IdMedico";
        }

        private void CargarPacientes()
        {
            cmbPaciente.DataSource = _pacienteRepo.ObtenerPacientes();
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "IdPaciente";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cita nuevaCita = new Cita
                {
                    IdMedico = (int)cmbMedico.SelectedValue,
                    IdPaciente = (int)cmbPaciente.SelectedValue,
                    FechaHora = dtpFecha.Value,
                    Motivo = txtMotivo.Text
                };

                _citaService.AgendarCita(nuevaCita);
                MessageBox.Show("Cita agendada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}