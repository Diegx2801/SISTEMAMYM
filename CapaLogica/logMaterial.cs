using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMaterial
    {
        #region singleton
        private static readonly logMaterial _instancia = new logMaterial();
        public static logMaterial Instancia => _instancia;
        #endregion

        #region métodos

        public List<entMaterial> ListarMaterial()
        {
            return datMaterial.Instancia.ListarMaterial();
        }

        public void InsertarMaterial(entMaterial m)
        {
            datMaterial.Instancia.InsertarMaterial(m);
        }

        public void EditarMaterial(entMaterial m)
        {
            datMaterial.Instancia.EditarMaterial(m);
        }

        public void DeshabilitarMaterial(entMaterial m)
        {
            datMaterial.Instancia.DeshabilitarMaterial(m);
        }

        #endregion
    }
}
