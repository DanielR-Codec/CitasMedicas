using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class MedicoRepository : ConexionDB
    {
        public void RegistrarMedico(Medico medico, int idEspecialidad)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("INSERT INTO Medicos (Nombre, IdEspecialidad) VALUES (@Nombre, @IdEspecialidad)", conexion);
                comando.Parameters.AddWithValue("@Nombre", medico.Nombre);
                comando.Parameters.AddWithValue("@IdEspecialidad", idEspecialidad);
                comando.ExecuteNonQuery();
            }
        }
    }
}
