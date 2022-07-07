using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMuebleTerminado
    {
        public int codigoMueble { get; set; }
        public string tipoMueble { get; set; }
        public string planoMueble { get; set; }
        public DateTime fecRegMueble { get; set; }
        public Boolean estadoMueble { get; set; }
    }
}
