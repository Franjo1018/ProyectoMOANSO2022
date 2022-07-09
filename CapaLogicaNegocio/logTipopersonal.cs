using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logTipopersonal
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipopersonal _instancia = new logTipopersonal();
        //privado para evitar la instanciación directa
        public static logTipopersonal Instancia
        {
            get
            {
                return logTipopersonal._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entTipopersonal> ListarTipoPersonal()
        {
            return datTipopersonal.Instancia.ListarTipoPersonal();
        }
    }
}
