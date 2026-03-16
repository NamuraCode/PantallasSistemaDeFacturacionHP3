using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    public class DALEmpleados
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

        public DataTable BuscarEmpleados(string criterio)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_BuscarEmpleados", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Criterio", criterio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable ObtenerEmpleadoPorId(int idEmpleado)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ObtenerEmpleadoPorId", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public void InsertarEmpleado(string nombre, string documento, string direccion,
            string telefono, string email, int idRol,
            DateTime fechaIngreso, DateTime? fechaRetiro, string detalles)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarEmpleado", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre",       nombre);
            cmd.Parameters.AddWithValue("@Documento",    documento);
            cmd.Parameters.AddWithValue("@Direccion",    direccion);
            cmd.Parameters.AddWithValue("@Telefono",     telefono);
            cmd.Parameters.AddWithValue("@Email",        email);
            cmd.Parameters.AddWithValue("@IdRol",        idRol);
            cmd.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
            cmd.Parameters.AddWithValue("@FechaRetiro",  (object?)fechaRetiro ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Detalles",     string.IsNullOrWhiteSpace(detalles) ? DBNull.Value : (object)detalles);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void ActualizarEmpleado(int idEmpleado, string nombre, string documento,
            string direccion, string telefono, string email, int idRol,
            DateTime fechaIngreso, DateTime? fechaRetiro, string detalles)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarEmpleado", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado",   idEmpleado);
            cmd.Parameters.AddWithValue("@Nombre",       nombre);
            cmd.Parameters.AddWithValue("@Documento",    documento);
            cmd.Parameters.AddWithValue("@Direccion",    direccion);
            cmd.Parameters.AddWithValue("@Telefono",     telefono);
            cmd.Parameters.AddWithValue("@Email",        email);
            cmd.Parameters.AddWithValue("@IdRol",        idRol);
            cmd.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
            cmd.Parameters.AddWithValue("@FechaRetiro",  (object?)fechaRetiro ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Detalles",     string.IsNullOrWhiteSpace(detalles) ? DBNull.Value : (object)detalles);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarEmpleado", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public DataTable ListarRoles()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarRoles", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
    }
}
