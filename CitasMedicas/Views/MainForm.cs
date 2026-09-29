using CitasMedicas.Views;
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
    public partial class MainForm : Form
    {
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private TableLayoutPanel gridAgenda;
        private List<Medico> _medicos;
        private CitaRepository _repository;

        public MainForm()
        {
            InitializeComponent();
            _repository = new CitaRepository();

            btnNuevaCita.Click += BtnNuevaCita_Click;

            ConfigurarGrid();
            CargarAgenda();
        }

        private void ConfigurarGrid()
        {
            _medicos = _repository.ObtenerMedicos();

            gridAgenda = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoScroll = true,
                RowCount = 13, 
                ColumnCount = _medicos.Count + 1 
            };

            gridAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60)); 
            for (int i = 0; i < _medicos.Count; i++)
                gridAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / _medicos.Count));

            gridAgenda.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); 
            for (int i = 1; i < 13; i++)
                gridAgenda.RowStyles.Add(new RowStyle(SizeType.Absolute, 90)); 

            for (int i = 1; i <= 12; i++)
            {
                Label lblHora = new Label { Text = $"{i + 8:00}:00", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill };
                gridAgenda.Controls.Add(lblHora, 0, i);
            }

            for (int i = 0; i < _medicos.Count; i++)
            {
                Label lblMedico = new Label { Text = _medicos[i].Nombre, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 16, FontStyle.Bold), Dock = DockStyle.Fill };
                gridAgenda.Controls.Add(lblMedico, i + 1, 0);
            }

            pnlContenedor.Controls.Add(gridAgenda);
        }

        public void CargarAgenda()
        {
            for (int i = gridAgenda.Controls.Count - 1; i >= 0; i--)
            {
                if (gridAgenda.Controls[i] is AppointmentCard)
                    gridAgenda.Controls.RemoveAt(i);
            }

            List<Cita> citasHoy = _repository.ObtenerCitasDelDia(DateTime.Today);

            foreach (var cita in citasHoy)
            {
                // Calcular posición
                int columna = _medicos.FindIndex(m => m.IdMedico == cita.IdMedico) + 1;
                int fila = cita.FechaHora.Hour - 8; 

                if (columna > 0 && fila > 0 && fila <= 12)
                {
                    AppointmentCard tarjeta = new AppointmentCard(cita);
                    gridAgenda.Controls.Add(tarjeta, columna, fila);
                }
            }
        }

        private void BtnNuevaCita_Click(object sender, EventArgs e)
        {
            AddAppointmentForm frm = new AddAppointmentForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarAgenda();
            }
        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            AddMedicoForm frm = new AddMedicoForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                pnlContenedor.Controls.Clear(); 
                ConfigurarGrid();              
                CargarAgenda();                 
            }
        }

        private void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {
            AddEspecialidadForm frm = new AddEspecialidadForm();
            frm.ShowDialog();
        }

        private void BtnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            AddPacienteForm frm = new AddPacienteForm();
            frm.ShowDialog();
        }
    }
}
