using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logTipopedido
    {
        private static readonly logTipopedido _instancia = new logTipopedido();
        
        public static logTipopedido Instancia
        {
            get
            {
                return logTipopedido._instancia;
            }
        }

        public List<entTipopedido> ListarTipoPedido()
        {
            return datTipopedido.Instancia.ListarTipoPedido();
        }

    }
}
