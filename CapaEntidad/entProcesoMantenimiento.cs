using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProcesoMantenimiento
    {
        public int codigoProceso { get; set; }
        public string procedimiento { get; set; }
        public string duracion { get; set; }
        public string tipoProceso { get; set; }
        public string descripcion { get; set; }
        public DateTime fecRegProceso { get; set; }
    }
}
