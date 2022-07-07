using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPedido _instancia = new logPedido();
        //privado para evitar la instanciación directa
        public static logPedido Instancia
        {
            get
            {
                return logPedido._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entPedido> ListarPedido()
        {
            return datPedido.Instancia.ListarPedido();
        }
        ///inserta
        public void InsertarPedido(entPedido Ped)
        {
            datPedido.Instancia.InsertarPedido(Ped);
        }

        //edita
        public void EditarPedido(entPedido Ped)
        {
            datPedido.Instancia.EditarPedido(Ped);
        }
        //deshabilita
        public void DeshabilitarPedido(entPedido Ped)
        {
            datPedido.Instancia.DeshabilitarPedido(Ped);
        }
    }
}
