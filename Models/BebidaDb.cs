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

                    int Cantidad = reader.GetInt32(3);

                    Vino vino = new Vino(Nombre, Cantidad);
                    vinos.Add(vino);
                }

                reader.Close();
                connection.Close();

            }

            return vinos;
        }
    }
}
