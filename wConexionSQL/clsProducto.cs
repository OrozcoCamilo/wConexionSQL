using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace wConexionSQL
{
    class clsProducto
    {
        public int intCodigo { get; set; }
        public string strNombreProducto { get; set; }
        public int intPrecioUnitario { get; set; }
        public int intUnidadesStock { get; set; }

        //Constructor se utilizo para realizar simplemente una consulta y no requiere ningun
        //parametro para crear la instancia
        public clsProducto()
        {

        }

        //Utilizo el constructor para pasar los parametros y crear el objeto recibiendo los valores
        //de la interfaz gráfica de acuerdo alos valores recibidos desde donde se esta instanciando
        //el objeto
        public clsProducto(int intCodigo, string strNombreProducto, int intPrecioUnitario, int intUnidadesStock)
        {
            this.intCodigo = intCodigo;
            this.strNombreProducto = strNombreProducto;
            this.intPrecioUnitario = intPrecioUnitario;
            this.intUnidadesStock = intUnidadesStock;
        }

        public bool insertarDato()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-SRSV4V5\\SQLEXPRESS;database=dboTienda; integrated security=true");
            conexion.Open();
            string insertar = "insert into tblProducto values (@intCodigo, @strNombreProducto, @intPrecioUnitario, @intUnidadesStock)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCodigo", this.intCodigo);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@intPrecioUnitario", this.intPrecioUnitario);
            sql.Parameters.AddWithValue("@intUnidadesStock", this.intUnidadesStock);
            sql.ExecuteNonQuery();

            return true;
        }

        public DataTable consultarDato()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-SRSV4V5\\SQLEXPRESS;database=dboTienda; integrated security=true");
            conexion.Open();

            DataTable dt = new DataTable();
            string consulta = "select * from tblProducto";
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public bool eliminarDato(int intCodigo)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-SRSV4V5\\SQLEXPRESS;database=dboTienda; integrated security=true");
            conexion.Open();

            this.intCodigo = intCodigo;
            string eliminar = "delete tblProducto where intCodigo = @intCodigo";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intCodigo", this.intCodigo);
            sql.ExecuteNonQuery();

            return true;
        }
        public bool modificarDato()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-SRSV4V5\\SQLEXPRESS;database=dboTienda; integrated security=true");
            conexion.Open();
            string insertar = "update tblProducto set intCodigo = @intCodigo,strNombreProducto= @strNombreProducto,intPrecioUnitario = @intPrecioUnitario, intUnidadesStock = @intUnidadesStock WHERE intCodigo = @intCodigo";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCodigo", this.intCodigo);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@intPrecioUnitario", this.intPrecioUnitario);
            sql.Parameters.AddWithValue("@intUnidadesStock", this.intUnidadesStock);
            sql.ExecuteNonQuery();

            return true;
        }

        public DataTable seleccionarDato(int intCodigo)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-SRSV4V5\\SQLEXPRESS;database=dboTienda; integrated security=true");
            conexion.Open();

            this.intCodigo = intCodigo;
            DataTable dt = new DataTable();
            string seleccionar = "select * from tblProducto where intCodigo = @intCodigo";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCodigo", this.intCodigo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
