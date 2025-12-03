using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entFormapago
    {
        public int FormapagoID { get; set; }
        public string Entidad { get; set; }
        public string Condiciones { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
