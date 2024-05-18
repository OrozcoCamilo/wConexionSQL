using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace wConexionSQL.CLASES
{
    public class clsPago
    {
        public int IdPago { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }

        private OleDbConnection connection;

        public clsPago()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new OleDbConnection(connectionString);
        }

        public void InsertarPago()
        {
            string query = "INSERT INTO Pagos (IdEmpleado, FechaPago, Monto) VALUES (@IdEmpleado, @FechaPago, @Monto)";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
                cmd.Parameters.AddWithValue("@Monto", Monto);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EliminarPago(int idPago)
        {
            string query = "DELETE FROM Pagos WHERE IdPago=@IdPago";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@IdPago", idPago);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable ObtenerPagos(int idEmpleado)
        {
            string query = "SELECT * FROM Pagos WHERE IdEmpleado=@IdEmpleado";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}