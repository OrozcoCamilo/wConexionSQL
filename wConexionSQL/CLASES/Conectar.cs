using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace wConexionSQL.CLASES
{
    internal class Conectar
    {
        public static MySqlConnection CrearConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server= 127.0.0.1;database=MERCADO; uid=root; pwd=NO;");
            conexion.Open();
            return conexion;
        
        }
    }
}
