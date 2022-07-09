using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMuebleTerminado
    {
        public int MuebleID { get; set; }
        public string Color_tinte { get; set; }
        public string Descripcion { get; set; }
        public int OrdendeproduccionID { get; set; }
        public int PlanodemuebleID { get; set; }
        public int TipotinteID { get; set; }
    }
}
