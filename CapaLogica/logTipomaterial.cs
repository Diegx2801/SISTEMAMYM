using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipomaterial
    {
        #region singleton
        private static readonly logTipomaterial _instancia = new logTipomaterial();
        public static logTipomaterial Instancia => _instancia;
        #endregion

        #region métodos

        public List<entTipomaterial> ListarTipomaterial()
        {
            return datTipomaterial.Instancia.ListarTipomaterial();
        }

        public void InsertarTipomaterial(entTipomaterial t)
        {
            datTipomaterial.Instancia.InsertarTipomaterial(t);
        }

        public void EditarTipomaterial(entTipomaterial t)
        {
            datTipomaterial.Instancia.EditarTipomaterial(t);
        }

        public void DeshabilitarTipomaterial(entTipomaterial t)
        {
            datTipomaterial.Instancia.DeshabilitarTipomaterial(t);
        }

        #endregion
    }
}
