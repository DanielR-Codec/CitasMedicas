using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class EspecialidadService
    {
        private readonly EspecialidadRepository _repository = new EspecialidadRepository();

        public void GuardarEspecialidad(Especialidad especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.Nombre))
                throw new ArgumentException("El nombre de la especialidad es obligatorio.");

            _repository.RegistrarEspecialidad(especialidad);
        }
    }
}
