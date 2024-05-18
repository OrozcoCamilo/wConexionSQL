using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace wConexionSQL.CLASES
{
    public class clsEmpleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Salario { get; set; }

        private OleDbConnection connection;

        public clsEmpleado()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new OleDbConnection(connectionString);
        }

        public void InsertarEmpleado()
        {
            string query = "INSERT INTO Empleados (Nombre, Apellido, Salario) VALUES (@Nombre, @Apellido, @Salario)";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Salario", Salario);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void ActualizarEmpleado()
        {
            string query = "UPDATE Empleados SET Nombre=@Nombre, Apellido=@Apellido, Posicion=@Posicion, Salario=@Salario WHERE Id=@Id";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Salario", Salario);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EliminarEmpleado(int id)
        {
            string query = "DELETE FROM Empleados WHERE Id=@Id";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable ObtenerTodosEmpleados()
        {
            string query = "SELECT * FROM Empleados";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerEmpleadoPorId(int id)
        {
            string query = "SELECT * FROM Empleados WHERE Id=@Id";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@Id", id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}