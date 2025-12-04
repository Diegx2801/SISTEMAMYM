using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedidoCompra
    {
        public int PedidoCompraID { get; set; }
        public int ReqcompraID { get; set; }
        public string NroPedido { get; set; }
        public string NombreMaterial { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPagoID { get; set; }
        public int ProveedorID { get; set; }
        public string Observacion { get; set; }
        public int TotalItems { get; set; }
    }
}
