using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    class BebidaDb
    {

        private string connectionString = "Data Source=localhost;Initial Catalog=db_store;Integrated Security=true";

        public List<Vino> GetAll()
        {
            List<Vino> vinos = new List<Vino>();

            string query = "select * from bebida";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    string Nombre = reader.GetString(1);
                    string Marca = reader.GetString(2);

                    int Cantidad = reader.GetInt32(3);

                    Vino vino = new Vino(Nombre, Marca, Cantidad);
                    vinos.Add(vino);
                }

                reader.Close();
                connection.Close();

            }

            return vinos;
        }


        public void Add(Vino vino)
        {
            string query = "insert into bebida (id, nombre, marca, alcohol, cantidad) values(@id, @nombre, @marca, @alcohol, @cantidad)";

            using(var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", 3);
                command.Parameters.AddWithValue("@nombre", vino.Nombre);
                command.Parameters.AddWithValue("@marca", vino.Marca);
                command.Parameters.AddWithValue("@alcohol", vino.Alcohol);
                command.Parameters.AddWithValue("@cantidad", vino.Cantidad);

                connection.Open() ;

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
