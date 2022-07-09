using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logTipoproceso
    {
        #region sigleton

        private static readonly logTipoproceso _instancia = new logTipoproceso();

        public static logTipoproceso Instancia
        {
            get
            {
                return logTipoproceso._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entTipoproceso> ListarTipoProceso()
        {
            return datTipoproceso.Instancia.ListarTipoProceso();
        }
    }
}
