using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class MedicoService
    {
        private readonly MedicoRepository _repository = new MedicoRepository();

        public void GuardarMedico(Medico medico, int idEspecialidad)
        {
            if (string.IsNullOrWhiteSpace(medico.Nombre))
                throw new ArgumentException("El nombre del médico es obligatorio.");

            if (idEspecialidad <= 0)
                throw new ArgumentException("Debe seleccionar una especialidad.");

            _repository.RegistrarMedico(medico, idEspecialidad);
        }
    }
}
