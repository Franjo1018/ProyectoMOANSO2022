using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Conexion _instancia = new Conexion();
        //privado para evitar la instanciación directa
        public static Conexion Instancia
        {
            get
            {
                return Conexion._instancia;
            }
        }


        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source=DESKTOP-CVMHKR2; Initial Catalog = MOANSO-2022; Integrated Security = True";
            cn.ConnectionString = "Data Source=DESKTOP-RC7PIKP; Initial Catalog = MOANSO-2022; Integrated Security = True";
            return cn;
        }
    }
}
