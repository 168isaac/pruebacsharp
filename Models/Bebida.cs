using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    internal class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }

        public Bebida(string Nombre, string Marca, int Cantidad) { this.Nombre = Nombre; this.Marca = Marca; this.Cantidad = Cantidad; }
    }
}
