using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datProveedor
    {
        #region singleton
        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia => _instancia;
        #endregion

        #region métodos

        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor p = new entProveedor
                    {
                        ProveedorID = Convert.ToInt32(dr["ProveedorID"]),
                        Ruc = dr["Ruc"].ToString(),
                        RazonSocial = dr["RazonSocial"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                    lista.Add(p);
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

        public bool InsertarProveedor(entProveedor p)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ruc", p.Ruc);
                cmd.Parameters.AddWithValue("@RazonSocial", p.RazonSocial);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@Correo", p.Correo);
                cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", p.Estado);

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

        public bool EditarProveedor(entProveedor p)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProveedorID", p.ProveedorID);
                cmd.Parameters.AddWithValue("@Ruc", p.Ruc);
                cmd.Parameters.AddWithValue("@RazonSocial", p.RazonSocial);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@Correo", p.Correo);
                cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", p.Estado);

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

        public bool DeshabilitarProveedor(entProveedor p)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProveedorID", p.ProveedorID);

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
