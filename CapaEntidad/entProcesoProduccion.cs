using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProcesoProduccion
    {
        public string descripcion { get; set; }
        public int duracion { get; set; }
        public string nombre_proceso { get; set; }
        public int ProcesoProduccionID { get; set; }
        public int areaID { get; set; }
        public int tipoProcesoID { get; set; }
    }
}
