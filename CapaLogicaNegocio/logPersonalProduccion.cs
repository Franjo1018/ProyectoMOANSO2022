using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logPersonalProduccion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPersonalProduccion _instancia = new logPersonalProduccion();
        //privado para evitar la instanciación directa
        public static logPersonalProduccion Instancia
        {
            get
            {
                return logPersonalProduccion._instancia;
            }
        }
        #endregion singleton


        public List<entPersonalProduccion> ListarPersonalProduccion()
        {
            return datPersonalProduccion.Instancia.ListarPersonalProduccion();
        }
        ///inserta
        public void InsertarPersonalProduccion(entPersonalProduccion Per)
        {
            datPersonalProduccion.Instancia.InsertarPersonalProduccion(Per);
        }

        //edita
        public void EditarPersonalProduccion(entPersonalProduccion Per)
        {
            datPersonalProduccion.Instancia.EditarPersonalProduccion(Per);
        }
        //deshabilita
        public void DeshabilitarPersonalProduccion(entPersonalProduccion Per)
        {
            datPersonalProduccion.Instancia.DeshabilitarPersonalProduccion(Per);
        }
    }
}
