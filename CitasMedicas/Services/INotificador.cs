using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public interface INotificador
    {
        void EnviarRecordatorio(string destinatario, string mensaje);
    }
}
