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
    public partial class ManageAppointmentForm : Form
    {
        private readonly Cita _cita;
        private readonly CitaService _citaService;

        public ManageAppointmentForm(Cita cita)
        {
            InitializeComponent();
            _cita = cita;
            _citaService = new CitaService(new NotificadorCorreo());

            this.Text = $"Gestionar Cita: {cita.NombrePaciente}";
            dtpNuevaFecha.Value = cita.FechaHora;

            btnReprogramar.Click += BtnReprogramar_Click;
            btnCancelarCita.Click += BtnCancelarCita_Click;
        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Seguro que desea cancelar esta cita?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                _citaService.CancelarCita(_cita.IdCita);
                MessageBox.Show("Cita cancelada.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnReprogramar_Click(object sender, EventArgs e)
        {
            _citaService.ReprogramarCita(_cita.IdCita, dtpNuevaFecha.Value);
            MessageBox.Show("Cita reprogramada.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
