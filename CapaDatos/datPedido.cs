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
    public class datPedido
    {
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPedido _instancia = new datPedido();
        //privado para evitar la instanciación directa
        public static datPedido Instancia
        {
            get
            {
                return datPedido._instancia;
            }
        }

        ////////////////////lista pedido
        public List<entPedido> ListarPedido()
        {
            SqlCommand cmd = null;
            List<entPedido> lista = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPedido", cn);//                                                      
                cmd.CommandType = CommandType.StoredProcedure;//
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Ped = new entPedido();
                    Ped.codigoPedido = Convert.ToInt32(dr["codigoPedido"]);
                    Ped.tipoPedido = dr["tipoPedido"].ToString();
                    Ped.nombrecliente = dr["nombreCliente"].ToString();
                    Ped.descripcion = dr["descripcion"].ToString();
                    Ped.fecRegInicio = Convert.ToDateTime(dr["fecRegInicio"]);
                    Ped.fecRegTermino = Convert.ToDateTime(dr["fecRegTermino"]);

                    lista.Add(Ped);
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

        //inserta pedido
        public Boolean InsertarPedido(entPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoPedido", Ped.tipoPedido);
                cmd.Parameters.AddWithValue("@nombreCliente", Ped.nombrecliente);
                cmd.Parameters.AddWithValue("@descripcion", Ped.descripcion);
                cmd.Parameters.AddWithValue("@fecRegInicio", Ped.fecRegInicio);
                cmd.Parameters.AddWithValue("@fecRegTermino", Ped.fecRegTermino);
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


        //edita Pedble

        public Boolean EditarPedido(entPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoPedido", Ped.codigoPedido);
                cmd.Parameters.AddWithValue("@tipoPedido", Ped.tipoPedido);
                cmd.Parameters.AddWithValue("@nombreCliente", Ped.nombrecliente);
                cmd.Parameters.AddWithValue("@descripcion", Ped.descripcion);
                cmd.Parameters.AddWithValue("@fecRegInicio", Ped.fecRegInicio);
                cmd.Parameters.AddWithValue("@fecRegTermino", Ped.fecRegTermino);
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

        //deshabilita Pedido

        public Boolean DeshabilitarPedido(entPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoPedido", Ped.codigoPedido);
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
