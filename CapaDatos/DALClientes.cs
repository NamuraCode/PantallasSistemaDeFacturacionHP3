using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DALClientes
    {
        private DALConexion conexion = new DALConexion();

        public DataTable ListarClientes()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarClientes", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable BuscarClientes(string criterio)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_BuscarClientes", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Criterio", criterio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable ObtenerClientePorId(int idCliente)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ObtenerClientePorId", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", idCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public void InsertarCliente(string nombre, string documento, string direccion, string correo)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarCliente", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Documento", documento);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void ActualizarCliente(int idCliente, string nombre, string documento, string direccion, string correo)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarCliente", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", idCliente);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Documento", documento);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void EliminarCliente(int idCliente)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarCliente", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", idCliente);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
