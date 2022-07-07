using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {
        public int codigoPedido { get; set; }
        public string tipoPedido { get; set; }
        public string nombrecliente { get; set; }
        public string descripcion { get; set; }
        public DateTime fecRegInicio { get; set; }
        public DateTime fecRegTermino { get; set; }
    }
}
