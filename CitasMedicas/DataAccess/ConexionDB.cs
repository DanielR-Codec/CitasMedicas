using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    public abstract class ConexionDB
    {
        private readonly string connectionString;

        public ConexionDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CitasDB"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
