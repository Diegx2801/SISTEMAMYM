using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdeningreso
    {
        public int OrdeningresoID { get; set; }
        public string Numero { get; set; }

        public int PedcompraID { get; set; }
        public string NroPedido { get; set; } // Viene del JOIN
        public string NombreProveedor { get; set; } // Viene del JOIN

        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }

        public List<entDetordeningreso> Detalle { get; set; }
    }
}
