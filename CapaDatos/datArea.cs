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
    public class datArea
    {
        private static readonly datArea _instancia = new datArea();

        public static datArea Instancia
        {
            get
            {
                return datArea._instancia;
            }
        }

        ////////////////////lista tipo Area
        public List<entArea> ListarArea()
        {
            SqlCommand cmd = null;
            List<entArea> lista = new List<entArea>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaArea", cn);//                                                      
                cmd.CommandType = CommandType.StoredProcedure;//
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entArea Ar = new entArea();
                    Ar.nombre_area = dr["Nombre_area"].ToString();
                    Ar.areaID = Convert.ToInt32(dr["AreaID"]);
                    lista.Add(Ar);
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
