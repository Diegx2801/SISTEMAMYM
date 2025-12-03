using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetordensalida
    {
        public int DetordensalidaID { get; set; }
        public int OrdensalidaID { get; set; }
        public int MaterialID { get; set; }

        // Datos para mostrar en el Grid/DataGridView
        public string CodigoMaterial { get; set; }
        public string NombreMaterial { get; set; }

        public string UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}
