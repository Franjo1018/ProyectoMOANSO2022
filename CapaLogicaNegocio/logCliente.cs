using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logCliente
    {
        private static readonly logCliente _instancia = new logCliente();

        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
    }
}
