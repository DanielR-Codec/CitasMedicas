using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }
    }
}
