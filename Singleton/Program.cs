using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demostración del Patrón Singleton");

            var lazyInstancia1 = SingletonLazy.GetInstance;
            var lazyInstancia2 = SingletonLazy.GetInstance;

            if (lazyInstancia1.Equals(lazyInstancia2))
            {
                Console.WriteLine("Es la misma instacia");
            }

            Console.Read();
        }
    }
}
