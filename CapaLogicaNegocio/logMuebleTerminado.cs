using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logMuebleTerminado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMuebleTerminado _instancia = new logMuebleTerminado();
        //privado para evitar la instanciación directa
        public static logMuebleTerminado Instancia
        {
            get
            {
                return logMuebleTerminado._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entMuebleTerminado> ListarMuebleTerminado()
        {
            return datMuebleTerminado.Instancia.ListarMuebleTerminado();
        }
        ///inserta
        public void InsertarMuebleTerminado(entMuebleTerminado Mue)
        {
            datMuebleTerminado.Instancia.InsertarMuebleTerminado(Mue);
        }

        //edita
        public void EditarMuebleTerminado(entMuebleTerminado Mue)
        {
            datMuebleTerminado.Instancia.EditarMuebleTerminado(Mue);
        }
        //deshabilita
        public void DeshabilitarMuebleTerminado(entMuebleTerminado Mue)
        {
            datMuebleTerminado.Instancia.DeshabilitarMuebleTerminado(Mue);
        }
    }
}
