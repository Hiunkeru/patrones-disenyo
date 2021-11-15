using System;
using System.Collections.Generic;

namespace Builder.Ejemplo2
{
    internal sealed class Producto
    {
        List<string> partes;

        public Producto()
        {
            partes = new List<string>();
        }

        public void Add(string parte)
        {
            partes.Add(parte);
        }

        public void Mostrar()
        {
            Console.WriteLine("Partes del vehiculo");
            foreach (var parte in partes)
            {
                Console.WriteLine(parte);
            }
        }
    }
}