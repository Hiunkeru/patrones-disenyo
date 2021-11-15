using System;

namespace Prototype.ejemplo1
{
    internal abstract class Telefono
    {
        public int precioBase = 0, precioFinal = 0; 
        public string Modelo { get; set; }


        public static int SetPrecioSeguro()
        {
            Random random = new Random();
            int precioSeguro = random.Next(50, 100); 
            return precioSeguro;
        }
        public abstract Telefono Clone();

    }
}
