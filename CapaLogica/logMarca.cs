using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMarca
    {
        #region singleton
        private static readonly logMarca _instancia = new logMarca();
        public static logMarca Instancia => _instancia;
        #endregion

        #region métodos

        public List<entMarca> ListarMarca()
        {
            return datMarca.Instancia.ListarMarca();
        }

        public void InsertarMarca(entMarca m)
        {
            datMarca.Instancia.InsertarMarca(m);
        }

        public void EditarMarca(entMarca m)
        {
            datMarca.Instancia.EditarMarca(m);
        }

        public void DeshabilitarMarca(entMarca m)
        {
            datMarca.Instancia.DeshabilitarMarca(m);
        }

        #endregion
    }
}
