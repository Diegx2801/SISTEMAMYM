using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datOrdensalida
    {
        #region singleton
        private static readonly datOrdensalida _instancia = new datOrdensalida();
        public static datOrdensalida Instancia => _instancia;
        #endregion

        #region Métodos de Lectura

        // Método para listar órdenes (para la Bandeja)
        public List<entOrdensalida> ListarOrdensalida(string num, int? obraId, DateTime? desde, DateTime? hasta)
        {
            SqlCommand cmd = null;
            List<entOrdensalida> lista = new List<entOrdensalida>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrdensalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Numero", (object)num ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ObraID", (object)obraId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaDesde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaHasta", (object)hasta ?? DBNull.Value);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entOrdensalida os = new entOrdensalida
                    {
                        OrdensalidaID = Convert.ToInt32(dr["OrdensalidaID"]),
                        Numero = dr["Numero"].ToString(),
                        ObraID = Convert.ToInt32(dr["ObraID"]),
                        NombreObra = dr["NombreObra"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Estado = dr["Estado"].ToString()
                    };
                    lista.Add(os);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null && cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close(); }

            return lista;
        }

        // Método para buscar Material por Código (para el formulario de registro)
        public entMaterial BuscarMaterialPorCodigo(string codigo)
        {
            SqlCommand cmd = null;
            entMaterial material = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarMaterialPorCodigo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    material = new entMaterial
                    {
                        MaterialID = Convert.ToInt32(dr["MaterialID"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Material"].ToString(),
                        UnidadMedida = dr["UnidadMedida"].ToString(),
                        Stock = Convert.ToDecimal(dr["Stock"]),
                        // No es necesario mapear el resto de propiedades de entMaterial
                    };
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null && cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close(); }

            return material;
        }

        #endregion

        #region Métodos de Escritura (Transaccionales)

        // Método para registrar la cabecera y el detalle de la Orden de Salida
        public int RegistrarOrdensalida(entOrdensalida os)
        {
            SqlCommand cmdCabecera = null;
            SqlCommand cmdDetalle = null;
            int nuevoId = 0;
            SqlConnection cn = null; // Declarado fuera del try para el finally

            try
            {
                cn = Conexion.Instancia.Conectar();
                cn.Open();

                // 1. Insertar la Cabecera de la Orden de Salida
                cmdCabecera = new SqlCommand("spInsertarOrdensalida", cn);
                cmdCabecera.CommandType = CommandType.StoredProcedure;
                cmdCabecera.Parameters.AddWithValue("@Numero", os.Numero);
                cmdCabecera.Parameters.AddWithValue("@ObraID", os.ObraID);
                cmdCabecera.Parameters.AddWithValue("@Observacion", os.Observacion);

                SqlParameter idParam = new SqlParameter("@NuevoID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmdCabecera.Parameters.Add(idParam);

                cmdCabecera.ExecuteNonQuery();

                // Lectura del ID después de la ejecución
                nuevoId = Convert.ToInt32(idParam.Value);

                // 2. Insertar los Detalles y Actualizar Stock (por cada detalle)
                foreach (var detalle in os.Detalle)
                {
                    cmdDetalle = new SqlCommand("spInsertarDetordensalida_y_ActualizarStock", cn);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    // Aseguramos que no queden parámetros residuales (aunque al instanciar de nuevo no debería ser un problema, es más seguro)
                    cmdDetalle.Parameters.Clear();

                    // Enviamos los parámetros del detalle
                    cmdDetalle.Parameters.AddWithValue("@OrdensalidaID", nuevoId);
                    cmdDetalle.Parameters.AddWithValue("@MaterialID", detalle.MaterialID);
                    cmdDetalle.Parameters.AddWithValue("@UnidadMedida", detalle.UnidadMedida);
                    cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

                    cmdDetalle.ExecuteNonQuery();
                }
            }
            catch (Exception e) { throw e; }
            finally
            {
                // Cierra la conexión principal si está abierta
                if (cn != null && cn.State == ConnectionState.Open) cn.Close();
            }

            return nuevoId;
        }

        // Método para anular la Orden de Salida y revertir el stock
        public bool AnularOrdensalida(entOrdensalida os)
        {
            SqlCommand cmd = null;
            bool ok = false;
            SqlConnection cn = null; // Declarado fuera del try para el finally

            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularOrdensalida_y_RevertirStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrdensalidaID", os.OrdensalidaID);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally
            {
                // Aseguramos el cierre de la conexión
                if (cn != null && cn.State == ConnectionState.Open) cn.Close();
            }

            return ok;
        }

        #endregion
    }
}
