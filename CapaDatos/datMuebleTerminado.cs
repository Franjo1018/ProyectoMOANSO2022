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
    public class datMuebleTerminado
    {
        ////Patron Singleton
        //// Variable estática para la instancia
        //private static readonly datMuebleTerminado _instancia = new datMuebleTerminado();
        ////privado para evitar la instanciación directa
        //public static datMuebleTerminado Instancia
        //{
        //    get
        //    {
        //        return datMuebleTerminado._instancia;
        //    }
        //}

        ////////////////////lista muebles terminados
        //public List<entMuebleTerminado> ListarMuebleTerminado()
        //{
        //    SqlCommand cmd = null;
        //    List<entMuebleTerminado> lista = new List<entMuebleTerminado>();
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
        //        cmd = new SqlCommand("spListaMuebleTerminado", cn);//                                                      
        //        cmd.CommandType = CommandType.StoredProcedure;//
        //        cn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            entMuebleTerminado Mue = new entMuebleTerminado();
        //            Mue.MuebleID = Convert.ToInt32(dr["MuebleID"]);
        //            Mue.Color_tinte = dr["Color_tinte"].ToString();
        //            Mue.Descripcion = dr["Descripcion"].ToString();
        //            Mue.OrdendeproduccionID = Convert.ToInt32(dr["MuebleID"]);
        //            Mue.PlanodemuebleID = Convert.ToInt32(dr["MuebleID"]);
        //            Mue.TipotinteID = Convert.ToInt32(dr["MuebleID"]);

        //            lista.Add(Mue);
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        cmd.Connection.Close();
        //    }
        //    return lista;
        //}

        //////inserta mueble
        //public Boolean InsertarMuebleTerminado(entMuebleTerminado Mue)
        //{
        //    SqlCommand cmd = null;
        //    Boolean inserta = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spInsertarMuebleTerminado", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Color_tinte", Mue.Color_tinte);
        //        cmd.Parameters.AddWithValue("@Descripcion", Mue.Descripcion);
        //        cmd.Parameters.AddWithValue("@OrdendeproduccionID", Mue.OrdendeproduccionID);
        //        cmd.Parameters.AddWithValue("@PlanodemuebleID", Mue.PlanodemuebleID);
        //        cmd.Parameters.AddWithValue("@TipotinteID", Mue.TipotinteID);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            inserta = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return inserta;
        //}


        //////edita Mueble

        //public Boolean EditarMuebleTerminado(entMuebleTerminado Mue)
        //{
        //    SqlCommand cmd = null;
        //    Boolean edita = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spEditarMuebleTerminado", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Color_tinte", Mue.Color_tinte);
        //        cmd.Parameters.AddWithValue("@Descripcion", Mue.Descripcion);
        //        cmd.Parameters.AddWithValue("@OrdendeproduccionID", Mue.OrdendeproduccionID);
        //        cmd.Parameters.AddWithValue("@PlanodemuebleID", Mue.PlanodemuebleID);
        //        cmd.Parameters.AddWithValue("@TipotinteID", Mue.TipotinteID);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            edita = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return edita;
        //}

        //////deshabilita mueble

        //public Boolean DeshabilitarMuebleTerminado(entMuebleTerminado Mue)
        //{
        //    SqlCommand cmd = null;
        //    Boolean delete = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spDeshabilitarMuebleTerminado", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@MuebleID", Mue.MuebleID);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            delete = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return delete;
        //}
    }
}
