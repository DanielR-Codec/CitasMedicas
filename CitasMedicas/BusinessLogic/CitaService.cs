using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicas;

namespace CitasMedicas
{
    public class CitaService
    {
        private readonly CitaRepository _repository;
        private readonly PacienteRepository _pacienteRepository;
        private readonly INotificador _notificador;

        public CitaService(INotificador notificador)
        {
            _repository = new CitaRepository();
            _pacienteRepository = new PacienteRepository();
            _notificador = notificador;
        }

        public void AgendarCita(Cita cita)
        {
            if (cita.IdPaciente <= 0) throw new ArgumentException("Debe seleccionar un paciente.");
            if (cita.FechaHora < DateTime.Now) throw new ArgumentException("No se puede agendar en el pasado.");

            _repository.AgregarCita(cita);

            string correoReal = _pacienteRepository.ObtenerCorreoPaciente(cita.IdPaciente);

            if (!string.IsNullOrWhiteSpace(correoReal))
            {
                _notificador.EnviarRecordatorio(correoReal, "Su cita ha sido confirmada.");
            }
        }

        public void CancelarCita(int idCita)
        {
            _repository.CancelarCita(idCita);
        }

        public void ReprogramarCita(int idCita, DateTime nuevaFecha)
        {
            if (nuevaFecha < DateTime.Now)
                throw new ArgumentException("No se puede reprogramar en el pasado.");

            _repository.ReprogramarCita(idCita, nuevaFecha);
        }
    }
}
