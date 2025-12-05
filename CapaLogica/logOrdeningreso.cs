using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    // Resuelve el error CS0103 al crear la clase.
    public class logOrdeningreso
    {
        #region singleton
        private static readonly logOrdeningreso _instancia = new logOrdeningreso();
        public static logOrdeningreso Instancia => _instancia;
        #endregion

        // Método para listar órdenes de ingreso (para la bandeja)
        public List<entOrdeningreso> Listar(int? oiId, string numero, DateTime? desde, DateTime? hasta)
        {
            return datOrdeningreso.Instancia.Listar(oiId, numero, desde, hasta);
        }

        // Método para listar pedidos aprobados (para el DGV del formulario de registro)
        // Llama al método recién creado en datPedidoCompra (Resuelve CS1061)
        public List<entPedidoCompra> ListarPedidosAprobados()
        {
            return datPedidoCompra.Instancia.ListarPedidosAprobados();
        }

        // Método transaccional para registrar la orden de ingreso
        public int RegistrarOrdenIngreso(entOrdeningreso oi)
        {
            if (string.IsNullOrWhiteSpace(oi.Numero))
            {
                throw new Exception("El número de Orden de Ingreso es obligatorio.");
            }
            if (oi.PedcompraID <= 0)
            {
                throw new Exception("Error interno: No se pudo identificar el Pedido de Compra.");
            }

            // Llama a la Capa de Datos para ejecutar el SP transaccional
            return datOrdeningreso.Instancia.RegistrarOrdenIngreso(oi);
        }
    }
}