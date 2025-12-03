using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region singleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia => _instancia;
        #endregion

        #region métodos

        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        public void InsertarProveedor(entProveedor p)
        {
            datProveedor.Instancia.InsertarProveedor(p);
        }

        public void EditarProveedor(entProveedor p)
        {
            datProveedor.Instancia.EditarProveedor(p);
        }

        public void DeshabilitarProveedor(entProveedor p)
        {
            datProveedor.Instancia.DeshabilitarProveedor(p);
        }

        #endregion
    }
}
