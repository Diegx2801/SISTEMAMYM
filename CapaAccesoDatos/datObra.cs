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
    public class datObra
    {
        #region singleton
        private static readonly datObra _instancia = new datObra();
        public static datObra Instancia => _instancia;
        #endregion

        #region métodos

        public List<entObra> ListarObra()
        {
            SqlCommand cmd = null;
            List<entObra> lista = new List<entObra>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarObra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entObra o = new entObra
                    {
                        ObraID = Convert.ToInt32(dr["ObraID"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                    lista.Add(o);
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

        public bool InsertarObra(entObra o)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarObra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", o.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", o.Direccion);
                cmd.Parameters.AddWithValue("@Estado", o.Estado);

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

        public bool EditarObra(entObra o)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarObra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ObraID", o.ObraID);
                cmd.Parameters.AddWithValue("@Codigo", o.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", o.Direccion);
                cmd.Parameters.AddWithValue("@Estado", o.Estado);

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

        public bool DeshabilitarObra(entObra o)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarObra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ObraID", o.ObraID);

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
