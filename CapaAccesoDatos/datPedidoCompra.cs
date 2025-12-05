using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datPedidoCompra
    {
        #region singleton
        private static readonly datPedidoCompra _instancia = new datPedidoCompra();
        public static datPedidoCompra Instancia { get { return _instancia; } }
        #endregion

        // -----------------------------------------------------
        // MÉTODOS DE ACCIÓN (APROBAR y ANULAR) - Implementación Faltante
        // -----------------------------------------------------

        // Resuelve CS1061 para AprobarPedido
        public void AprobarPedido(int pedidoID)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAprobarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PedidoCompraID", pedidoID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al ejecutar AprobarPedido en la Capa de Datos: " + e.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
        }
        public List<entPedidoCompra> ListarPedidosAprobados()
        {
            SqlCommand cmd = null;
            List<entPedidoCompra> lista = new List<entPedidoCompra>();
            SqlConnection cn = null; // Asumo que se declara fuera del try

            try
            {
                cn = Conexion.Instancia.Conectar();
                // Llama al SP que filtra por Estado = 'Aprobado' (spListarPedidosAprobados)
                cmd = new SqlCommand("spListarPedidosAprobados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Mapeamos solo los campos necesarios para la selección en el formulario de registro
                    lista.Add(new entPedidoCompra
                    {
                        PedidoCompraID = Convert.ToInt32(dr["PedcompraID"]),
                        NroPedido = dr["NroPedido"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        NombreProveedor = dr["NombreProveedor"].ToString(),
                        Estado = "Aprobado"
                        // Se asume que las columnas PedcompraID, NroPedido, Fecha, NombreProveedor son devueltas por el SP.
                    });
                }
            }
            catch (Exception e) { throw new Exception("Error al listar Pedidos Aprobados: " + e.Message); }
            finally { if (cmd != null && cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close(); }

            return lista;
        }
        // Resuelve CS1061 para AnularPedido
        public void AnularPedido(int pedidoID)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PedidoCompraID", pedidoID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al ejecutar AnularPedido en la Capa de Datos: " + e.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
        }

        // -----------------------------------------------------
        // MÉTODO LISTAR (Lectura) - COMPLETO
        // -----------------------------------------------------
        public List<entPedidoCompra> Listar(int? pedidoID = null, int? reqcompraID = null,
                                            int? proveedorID = null, string estado = null,
                                            DateTime? desde = null, DateTime? hasta = null)
        {
            SqlCommand cmd = null;
            List<entPedidoCompra> lista = new List<entPedidoCompra>();
            SqlConnection cn = null;

            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPedidoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de filtro
                cmd.Parameters.AddWithValue("@PedidoCompraID", pedidoID.HasValue ? (object)pedidoID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReqcompraID", reqcompraID.HasValue ? (object)reqcompraID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID.HasValue ? (object)proveedorID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", (object)estado ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaDesde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaHasta", (object)hasta ?? DBNull.Value);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var p = new entPedidoCompra
                    {
                        PedidoCompraID = Convert.ToInt32(dr["PedcompraID"]),
                        ReqcompraID = Convert.ToInt32(dr["ReqcompraID"]),
                        NroPedido = dr["Numero"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        FormaPagoID = Convert.ToInt32(dr["FormaPagoID"]),
                        ProveedorID = Convert.ToInt32(dr["ProveedorID"]),
                        Observacion = dr["Observacion"].ToString(),
                        TotalItems = Convert.ToInt32(dr["TotalItems"]),
                        Estado = dr["Estado"].ToString(),
                        NombreProveedor = dr.IsDBNull(dr.GetOrdinal("NombreProveedor")) ? "" : dr["NombreProveedor"].ToString()
                    };
                    lista.Add(p);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar pedidos en la Capa de Datos: " + e.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return lista;
        }

        // --- InsertarPedido y InsertarDetalle (Omitido aquí, pero debe estar completo en tu archivo) ---
    }
}