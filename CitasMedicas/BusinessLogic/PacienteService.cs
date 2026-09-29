using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class PacienteService
    {
        private readonly PacienteRepository _repository = new PacienteRepository();

        public void GuardarPaciente(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Nombre))
                throw new ArgumentException("El nombre del paciente es obligatorio.");

            _repository.RegistrarPaciente(paciente);
        }
    }
}
