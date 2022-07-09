using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datTipopedido
    {
        private static readonly datTipopedido _instancia = new datTipopedido();

        public static datTipopedido Instancia
        {
            get
            {
                return datTipopedido._instancia;
            }
        }

        public List<entTipopedido> ListarTipoPedido()
        {
            SqlCommand cmd = null;
            List<entTipopedido> lista = new List<entTipopedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaTipoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipopedido TiP = new entTipopedido();
                    TiP.nombre_tipo_pedido = dr["Nombre_tipo_pedido"].ToString();
                    TiP.tipopedidoID= Convert.ToInt32(dr["TipopedidoID"]);
                    lista.Add(TiP);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
