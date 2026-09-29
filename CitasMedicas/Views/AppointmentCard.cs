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
    public partial class AppointmentCard : UserControl
    {
        private Cita _cita;

        public AppointmentCard(Cita cita)
        {
            InitializeComponent();
            _cita = cita;

            lblPaciente.Text = cita.NombrePaciente;
            lblMotivo.Text = cita.Motivo;
            this.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Hand; // Cambia el cursor para indicar que es clickeable

            // Asignar el mismo evento click al fondo y a los textos
            this.Click += Tarjeta_Click;
            lblPaciente.Click += Tarjeta_Click;
            lblMotivo.Click += Tarjeta_Click;
        }

        private void Tarjeta_Click(object sender, EventArgs e)
        {
            ManageAppointmentForm frm = new ManageAppointmentForm(_cita);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Refresca el Grid llamando al método público del MainForm
                ((MainForm)this.FindForm()).CargarAgenda();
            }
        }
    }
}
