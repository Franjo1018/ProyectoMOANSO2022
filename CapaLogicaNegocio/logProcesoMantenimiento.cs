using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logProcesoMantenimiento
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProcesoMantenimiento _instancia = new logProcesoMantenimiento();
        //privado para evitar la instanciación directa
        public static logProcesoMantenimiento Instancia
        {
            get
            {
                return logProcesoMantenimiento._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entProcesoMantenimiento> ListarProcesoMantenimiento()
        {
            return datProcesoMantenimiento.Instancia.ListarProcesoMantenimiento();
        }
        ///inserta
        public void InsertarProcesoMantenimiento(entProcesoMantenimiento Pro)
        {
            datProcesoMantenimiento.Instancia.InsertarProcesoMantenimiento(Pro);
        }

        //edita
        public void EditarProcesoMantenimiento(entProcesoMantenimiento Pro)
        {
            datProcesoMantenimiento.Instancia.EditarProcesoMantenimiento(Pro);
        }
        //deshabilita
        public void DeshabilitarProcesoMantenimiento(entProcesoMantenimiento Pro)
        {
            datProcesoMantenimiento.Instancia.DeshabilitarProcesoMantenimiento(Pro);
        }
    }
}
