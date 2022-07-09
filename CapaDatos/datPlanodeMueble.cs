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
    public class datPlanodeMueble
    {
        
        private static readonly datPlanodeMueble _instancia = new datPlanodeMueble();
        //privado para evitar la instanciación directa
        public static datPlanodeMueble Instancia
        {
            get
            {
                return datPlanodeMueble._instancia;
            }
        }

        ////////////////////lista pedido
        public int PlanoID()
        {
            SqlCommand cmd = null;
            int id;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spPlanoID", cn);//                                                      
                cmd.CommandType = CommandType.StoredProcedure;//
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                id = Convert.ToInt32(dr["PlanodemuebleID"]);
                id++;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return id;
        }

        //inserta pedido/
        public Boolean InsertarPlanodeMueble(entPlanodeMueble PlMu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPlanodeMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado_plano", PlMu.estado_plano);
                cmd.Parameters.AddWithValue("@Fecha_plano", PlMu.fecha_plano);
                cmd.Parameters.AddWithValue("@Foto", PlMu.foto);
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
