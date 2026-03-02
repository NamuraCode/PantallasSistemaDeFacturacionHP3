using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DALProductos
    {
        private DALConexion conexion = new DALConexion();

        public DataTable ListarProductos()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarProductos", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable BuscarProductos(string criterio)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_BuscarProductos", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Criterio", criterio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public DataTable ObtenerProductoPorId(int idProducto)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ObtenerProductoPorId", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", idProducto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public void InsertarProducto(string codigo, string nombreProducto, decimal precioCompra, decimal precioVenta, int stock, string rutaImagen, string detalles, int idCategoria)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarProducto", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto);
            cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@RutaImagen", rutaImagen);
            cmd.Parameters.AddWithValue("@Detalles", detalles);
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void ActualizarProducto(int idProducto, string codigo, string nombreProducto, decimal precioCompra, decimal precioVenta, int stock, string rutaImagen, string detalles, int idCategoria)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarProducto", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", idProducto);
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto);
            cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@RutaImagen", rutaImagen);
            cmd.Parameters.AddWithValue("@Detalles", detalles);
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public void EliminarProducto(int idProducto)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarProducto", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", idProducto);
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }

        public DataTable ListarCategorias()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarCategorias", conexion.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
    }
}
