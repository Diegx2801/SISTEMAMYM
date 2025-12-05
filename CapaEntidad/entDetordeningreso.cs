using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetordeningreso
    {
        public int DetordeningresoID { get; set; }
        public int OrdeningresoID { get; set; }
        public int MaterialID { get; set; }

        public string UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}
