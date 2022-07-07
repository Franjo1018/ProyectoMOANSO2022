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
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPersonalProduccion _instancia = new datPersonalProduccion();
        //privado para evitar la instanciación directa
        public static datPersonalProduccion Instancia
        {
            get
            {
                return datPersonalProduccion._instancia;
            }
        }

        ////////////////////lista personal
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
                    Per.codigoPersonal = Convert.ToInt32(dr["codigoPersonal"]);
                    Per.puesto = dr["puesto"].ToString();
                    Per.tipoPersonal = dr["tipoPersonal"].ToString();
                    Per.nombre = dr["nombre"].ToString();
                    Per.fecRegIngreso = Convert.ToDateTime(dr["fecRegIngreso"]);

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
                cmd = new SqlCommand("spInsertarPersonalProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@puesto", Per.puesto);
                cmd.Parameters.AddWithValue("@tipoPersonal", Per.tipoPersonal);
                cmd.Parameters.AddWithValue("@nombre", Per.nombre);
                cmd.Parameters.AddWithValue("@fecRegIngreso", Per.fecRegIngreso);
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


        //edita Personal

        public Boolean EditarPersonalProduccion(entPersonalProduccion Per)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPersonalProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoPersonal", Per.codigoPersonal);
                cmd.Parameters.AddWithValue("@puesto", Per.puesto);
                cmd.Parameters.AddWithValue("@tipoPersonal", Per.tipoPersonal);
                cmd.Parameters.AddWithValue("@nombre", Per.nombre);
                cmd.Parameters.AddWithValue("@fecRegIngreso", Per.fecRegIngreso);
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
                cmd = new SqlCommand("spDeshabilitarPersonalProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoPersonal", Per.codigoPersonal);
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
