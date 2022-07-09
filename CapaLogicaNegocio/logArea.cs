using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logArea
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logArea _instancia = new logArea();
        //privado para evitar la instanciación directa
        public static logArea Instancia
        {
            get
            {
                return logArea._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entArea> ListarArea()
        {
            return datArea.Instancia.ListarArea();
        }

    }
}
