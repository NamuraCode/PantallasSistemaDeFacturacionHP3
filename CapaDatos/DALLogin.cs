using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DALLogin
    {
        private DALConexion conexion = new DALConexion();

        public DataTable ValidarLogin(string usuario, string clave)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ValidarLogin", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Clave", clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
    }
}
