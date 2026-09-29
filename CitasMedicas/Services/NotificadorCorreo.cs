using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class NotificadorCorreo : INotificador
    {
        public void EnviarRecordatorio(string destinatario, string mensaje)
        {
            Console.WriteLine($"Correo enviado a {destinatario}: {mensaje}");
        }
    }
}
