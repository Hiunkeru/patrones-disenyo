using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ejemplo1
{
    internal class Coche : IBuilder
    {
        private string Marca;
        private Producto producto;

        public Coche(string marca)
        {
            producto = new Producto();
            Marca = marca;
        }

        public void AcabarEmsamblado()
        {
            Console.WriteLine($"Acabado el ensamblado de {Marca}");
            Console.WriteLine("****************  Coche terminado *************************");
        }

        public void AddFaros()
        {
            Console.WriteLine("Faros añadidos");
        }

        public void AddRuedas()
        {
            Console.WriteLine("4 ruedas añadidas");
        }

        public void ComenzarEnsamblado()
        {
            Console.WriteLine("Empenzando a ensamblar el coche");
        }

        public void ConstruirEsqueleto()
        {
            Console.WriteLine("Construyendo el esqueleto del coche");
        }

        public Producto GetVehiculo()
        {
            return producto;
        }
    }
}
