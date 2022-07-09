using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logMaterial
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMaterial _instancia = new logMaterial();
        //privado para evitar la instanciación directa
        public static logMaterial Instancia
        {
            get
            {
                return logMaterial._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entMaterial> ListarMaterial()
        {
            return datMaterial.Instancia.ListarMaterial();
        }
    }
}
