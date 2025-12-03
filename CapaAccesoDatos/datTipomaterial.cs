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
    public class datTipomaterial
    {
        #region singleton
        private static readonly datTipomaterial _instancia = new datTipomaterial();
        public static datTipomaterial Instancia => _instancia;
        #endregion

        #region métodos

        public List<entTipomaterial> ListarTipomaterial()
        {
            SqlCommand cmd = null;
            List<entTipomaterial> lista = new List<entTipomaterial>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipomaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipomaterial t = new entTipomaterial
                    {
                        TipomaterialID = Convert.ToInt32(dr["TipomaterialID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                    lista.Add(t);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }

        public bool InsertarTipomaterial(entTipomaterial t)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipomaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", t.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return ok;
        }

        public bool EditarTipomaterial(entTipomaterial t)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipomaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TipomaterialID", t.TipomaterialID);
                cmd.Parameters.AddWithValue("@Nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", t.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return ok;
        }

        public bool DeshabilitarTipomaterial(entTipomaterial t)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipomaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TipomaterialID", t.TipomaterialID);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return ok;
        }

        #endregion
    }
}
