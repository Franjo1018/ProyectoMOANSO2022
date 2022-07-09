using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logDetallemueble
    {
        private static readonly logDetallemueble _instancia = new logDetallemueble();

        public static logDetallemueble Instancia
        {
            get
            {
                return logDetallemueble._instancia;
            }
        }

        public List<entDetallemueble> ListarDetalleMueble(int i)
        {
            return datDetallemueble.Instancia.ListarDetalleMueble(i);
        }

        public void InsertarDetalleMueble(entDetallemueble DeMu)
        {
            datDetallemueble.Instancia.InsertarDetalleMueble(DeMu);
        }
    }
}
