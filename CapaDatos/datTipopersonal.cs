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
    public class datTipopersonal
    {
        
        private static readonly datTipopersonal _instancia = new datTipopersonal();
        
        public static datTipopersonal Instancia
        { 
            get
            {
                return datTipopersonal._instancia;
            }
        }

        ////////////////////lista tipo Personal
        public List<entTipopersonal> ListarTipoPersonal()
        {
            SqlCommand cmd = null;
            List<entTipopersonal> lista = new List<entTipopersonal>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaTipoPersonal", cn);//                                                      
                cmd.CommandType = CommandType.StoredProcedure;//
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipopersonal TiPe = new entTipopersonal();
                    TiPe.nombre_tipo_personal = dr["Nombre_tipo_personal"].ToString();
                    TiPe.tipoPersonalID = Convert.ToInt32(dr["TipoPersonalID"]);
                    lista.Add(TiPe);
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
