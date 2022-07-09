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
    public class datDetallemueble
    {
        private static readonly datDetallemueble _instancia = new datDetallemueble();

        public static datDetallemueble Instancia
        {
            get
            {
                return datDetallemueble._instancia;
            }
        }

        public List<entDetallemueble> ListarDetalleMueble(int i)
        {
            SqlCommand cmd = null;
            List<entDetallemueble> lista = new List<entDetallemueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaDetalleMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetallemuebleID", i);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetallemueble DeMu = new entDetallemueble();              
                    DeMu.cantidad = Convert.ToInt32(dr["Cantidad"]);
                    DeMu.medidas = dr["Medidas"].ToString();
                    DeMu.detalleMuebleID = Convert.ToInt32(dr["DetallemuebleID"]);
                    DeMu.planodeMuebleID = Convert.ToInt32(dr["PlanodemuebleID"]);
                    DeMu.materialID = Convert.ToInt32(dr["MaterialID"]);
                    lista.Add(DeMu);
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

        public Boolean InsertarDetalleMueble(entDetallemueble DeMu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaDetalleMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cantidad", DeMu.cantidad);
                cmd.Parameters.AddWithValue("@Medidas", DeMu.medidas);
                cmd.Parameters.AddWithValue("@PlanodemuebleID", DeMu.planodeMuebleID);
                cmd.Parameters.AddWithValue("@MaterialID", DeMu.materialID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

    }
}
