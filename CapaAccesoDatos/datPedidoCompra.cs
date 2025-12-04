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

        // Inserta cabecera de Pedido de Compra
        public int InsertarPedido(entPedidoCompra p)
        {
            SqlCommand cmd = null;
            int idGenerado = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPedidoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Asegúrate de que solo pasas los parámetros correctos
                cmd.Parameters.AddWithValue("@ReqcompraID", p.ReqcompraID);
                cmd.Parameters.AddWithValue("@Fecha", p.Fecha);
                cmd.Parameters.AddWithValue("@FormaPagoID", p.FormaPagoID);
                cmd.Parameters.AddWithValue("@ProveedorID", p.ProveedorID);
                cmd.Parameters.AddWithValue("@Observacion", string.IsNullOrEmpty(p.Observacion) ? (object)DBNull.Value : p.Observacion);
                cmd.Parameters.AddWithValue("@TotalItems", p.TotalItems);

                SqlParameter pID = new SqlParameter("@PedidoCompraID", SqlDbType.Int);
                pID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pID);

                cn.Open();
                cmd.ExecuteNonQuery();

                idGenerado = Convert.ToInt32(cmd.Parameters["@PedidoCompraID"].Value);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null) cmd.Connection.Close();
            }

            return idGenerado;
        }

        public void InsertarDetalle(entDetPedidoCompra d, int pedcompraID)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetPedcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parametrización con la nueva propiedad
                cmd.Parameters.AddWithValue("@PedcompraID", pedcompraID);
                cmd.Parameters.AddWithValue("@MaterialID", d.MaterialID);
                cmd.Parameters.AddWithValue("@NombreMaterial", d.NombreMaterial);  // Se agrega el nombre del material
                cmd.Parameters.AddWithValue("@UnidadMedida", d.UnidadMedida);
                cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                cmd.Parameters.AddWithValue("@Observacion", string.IsNullOrEmpty(d.Observacion) ? (object)DBNull.Value : d.Observacion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null && cmd.Connection != null) cmd.Connection.Close();
            }
        }

        // Listar pedidos para la bandeja de pedidos de compra
        public List<entPedidoCompra> Listar(int? pedidoID = null, int? reqcompraID = null,
                                      int? proveedorID = null, DateTime? desde = null, DateTime? hasta = null)
        {
            SqlCommand cmd = null;
            List<entPedidoCompra> lista = new List<entPedidoCompra>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPedidoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Verifica que los parámetros estén siendo pasados correctamente
                cmd.Parameters.AddWithValue("@PedidoCompraID", pedidoID.HasValue ? (object)pedidoID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReqcompraID", reqcompraID.HasValue ? (object)reqcompraID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID.HasValue ? (object)proveedorID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaDesde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaHasta", (object)hasta ?? DBNull.Value);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var p = new entPedidoCompra
                    {
                        PedidoCompraID = Convert.ToInt32(dr["PedCompraID"]),  // Usar el nombre correcto de la columna
                        ReqcompraID = Convert.ToInt32(dr["ReqcompraID"]),
                        NroPedido = dr["Numero"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        FormaPagoID = Convert.ToInt32(dr["FormaPagoID"]),
                        ProveedorID = Convert.ToInt32(dr["ProveedorID"]),
                        Observacion = dr["Observacion"].ToString(),
                        TotalItems = Convert.ToInt32(dr["TotalItems"])
                    };
                    lista.Add(p);
                }
            }
            finally
            {
                if (cmd != null && cmd.Connection != null) cmd.Connection.Close();
            }

            return lista;
        }
    }
}
