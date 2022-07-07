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
    public class datProcesoMantenimiento
    {
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProcesoMantenimiento _instancia = new datProcesoMantenimiento();
        //privado para evitar la instanciación directa
        public static datProcesoMantenimiento Instancia
        {
            get
            {
                return datProcesoMantenimiento._instancia;
            }
        }

        ////////////////////lista procesos de mantenimiento
        public List<entProcesoMantenimiento> ListarProcesoMantenimiento()
        {
            SqlCommand cmd = null;
            List<entProcesoMantenimiento> lista = new List<entProcesoMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProcesoMantenimiento", cn);//                                                      
                cmd.CommandType = CommandType.StoredProcedure;//
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProcesoMantenimiento Pro = new entProcesoMantenimiento();
                    Pro.codigoProceso = Convert.ToInt32(dr["codigoProceso"]);
                    Pro.procedimiento = dr["procedimiento"].ToString();
                    Pro.duracion = dr["duracion"].ToString();
                    Pro.tipoProceso = dr["tipoProceso"].ToString();
                    Pro.descripcion = dr["descripcion"].ToString();
                    Pro.fecRegProceso = Convert.ToDateTime(dr["fecRegProceso"]);

                    lista.Add(Pro);
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

        //inserta proceso de mantenimiento
        public Boolean InsertarProcesoMantenimiento(entProcesoMantenimiento Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProcesoMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@procedimiento", Pro.procedimiento);
                cmd.Parameters.AddWithValue("@duracion", Pro.duracion);
                cmd.Parameters.AddWithValue("@tipoProceso", Pro.tipoProceso);
                cmd.Parameters.AddWithValue("@descripcion", Pro.descripcion);
                cmd.Parameters.AddWithValue("@fecRegProceso", Pro.fecRegProceso);
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


        //edita proceso

        public Boolean EditarProcesoMantenimiento(entProcesoMantenimiento Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProcesoMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoProceso", Pro.codigoProceso);
                cmd.Parameters.AddWithValue("@procedimiento", Pro.procedimiento);
                cmd.Parameters.AddWithValue("@duracion", Pro.duracion);
                cmd.Parameters.AddWithValue("@tipoProceso", Pro.tipoProceso);
                cmd.Parameters.AddWithValue("@descripcion", Pro.descripcion);
                cmd.Parameters.AddWithValue("@fecRegProceso", Pro.fecRegProceso);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilita proceso

        public Boolean DeshabilitarProcesoMantenimiento(entProcesoMantenimiento Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProcesoMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoProceso", Pro.codigoProceso);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
    }
}
