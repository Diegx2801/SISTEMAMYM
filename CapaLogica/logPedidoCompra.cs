using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPedidoCompra
    {
        #region singleton
        private static readonly logPedidoCompra _instancia = new logPedidoCompra();
        public static logPedidoCompra Instancia { get { return _instancia; } }
        #endregion

        // Registra cabecera + detalles usando los detalles del requerimiento
        public bool RegistrarPedido(entPedidoCompra p, List<entDetPedidoCompra> detallesReq)
        {
            try
            {
                p.TotalItems = detallesReq.Count;

                int pedidoID = datPedidoCompra.Instancia.InsertarPedido(p);

                foreach (var d in detallesReq)
                {
                    var det = new entDetPedidoCompra
                    {
                        PedidoCompraID = pedidoID,
                        MaterialID = d.MaterialID,
                        NombreMaterial = d.NombreMaterial,
                        UnidadMedida = d.UnidadMedida,
                        Cantidad = d.Cantidad,
                        Observacion = d.Observacion
                    };

                    datPedidoCompra.Instancia.InsertarDetalle(det, pedidoID);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Para la bandeja de pedidos de compra
        public List<entPedidoCompra> Listar(int? pedidoID = null, int? reqcompraID = null,
                                            int? proveedorID = null, DateTime? desde = null, DateTime? hasta = null)
        {
            return datPedidoCompra.Instancia.Listar(pedidoID, reqcompraID, proveedorID, desde, hasta);
        }
    }
}
