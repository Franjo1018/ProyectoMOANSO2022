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
    public class datProcesoProduccion
    {
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProcesoProduccion _instancia = new datProcesoProduccion();
        //privado para evitar la instanciación directa
        public static datProcesoProduccion Instancia
        {
            get
            {
                return datProcesoProduccion._instancia;
            }
        }

        //////////////////lista procesos de mantenimiento
        public List<entProcesoProduccion> ListarProcesoProduccion()
        {
            SqlCommand cmd = null;
            List<entProcesoProduccion> lista = new List<entProcesoProduccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProcesoProduccion", cn);//                                                      
                cmd.CommandType = CommandType.StoredProcedure;//
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProcesoProduccion PrPr = new entProcesoProduccion();
                    PrPr.descripcion = dr["Descripcion"].ToString();
                    PrPr.duracion = Convert.ToInt32(dr["Duracion"]);
                    PrPr.nombre_proceso = dr["Nombre_proceso"].ToString();
                    PrPr.ProcesoProduccionID = Convert.ToInt32(dr["ProcesoproduccionID"]);
                    PrPr.areaID = Convert.ToInt32(dr["AreaID"]);
                    PrPr.tipoProcesoID = Convert.ToInt32(dr["TipoprocesoID"]);

                    lista.Add(PrPr);
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
        public Boolean InsertarProcesoProduccion(entProcesoProduccion PrPr)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", PrPr.descripcion);
                cmd.Parameters.AddWithValue("@Duracion", PrPr.duracion);
                cmd.Parameters.AddWithValue("@Nombre_proceso", PrPr.nombre_proceso);
                cmd.Parameters.AddWithValue("@AreaID", PrPr.areaID);
                cmd.Parameters.AddWithValue("@TipoprocesoID", PrPr.tipoProcesoID);
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

        public Boolean EditarProcesoProduccion(entProcesoProduccion PrPr)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProcesoMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", PrPr.descripcion);
                cmd.Parameters.AddWithValue("@Duracion", PrPr.duracion);
                cmd.Parameters.AddWithValue("@Nombre_proceso", PrPr.nombre_proceso);
                cmd.Parameters.AddWithValue("@ProcesoproduccionID", PrPr.ProcesoProduccionID);
                cmd.Parameters.AddWithValue("@AreaID", PrPr.areaID);
                cmd.Parameters.AddWithValue("@TipoprocesoID", PrPr.tipoProcesoID);
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


    }
}
