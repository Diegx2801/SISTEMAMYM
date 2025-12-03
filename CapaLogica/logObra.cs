using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logObra
    {
        #region singleton
        private static readonly logObra _instancia = new logObra();
        public static logObra Instancia => _instancia;
        #endregion

        #region métodos

        public List<entObra> ListarObra()
        {
            return datObra.Instancia.ListarObra();
        }

        public void InsertarObra(entObra o)
        {
            datObra.Instancia.InsertarObra(o);
        }

        public void EditarObra(entObra o)
        {
            datObra.Instancia.EditarObra(o);
        }

        public void DeshabilitarObra(entObra o)
        {
            datObra.Instancia.DeshabilitarObra(o);
        }

        #endregion
    }
}
