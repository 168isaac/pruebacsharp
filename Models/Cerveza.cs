using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public Cerveza(string Nombre,string Marca, int Cantidad) : base(Nombre, Marca, Cantidad)
        {

        }

        public int Alcohol {  get; set; }


        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido es 30");
        }
    }
}
