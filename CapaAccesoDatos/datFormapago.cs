using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datFormapago
    {
        private static readonly datFormapago _instancia = new datFormapago();
        public static datFormapago Instancia => _instancia;

        // LISTAR
        public List<entFormapago> ListarFormapago()
        {
            SqlCommand cmd = null;
            List<entFormapago> lista = new List<entFormapago>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarFormapago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entFormapago
                    {
                        FormapagoID = Convert.ToInt32(dr["FormapagoID"]),
                        Entidad = dr["Entidad"].ToString(),
                        Condiciones = dr["Condiciones"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    });
                }
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return lista;
        }

        // INSERTAR
        public bool InsertarFormapago(entFormapago fp)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarFormapago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Entidad", fp.Entidad);
                cmd.Parameters.AddWithValue("@Condiciones", fp.Condiciones);
                cmd.Parameters.AddWithValue("@Descripcion", fp.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", fp.Estado);
                cn.Open();

                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        // EDITAR
        public bool EditarFormapago(entFormapago fp)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarFormapago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FormapagoID", fp.FormapagoID);
                cmd.Parameters.AddWithValue("@Entidad", fp.Entidad);
                cmd.Parameters.AddWithValue("@Condiciones", fp.Condiciones);
                cmd.Parameters.AddWithValue("@Descripcion", fp.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", fp.Estado);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        // DESHABILITAR
        public bool DeshabilitarFormapago(int id)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarFormapago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FormapagoID", id);

                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }
    }
}
