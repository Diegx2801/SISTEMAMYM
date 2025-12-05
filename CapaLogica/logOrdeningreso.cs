using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logOrdeningreso
    {
        #region singleton
        private static readonly logOrdeningreso _instancia = new logOrdeningreso();
        public static logOrdeningreso Instancia => _instancia;
        #endregion

        // Método para listar órdenes de ingreso (para la bandeja)
        // Firma con 5 argumentos (oiId, numero, proveedorID, desde, hasta)
        public List<entOrdeningreso> Listar(int? oiId, string numero,
                                            int? proveedorID = null,
                                            DateTime? desde = null, DateTime? hasta = null)
        {
            return datOrdeningreso.Instancia.Listar(oiId, numero, proveedorID, desde, hasta);
        }

        // Método para listar pedidos aprobados (para el DGV de selección)
        public List<entPedidoCompra> ListarPedidosAprobados()
        {
            // Llama al método que debe existir en datPedidoCompra.cs
            return datPedidoCompra.Instancia.ListarPedidosAprobados();
        }

        // Método transaccional para registrar la orden de ingreso (Cabecera + Detalles + Stock)
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