using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    // Resuelve el error CS0103 al crear la clase.
    public class datOrdeningreso
    {
        #region singleton
        private static readonly datOrdeningreso _instancia = new datOrdeningreso();
        public static datOrdeningreso Instancia => _instancia;
        #endregion

        // Método para listar Órdenes de Ingreso (Acepta ProveedorID, SIN Estado)
        public List<entOrdeningreso> Listar(int? oiId, string numero,
                                            int? proveedorID = null,
                                            DateTime? desde = null, DateTime? hasta = null)
        {
            SqlCommand cmd = null;
            List<entOrdeningreso> lista = new List<entOrdeningreso>();
            SqlConnection cn = null;

            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrdeningreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de filtro
                cmd.Parameters.AddWithValue("@OrdeningresoID", (object)oiId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Numero", (object)numero ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ProveedorID", (object)proveedorID ?? DBNull.Value); // Filtro Proveedor
                cmd.Parameters.AddWithValue("@FechaDesde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaHasta", (object)hasta ?? DBNull.Value);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entOrdeningreso
                    {
                        OrdeningresoID = Convert.ToInt32(dr["OrdeningresoID"]),
                        Numero = dr["Numero"].ToString(),
                        // Asumo que el SP retorna PedcompraID, NroPedido, NombreProveedor
                        PedcompraID = Convert.ToInt32(dr["PedcompraID"]),
                        NombreProveedor = dr["NombreProveedor"].ToString(),
                        NroPedido = dr["NroPedido"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Observacion = dr["Observacion"].ToString(),
                        Estado = dr["Estado"].ToString()
                    });
                }
            }
            catch (Exception e) { throw new Exception("Error al listar órdenes de ingreso: " + e.Message); }
            finally { if (cmd != null && cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close(); }

            return lista;
        }

        // Método TRANSACCIONAL para registrar cabecera, detalles y actualizar stock
        public int RegistrarOrdenIngreso(entOrdeningreso oi)
        {
            SqlCommand cmd = null;
            int nuevoId = 0;
            SqlConnection cn = null;

            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarOrdenIngreso_y_ActualizarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Numero", oi.Numero);
                cmd.Parameters.AddWithValue("@PedcompraID", oi.PedcompraID);
                cmd.Parameters.AddWithValue("@Observacion", (object)oi.Observacion ?? DBNull.Value);

                SqlParameter idParam = new SqlParameter("@NuevoID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(idParam);

                cn.Open();
                cmd.ExecuteNonQuery();
                nuevoId = Convert.ToInt32(idParam.Value);
            }
            catch (Exception e) { throw new Exception("Error al registrar la Orden de Ingreso: " + e.Message); }
            finally { if (cn != null && cn.State == ConnectionState.Open) cn.Close(); }

            return nuevoId;
        }
    }
}