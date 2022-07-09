using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPlanodeMueble
    {
        public string estado_plano { get; set; }
        public DateTime fecha_plano { get; set; }
        public byte[] foto { get; set; }
        public int planodemuebleID { get; set; }
    }
}
