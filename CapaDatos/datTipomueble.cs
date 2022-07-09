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
    public class datTipomueble
    {
        private static readonly datTipomueble _instancia = new datTipomueble();

        public static datTipomueble Instancia
        {
            get
            {
                return datTipomueble._instancia;
            }
        }

        public List<entTipomueble> ListarTipomueble()
        {
            SqlCommand cmd = null;
            List<entTipomueble> lista = new List<entTipomueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaTipoMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipomueble TiM = new entTipomueble();
                    TiM.nombre_tipo_mueble = dr["Nombre_tipo_pedido"].ToString();
                    TiM.TipotinteID = Convert.ToInt32(dr["TipotinteID"]);
                    lista.Add(TiM);
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
