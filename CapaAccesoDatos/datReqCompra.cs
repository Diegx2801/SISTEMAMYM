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
    public class datReqcompra
    {
        #region singleton
        private static readonly datReqcompra _instancia = new datReqcompra();
        public static datReqcompra Instancia { get { return datReqcompra._instancia; } }
        #endregion

        // Listar cabeceras (usa spListarReqcompra)
        public List<entReqcompra> Listar(int? reqcompraID = null, int? obraID = null, string estado = null, DateTime? desde = null, DateTime? hasta = null)
        {
            SqlCommand cmd = null;
            List<entReqcompra> lista = new List<entReqcompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReqcompraID", reqcompraID.HasValue ? (object)reqcompraID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ObraID", obraID.HasValue ? (object)obraID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", string.IsNullOrEmpty(estado) ? (object)DBNull.Value : estado);
                cmd.Parameters.AddWithValue("@FechaDesde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaHasta", (object)hasta ?? DBNull.Value);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReqcompra e = new entReqcompra
                    {
                        ReqcompraID = Convert.ToInt32(dr["ReqcompraID"]),
                        ObraID = Convert.ToInt32(dr["ObraID"]),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Solicitante = dr["Solicitante"].ToString(),
                        Prioridad = dr["Prioridad"].ToString(),
                        Observacion = dr["Observacion"].ToString(),
                        Estado = dr["Estado"].ToString(),
                        TotalItems = Convert.ToInt32(dr["TotalItems"])
                    };
                    lista.Add(e);
                }
            }
            catch (Exception) { throw; }
            finally { if (cmd != null && cmd.Connection != null) cmd.Connection.Close(); }
            return lista;
        }

        public List<entDetreqcompra> ListarDetalles(int reqcompraID)
        {
            SqlCommand cmd = null;
            List<entDetreqcompra> lista = new List<entDetreqcompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarDetReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReqcompraID", reqcompraID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetreqcompra d = new entDetreqcompra
                    {
                        DetreqcompraID = Convert.ToInt32(dr["DetreqcompraID"]),
                        ReqcompraID = Convert.ToInt32(dr["ReqcompraID"]),
                        MaterialID = Convert.ToInt32(dr["MaterialID"]),
                        NombreMaterial = dr["NombreMaterial"].ToString(),
                        UnidadMedida = dr["UnidadMedida"].ToString(),
                        Cantidad = Convert.ToDecimal(dr["Cantidad"]),
                        Observacion = dr["Observacion"].ToString()
                    };
                    lista.Add(d);
                }
            }
            catch (Exception) { throw; }
            finally { if (cmd != null && cmd.Connection != null) cmd.Connection.Close(); }
            return lista;
        }
        // Insertar requerimiento: usa spInsertarReqcompra + spInsertarDetReqcompra en transacción
        public int InsertarReqcompra(entReqcompra r)
        {
            SqlCommand cmd = null;
            int idGenerado = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ObraID", r.ObraID);
                cmd.Parameters.AddWithValue("@Fecha", r.Fecha);
                cmd.Parameters.AddWithValue("@Solicitante", r.Solicitante);
                cmd.Parameters.AddWithValue("@Prioridad", r.Prioridad);
                cmd.Parameters.AddWithValue("@Observacion", r.Observacion);
                cmd.Parameters.AddWithValue("@Estado", r.Estado);
                cmd.Parameters.AddWithValue("@TotalItems", r.TotalItems);

                SqlParameter pID = new SqlParameter("@ReqcompraID", SqlDbType.Int);
                pID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pID);

                cn.Open();
                cmd.ExecuteNonQuery();

                idGenerado = Convert.ToInt32(cmd.Parameters["@ReqcompraID"].Value);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return idGenerado;
        }

        public void InsertarDetalle(entDetreqcompra d, int reqID)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReqcompraID", reqID);
                cmd.Parameters.AddWithValue("@MaterialID", d.MaterialID);  // correlativo
                cmd.Parameters.AddWithValue("@NombreMaterial", d.NombreMaterial);
                cmd.Parameters.AddWithValue("@UnidadMedida", d.UnidadMedida);
                cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                cmd.Parameters.AddWithValue("@Observacion", d.Observacion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
        }

        // Editar (cabecera)
        public bool EditarReqcompra(entReqcompra req)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReqcompraID", req.ReqcompraID);
                cmd.Parameters.AddWithValue("@ObraID", req.ObraID);
                cmd.Parameters.AddWithValue("@Fecha", req.Fecha);
                cmd.Parameters.AddWithValue("@Solicitante", string.IsNullOrEmpty(req.Solicitante) ? (object)DBNull.Value : req.Solicitante);
                cmd.Parameters.AddWithValue("@Prioridad", string.IsNullOrEmpty(req.Prioridad) ? (object)DBNull.Value : req.Prioridad);
                cmd.Parameters.AddWithValue("@Observacion", string.IsNullOrEmpty(req.Observacion) ? (object)DBNull.Value : req.Observacion);
                cmd.Parameters.AddWithValue("@Estado", string.IsNullOrEmpty(req.Estado) ? (object)DBNull.Value : req.Estado);
                cmd.Parameters.AddWithValue("@TotalItems", req.TotalItems);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                ok = i > 0;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null && cmd.Connection != null) cmd.Connection.Close(); }
            return ok;
        }

        // Enviar
        public bool EnviarACompras(int reqcompraID)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEnviarReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReqcompraID", reqcompraID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                ok = i > 0;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null && cmd.Connection != null) cmd.Connection.Close(); }
            return ok;
        }

        // Anular
        public bool Anular(int reqcompraID)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReqcompraID", reqcompraID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                ok = i > 0;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null && cmd.Connection != null) cmd.Connection.Close(); }
            return ok;
        }

        // Cerrar
        public bool Cerrar(int reqcompraID)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spCerrarReqcompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReqcompraID", reqcompraID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                ok = i > 0;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null && cmd.Connection != null) cmd.Connection.Close(); }
            return ok;
        }

        // Eliminar detalle (opcional)
        public bool EliminarDetalle(int detreqcompraID)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DELETE FROM Detreqcompra WHERE DetreqcompraID = @id", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", detreqcompraID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                ok = i > 0;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null && cmd.Connection != null) cmd.Connection.Close(); }
            return ok;
        }
    }
}

