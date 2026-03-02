using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DALSeguridad
    {
        private DALConexion conexion = new DALConexion();

        public DataTable ListarUsuariosSistema()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarUsuariosSistema", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public void ActualizarUsuario(int idUsuario, string usuario, string clave)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Clave", clave);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
