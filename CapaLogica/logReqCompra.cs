using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logReqcompra
    {
        #region singleton
        private static readonly logReqcompra _instancia = new logReqcompra();
        public static logReqcompra Instancia { get { return logReqcompra._instancia; } }
        #endregion

        public List<entReqcompra> Listar(int? reqcompraID = null, int? obraID = null, string estado = null, DateTime? desde = null, DateTime? hasta = null)
        {
            return datReqcompra.Instancia.Listar(reqcompraID, obraID, estado, desde, hasta);
        }

        /*public List<entDetreqcompra> ListarDetalles(int reqcompraID)
        {
            return datReqcompra.Instancia.ListarDetalles(reqcompraID);
        }*/

        public bool RegistrarRequerimiento(entReqcompra r)
        {
            try
            {
                int reqID = datReqcompra.Instancia.InsertarReqcompra(r);

                foreach (var det in r.Detalles)
                {
                    datReqcompra.Instancia.InsertarDetalle(det, reqID);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<entDetreqcompra> ListarDetalles(int reqcompraID)
        {
            return datReqcompra.Instancia.ListarDetalles(reqcompraID);
        }

        public bool Editar(entReqcompra req)
        {
            return datReqcompra.Instancia.EditarReqcompra(req);
        }

        public bool EnviarACompras(int reqcompraID)
        {
            return datReqcompra.Instancia.EnviarACompras(reqcompraID);
        }

        public bool Anular(int reqcompraID)
        {
            return datReqcompra.Instancia.Anular(reqcompraID);
        }

        public bool Cerrar(int reqcompraID)
        {
            return datReqcompra.Instancia.Cerrar(reqcompraID);
        }
    }
}
