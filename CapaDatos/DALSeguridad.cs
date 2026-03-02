using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DALSeguridad
    {
        private DALConexion conexion = new DALConexion();

        public DataTable ListarEmpleados()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarEmpleados", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable ObtenerUsuarioPorEmpleado(int idEmpleado)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarioPorEmpleado", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public void ActualizarSeguridad(int idEmpleado, string usuario, string clave)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarSeguridad", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Clave", clave);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
