using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class PacienteRepository : ConexionDB
    {
        public void RegistrarPaciente(Paciente paciente)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("INSERT INTO Pacientes (Nombre, Telefono, Correo) VALUES (@Nombre, @Telefono, @Correo)", conexion);
                comando.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                comando.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                comando.Parameters.AddWithValue("@Correo", paciente.Correo);
                comando.ExecuteNonQuery();
            }
        }

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> lista = new List<Paciente>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT IdPaciente, Nombre FROM Pacientes", conexion);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Paciente
                        {
                            IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                            Nombre = reader["Nombre"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}
