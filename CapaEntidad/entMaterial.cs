using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMaterial
    {
        public int MaterialID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public int TipomaterialID { get; set; }
        public string TipoMaterial { get; set; }

        public int MarcaID { get; set; }
        public string Marca { get; set; }

        public int ProveedorID { get; set; }
        public string Proveedor { get; set; }

        public string UnidadMedida { get; set; }
        public decimal Stock { get; set; }
        public bool Estado { get; set; }
    }
}
