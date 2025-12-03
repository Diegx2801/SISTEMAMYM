using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logFormapago
    {
        private static readonly logFormapago _instancia = new logFormapago();
        public static logFormapago Instancia => _instancia;

        public List<entFormapago> ListarFormapago()
        {
            return datFormapago.Instancia.ListarFormapago();
        }

        public void InsertarFormapago(entFormapago fp)
        {
            datFormapago.Instancia.InsertarFormapago(fp);
        }

        public void EditarFormapago(entFormapago fp)
        {
            datFormapago.Instancia.EditarFormapago(fp);
        }

        public void DeshabilitarFormapago(int id)
        {
            datFormapago.Instancia.DeshabilitarFormapago(id);
        }
    }
}
