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
    public class datTipoproceso
    {
        private static readonly datTipoproceso _instancia = new datTipoproceso();

        public static datTipoproceso Instancia
        {
            get
            {
                return datTipoproceso._instancia;
            }
        }

        public List<entTipoproceso> ListarTipoProceso()
        {
            SqlCommand cmd = null;
            List<entTipoproceso> lista = new List<entTipoproceso>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaTipoProceso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoproceso TiPr = new entTipoproceso();
                    TiPr.nombre_tipo_proceso = dr["Nombre_tipo_proceso"].ToString();
                    TiPr.TipoprocesoID = Convert.ToInt32(dr["TipoprocesoID"]);
                    lista.Add(TiPr);
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
