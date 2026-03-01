using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DALConexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=localhost,1433;Database=BDVentas;User Id=sa;Password=TestPassword123*;TrustServerCertificate=True");

        public SqlConnection OpenConnection()
        {
            if(Conexion.State == System.Data.ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        public SqlConnection CloseConnection()
        {
            if(Conexion.State == System.Data.ConnectionState.Closed)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
