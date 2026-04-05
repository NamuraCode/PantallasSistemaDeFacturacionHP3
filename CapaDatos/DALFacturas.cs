using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    public class DALFacturas
    {
        private DALConexion conexion = new DALConexion();

        public string GenerarNumeroFactura()
        {
            SqlCommand cmd = new SqlCommand("sp_GenerarNumeroFactura", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            object? result = cmd.ExecuteScalar();
            conexion.CloseConnection();
            return result?.ToString() ?? "FAC-0001";
        }

        public DataTable ListarFacturas()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarFacturas", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable BuscarFacturas(string criterio)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_BuscarFacturas", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Criterio", criterio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable ObtenerFacturaPorId(int idFactura)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ObtenerFacturaPorId", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public int InsertarFactura(string numeroFactura, int idCliente, int idEmpleado,
            DateTime fechaFactura, decimal descuento, decimal subtotal, decimal iva,
            decimal total, string estado)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarFactura", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumeroFactura", numeroFactura);
            cmd.Parameters.AddWithValue("@IdCliente",     idCliente);
            cmd.Parameters.AddWithValue("@IdEmpleado",    idEmpleado);
            cmd.Parameters.AddWithValue("@FechaFactura",  fechaFactura);
            cmd.Parameters.AddWithValue("@Descuento",     descuento);
            cmd.Parameters.AddWithValue("@Subtotal",      subtotal);
            cmd.Parameters.AddWithValue("@IVA",           iva);
            cmd.Parameters.AddWithValue("@Total",         total);
            cmd.Parameters.AddWithValue("@Estado",        estado);
            object? result = cmd.ExecuteScalar();
            conexion.CloseConnection();
            return Convert.ToInt32(result);
        }

        public void ActualizarFactura(int idFactura, int idCliente, int idEmpleado,
            DateTime fechaFactura, decimal descuento, decimal subtotal, decimal iva,
            decimal total, string estado)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarFactura", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura",    idFactura);
            cmd.Parameters.AddWithValue("@IdCliente",    idCliente);
            cmd.Parameters.AddWithValue("@IdEmpleado",   idEmpleado);
            cmd.Parameters.AddWithValue("@FechaFactura", fechaFactura);
            cmd.Parameters.AddWithValue("@Descuento",    descuento);
            cmd.Parameters.AddWithValue("@Subtotal",     subtotal);
            cmd.Parameters.AddWithValue("@IVA",          iva);
            cmd.Parameters.AddWithValue("@Total",        total);
            cmd.Parameters.AddWithValue("@Estado",       estado);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void EliminarFactura(int idFactura)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarFactura", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public DataTable ListarDetallesFactura(int idFactura)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarDetallesFactura", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public void InsertarDetalleFactura(int idFactura, int idProducto, int cantidad,
            decimal precioUnitario, decimal subtotal)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarDetalleFactura", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura",      idFactura);
            cmd.Parameters.AddWithValue("@IdProducto",     idProducto);
            cmd.Parameters.AddWithValue("@Cantidad",       cantidad);
            cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
            cmd.Parameters.AddWithValue("@Subtotal",       subtotal);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void EliminarDetallesFactura(int idFactura)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarDetallesFactura", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
