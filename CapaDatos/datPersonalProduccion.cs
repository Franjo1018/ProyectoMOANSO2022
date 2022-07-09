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
    public class datPersonalProduccion
    {

        private static readonly datPersonalProduccion _instancia = new datPersonalProduccion();
        
        public static datPersonalProduccion Instancia
        {
            get
            {
                return datPersonalProduccion._instancia;
            }
        }

        //////////////////lista personal
        public List<entPersonalProduccion> ListarPersonalProduccion()
        {
            SqlCommand cmd = null;
            List<entPersonalProduccion> lista = new List<entPersonalProduccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPersonalProduccion", cn);//                                                      
                cmd.CommandType = CommandType.StoredProcedure;//
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPersonalProduccion Per = new entPersonalProduccion();
                    Per.apellidos_personal = dr["Apellidos_personal"].ToString();
                    Per.estado_personal = dr["Estado_personal"].ToString();
                    Per.nombres_personal = dr["Nombres_personal"].ToString();
                    Per.personalID = Convert.ToInt32(dr["PersonalproduccionID"]);
                    Per.areaID = Convert.ToInt32(dr["AreaID"]);
                    Per.tipoPersonalID = Convert.ToInt32(dr["TipoPersonalID"]);

                    lista.Add(Per);
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

        //inserta Personal
        public Boolean InsertarPersonalProduccion(entPersonalProduccion Per)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPersonalProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Apellidos_personal", Per.apellidos_personal);
                cmd.Parameters.AddWithValue("@Estado_personal", Per.estado_personal);
                cmd.Parameters.AddWithValue("@Nombres_personal", Per.nombres_personal);
                cmd.Parameters.AddWithValue("@AreaID", Per.areaID);
                cmd.Parameters.AddWithValue("@TipoPersonalID", Per.tipoPersonalID);
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


        ////edita Personal

        public Boolean EditarPersonalProduccion(entPersonalProduccion Per)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPersonalProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Apellidos_personal", Per.apellidos_personal);
                cmd.Parameters.AddWithValue("@Estado_personal", Per.estado_personal);
                cmd.Parameters.AddWithValue("@Nombres_personal", Per.nombres_personal);
                cmd.Parameters.AddWithValue("@PersonalproduccionID", Per.personalID);
                cmd.Parameters.AddWithValue("@AreaID", Per.areaID);
                cmd.Parameters.AddWithValue("@TipoPersonalID", Per.tipoPersonalID);
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

        //deshabilita Personal

        public Boolean DeshabilitarPersonalProduccion(entPersonalProduccion Per)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaPersonalProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonalproduccionID", Per.personalID);
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
