using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logPlanodeMueble
    {

        private static readonly logPlanodeMueble _instancia = new logPlanodeMueble();
        //privado para evitar la instanciación directa
        public static logPlanodeMueble Instancia
        {
            get
            {
                return logPlanodeMueble._instancia;
            }
        }


        ///listado

        public int PlanoID()
        {
            return datPlanodeMueble.Instancia.PlanoID();
        }

        public void InsertarPlanodeMueble(entPlanodeMueble PlMu)
        {
            datPlanodeMueble.Instancia.InsertarPlanodeMueble(PlMu);
        }
    }
}
