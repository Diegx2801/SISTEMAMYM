using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetPedidoCompra
    {
        public int DetPedidoCompraID { get; set; }
        public int PedidoCompraID { get; set; }

        public int MaterialID { get; set; }
        public string NombreMaterial { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}
