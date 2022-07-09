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
                    Ped.cantidad = Convert.ToInt32(dr["Cantidad"]);
                    Ped.descripcion = dr["Descripcion"].ToString();
                    Ped.estado_pedido = Convert.ToInt32(dr["Estado_pedido"]);
                    Ped.fecRegPedido = Convert.ToDateTime(dr["Fecha_pedido"]);
                    Ped.fecRegSolicitada = Convert.ToDateTime(dr["Fecha_solicitada"]);
                    Ped.pedidoID = Convert.ToInt32(dr["PedidoID"]);
                    Ped.clienteID = Convert.ToInt32(dr["ClienteID"]);
                    Ped.tipoPedidoID= Convert.ToInt32(dr["TipopedidoID"]);

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

        //inserta pedido/
        public Boolean InsertarPedido(entPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cantidad", Ped.cantidad);
                cmd.Parameters.AddWithValue("@Descripcion", Ped.descripcion);
                cmd.Parameters.AddWithValue("@Estado_pedido", Ped.estado_pedido);
                cmd.Parameters.AddWithValue("@Fecha_pedido", Ped.fecRegPedido);
                cmd.Parameters.AddWithValue("@Fecha_solicitada", Ped.fecRegSolicitada);
                cmd.Parameters.AddWithValue("@ClienteID", Ped.clienteID);
                cmd.Parameters.AddWithValue("@TipopedidoID", Ped.tipoPedidoID);
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


        ////edita Pedble

        public Boolean EditaPedido(entPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cantidad", Ped.cantidad);
                cmd.Parameters.AddWithValue("@Descripcion", Ped.descripcion);
                cmd.Parameters.AddWithValue("@Estado_pedido", Ped.estado_pedido);
                cmd.Parameters.AddWithValue("@Fecha_pedido", Ped.fecRegPedido);
                cmd.Parameters.AddWithValue("@Fecha_solicitada", Ped.fecRegSolicitada);
                cmd.Parameters.AddWithValue("PedidoID", Ped.pedidoID);
                cmd.Parameters.AddWithValue("@ClienteID", Ped.clienteID);
                cmd.Parameters.AddWithValue("@TipopedidoID", Ped.tipoPedidoID);
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
                cmd.Parameters.AddWithValue("@PedidoID", Ped.pedidoID);
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
