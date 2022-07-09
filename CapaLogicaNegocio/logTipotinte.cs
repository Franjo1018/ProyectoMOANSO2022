using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logTipotinte
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipotinte _instancia = new logTipotinte();
        //privado para evitar la instanciación directa
        public static logTipotinte Instancia
        {
            get
            {
                return logTipotinte._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entTipotinte> ListarTipoTinte()
        {
            return datTipotinte.Instancia.ListarTipoTinte();
        }
    }
}
