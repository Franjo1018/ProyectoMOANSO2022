using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logProcesoProduccion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProcesoProduccion _instancia = new logProcesoProduccion();
        //privado para evitar la instanciación directa
        public static logProcesoProduccion Instancia
        {
            get
            {
                return logProcesoProduccion._instancia;
            }
        }
        #endregion singleton

      

        public List<entProcesoProduccion> ListarProcesoProduccion()
        {
            return datProcesoProduccion.Instancia.ListarProcesoProduccion();
        }
   
        public void InsertarProcesoProduccion(entProcesoProduccion PrPr)
        {
            datProcesoProduccion.Instancia.InsertarProcesoProduccion(PrPr);
        }

        //edita
        public void EditarProcesoProduccion(entProcesoProduccion PrPr)
        {
            datProcesoProduccion.Instancia.EditarProcesoProduccion(PrPr);
        }
 
    }
}
