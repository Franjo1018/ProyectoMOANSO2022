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
    public class datMaterial
    {
        private static readonly datMaterial _instancia = new datMaterial();

        public static datMaterial Instancia
        {
            get
            {
                return datMaterial._instancia;
            }
        }

        public List<entMaterial> ListarMaterial()
        {
            SqlCommand cmd = null;
            List<entMaterial> lista = new List<entMaterial>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMaterial Ma = new entMaterial();
                    Ma.nombre_material = dr["Nombre_material"].ToString();
                    Ma.stock = Convert.ToInt32(dr["Stock"]);
                    Ma.materialID = Convert.ToInt32(dr["MaterialID"]);
                    lista.Add(Ma);
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
