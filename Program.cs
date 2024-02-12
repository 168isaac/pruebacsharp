using BankApp.Models;

BebidaDb bebida = new BebidaDb();

//Insertando en la base de datos
Vino vinoObj = new Vino("Bebida tres", "Marca tres", 344);
vinoObj.Alcohol = 1212;

bebida.Add(vinoObj);

var vinos = bebida.GetAll();

foreach(var vino in vinos)
{
    Console.WriteLine(vino.Nombre);
}





//namespace BankApp;

//public class SingleSale : Sale, IInvoice, ICancel, ITax
//{

//    private decimal _iva;

//    public SingleSale(decimal total) : base(total)
//    {

//    }

//    decimal ITax.Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    void ICancel.Cancel()
//    {
//        throw new NotImplementedException();
//    }

//    void IInvoice.Check()
//    {
//        throw new NotImplementedException();
//    }
//}


//using System.Data.SqlClient;

//SqlConnectionStringBuilder sqlConnection = new();

//sqlConnection.DataSource = ".";
//sqlConnection.InitialCatalog = "db_prueba";

//Me conecto con la autenticacion integrada de window
//sqlConnection.IntegratedSecurity = true;

//var connection = sqlConnection.ConnectionString;

//using (SqlConnection conn = new SqlConnection(connection))
//{
//    conn.Open();

//    SqlCommand cmd = conn.CreateCommand();

//    cmd.CommandText = "SELECT * FROM products";

//    var reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine(reader.GetString(1));
//    }

//    reader.Close();
//}



