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
    public class datMaterial
    {
        #region singleton
        private static readonly datMaterial _instancia = new datMaterial();
        public static datMaterial Instancia => _instancia;
        #endregion

        #region métodos

        public List<entMaterial> ListarMaterial()
        {
            SqlCommand cmd = null;
            List<entMaterial> lista = new List<entMaterial>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMaterial m = new entMaterial
                    {
                        MaterialID = Convert.ToInt32(dr["MaterialID"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Material"].ToString(),
                        TipomaterialID = Convert.ToInt32(dr["TipomaterialID"]),
                        TipoMaterial = dr["TipoMaterial"].ToString(),
                        MarcaID = Convert.ToInt32(dr["MarcaID"]),
                        Marca = dr["Marca"].ToString(),
                        ProveedorID = dr["ProveedorID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ProveedorID"]),
                        Proveedor = dr["Proveedor"].ToString(),
                        UnidadMedida = dr["UnidadMedida"].ToString(),
                        Stock = Convert.ToDecimal(dr["Stock"]),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                    lista.Add(m);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return lista;
        }

        public bool InsertarMaterial(entMaterial m)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", m.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@TipomaterialID", m.TipomaterialID);
                cmd.Parameters.AddWithValue("@MarcaID", m.MarcaID);
                cmd.Parameters.AddWithValue("@ProveedorID", m.ProveedorID == 0 ? (object)DBNull.Value : m.ProveedorID);
                cmd.Parameters.AddWithValue("@UnidadMedida", m.UnidadMedida);
                cmd.Parameters.AddWithValue("@Stock", m.Stock);
                cmd.Parameters.AddWithValue("@Estado", m.Estado);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        public bool EditarMaterial(entMaterial m)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaterialID", m.MaterialID);
                cmd.Parameters.AddWithValue("@Codigo", m.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@TipomaterialID", m.TipomaterialID);
                cmd.Parameters.AddWithValue("@MarcaID", m.MarcaID);
                cmd.Parameters.AddWithValue("@ProveedorID", m.ProveedorID == 0 ? (object)DBNull.Value : m.ProveedorID);
                cmd.Parameters.AddWithValue("@UnidadMedida", m.UnidadMedida);
                cmd.Parameters.AddWithValue("@Stock", m.Stock);
                cmd.Parameters.AddWithValue("@Estado", m.Estado);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        public bool DeshabilitarMaterial(entMaterial m)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaterialID", m.MaterialID);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        #endregion
    }
}
