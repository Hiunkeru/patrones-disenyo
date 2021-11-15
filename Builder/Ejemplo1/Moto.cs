using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ejemplo1
{
    internal class Moto : IBuilder
    {
        private string Marca;
        private Producto producto;

        public Moto(string marca)
        {
            producto = new Producto();
            Marca = marca;
        }

        public void AcabarEmsamblado()
        {
            Console.WriteLine($"Acabado el ensamblado de {Marca}");
            Console.WriteLine("****************  Moto terminada *************************");
        }

        public void AddFaros()
        {
            Console.WriteLine("1 Faro añadidos");
        }

        public void AddRuedas()
        {
            Console.WriteLine("2 ruedas añadidas");
        }

        public void ComenzarEnsamblado()
        {
            Console.WriteLine("Empenzando a ensamblar la moto");
        }

        public void ConstruirEsqueleto()
        {
            Console.WriteLine("Construyendo el esqueleto de la moto");
        }

        public Producto GetVehiculo()
        {
            return producto;
        }
    }
}
