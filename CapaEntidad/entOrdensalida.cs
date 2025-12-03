using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdensalida
    {
        public int OrdensalidaID { get; set; }
        public string Numero { get; set; }

        public int ObraID { get; set; }
        public string NombreObra { get; set; } // Para mostrar en bandeja

        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }

        // Propiedad para llevar los detalles en la misma entidad de cabecera (patrón composición)
        public List<entDetordensalida> Detalle { get; set; } = new List<entDetordensalida>();
    }
}
