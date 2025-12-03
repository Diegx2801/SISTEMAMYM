using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entReqcompra
    {
        public int ReqcompraID { get; set; }
        public int ObraID { get; set; }
        public DateTime Fecha { get; set; }
        public string Solicitante { get; set; }
        public string Prioridad { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public int TotalItems { get; set; }

        public List<entDetreqcompra> Detalles { get; set; } = new List<entDetreqcompra>();
    }
}
