using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public int estado_pedido { get; set; }
        public DateTime fecRegPedido { get; set; }
        public DateTime fecRegSolicitada { get; set; }
        public int pedidoID { get; set; }
        public int clienteID { get; set; }
        public int tipoPedidoID { get; set; }
         
    }
}
