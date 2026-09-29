using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class EspecialidadRepository : ConexionDB
    {
        public void RegistrarEspecialidad(Especialidad especialidad)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("INSERT INTO Especialidades (Nombre) VALUES (@Nombre)", conexion);
                comando.Parameters.AddWithValue("@Nombre", especialidad.Nombre);
                comando.ExecuteNonQuery();
            }
        }

        public List<Especialidad> ObtenerEspecialidades()
        {
            List<Especialidad> lista = new List<Especialidad>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT IdEspecialidad, Nombre FROM Especialidades", conexion);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Especialidad
                        {
                            IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]),
                            Nombre = reader["Nombre"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}
