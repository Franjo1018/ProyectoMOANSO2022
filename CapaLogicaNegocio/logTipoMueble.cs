using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logTipoMueble
    {
        private static readonly logTipoMueble _instancia = new logTipoMueble();

        public static logTipoMueble Instancia
        {
            get
            {
                return logTipoMueble._instancia;
            }
        }

        public List<entTipomueble> ListarTipoMueble()
        {
            return datTipomueble.Instancia.ListarTipomueble();
        }
    }
}
