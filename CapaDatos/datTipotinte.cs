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
    public class datTipotinte
    {
        private static readonly datTipotinte _instancia = new datTipotinte();

        public static datTipotinte Instancia
        {
            get
            {
                return datTipotinte._instancia;
            }
        }

        public List<entTipotinte> ListarTipoTinte()
        {
            SqlCommand cmd = null;
            List<entTipotinte> lista = new List<entTipotinte>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaTipoTinte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipotinte TiTi = new entTipotinte();
                    TiTi.nombre_tinte = dr["Nombre_tinte"].ToString();
                    TiTi.tipotinteID = Convert.ToInt32(dr["TipotinteID"]);
                    lista.Add(TiTi);
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
