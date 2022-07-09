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
    public class datCliente
    {
        private static readonly datCliente _instancia = new datCliente();

        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }

        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Clie = new entCliente();
                    Clie.apellidos_cliente = dr["Apellidos_cliente"].ToString();
                    Clie.nombres_cliente = dr["Nombre_cliente"].ToString();
                    Clie.clienteID = Convert.ToInt32(dr["ClienteID"]);
                    lista.Add(Clie);
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
