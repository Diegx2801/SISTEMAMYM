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

        // Registra cabecera + detalles (omisión por brevedad)
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

        public List<entPedidoCompra> Listar(int? pedidoID = null, int? reqcompraID = null,
                                            int? proveedorID = null,
                                            string estado = null, // <<< ARGUMENTO FALTANTE
                                            DateTime? desde = null, DateTime? hasta = null)
        {
            // Llama a la Capa de Datos (que sí está configurada para recibir 6 argumentos)
            return datPedidoCompra.Instancia.Listar(pedidoID, reqcompraID, proveedorID, estado, desde, hasta);
        }

        // Asegúrate de que el resto de tu Capa Lógica se vea así, con los métodos de acción:
        public void AprobarPedido(int pedidoID)
        {
            datPedidoCompra.Instancia.AprobarPedido(pedidoID);
        }

        public void AnularPedido(int pedidoID)
        {
            datPedidoCompra.Instancia.AnularPedido(pedidoID);
        }
    }
}