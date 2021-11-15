using System;

namespace Prototype.ejemplo0
{
    internal abstract class Telefono : ICloneable
    {
        public int precioBase = 0, precioFinal = 0; 
        public string Modelo { get; set; }

        public static int SetPrecioSeguro()
        {
            Random random = new Random();
            int precioSeguro = random.Next(50, 100); 
            return precioSeguro;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
