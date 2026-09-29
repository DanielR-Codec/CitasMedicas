using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public class CitaRepository : ConexionDB
    {
        public List<Medico> ObtenerMedicos()
        {
            List<Medico> medicos = new List<Medico>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT IdMedico, Nombre FROM Medicos", conexion))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        medicos.Add(new Medico
                        {
                            IdMedico = Convert.ToInt32(reader["IdMedico"]),
                            Nombre = reader["Nombre"].ToString()
                        });
                    }
                }
            }
            return medicos;
        }

        public List<Cita> ObtenerCitasDelDia(DateTime fecha)
        {
            List<Cita> citas = new List<Cita>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = @"SELECT c.IdCita, c.IdMedico, c.IdPaciente, p.Nombre as NombrePaciente, c.FechaHora, c.Motivo 
                         FROM Citas c
                         INNER JOIN Pacientes p ON c.IdPaciente = p.IdPaciente
                         WHERE CAST(c.FechaHora AS DATE) = @Fecha AND c.Estado != 'Cancelada'";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fecha.Date);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            citas.Add(new Cita
                            {
                                IdCita = Convert.ToInt32(reader["IdCita"]),
                                IdMedico = Convert.ToInt32(reader["IdMedico"]),
                                IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                NombrePaciente = reader["NombrePaciente"].ToString(),
                                FechaHora = Convert.ToDateTime(reader["FechaHora"]),
                                Motivo = reader["Motivo"].ToString()
                            });
                        }
                    }
                }
            }
            return citas;
        }

        public void AgregarCita(Cita cita)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Citas (IdMedico, IdPaciente, FechaHora, Motivo, Estado) VALUES (@IdMedico, @IdPaciente, @FechaHora, @Motivo, 'Programada')";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdMedico", cita.IdMedico);
                    comando.Parameters.AddWithValue("@IdPaciente", cita.IdPaciente);
                    comando.Parameters.AddWithValue("@FechaHora", cita.FechaHora);
                    comando.Parameters.AddWithValue("@Motivo", cita.Motivo);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Cita> ConsultarPorPaciente(int idPaciente) 
        {
            List<Cita> citas = new List<Cita>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT * FROM Citas WHERE IdPaciente = @IdPaciente", conexion);
                comando.Parameters.AddWithValue("@IdPaciente", idPaciente);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read()) {  }
                }
            }
            return citas;
        }

        public List<Cita> ConsultarPorMedico(int idMedico) 
        {
            List<Cita> citas = new List<Cita>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT * FROM Citas WHERE IdMedico = @IdMedico", conexion);
                comando.Parameters.AddWithValue("@IdMedico", idMedico);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read()) {  }
                }
            }
            return citas;
        }

        public void CancelarCita(int idCita)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new System.Data.SqlClient.SqlCommand("UPDATE Citas SET Estado = 'Cancelada' WHERE IdCita = @Id", conexion);
                comando.Parameters.AddWithValue("@Id", idCita);
                comando.ExecuteNonQuery();
            }
        }

        public void ReprogramarCita(int idCita, DateTime nuevaFecha)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                var comando = new System.Data.SqlClient.SqlCommand("UPDATE Citas SET FechaHora = @Fecha, Estado = 'Reprogramada' WHERE IdCita = @Id", conexion);
                comando.Parameters.AddWithValue("@Id", idCita);
                comando.Parameters.AddWithValue("@Fecha", nuevaFecha);
                comando.ExecuteNonQuery();
            }
        }
    }
}
