using System;

namespace Singleton
{
    class ProgramEjemplos
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Demostración del Patrón Singleton");

            //Si intentamos hacer un new no podemos gracias al constructor privado
            //Singleton singleton = new Singleton();
            Console.WriteLine($"El valor del número es: {Singleton.UnNumero}");

            var primeraInstacia = Singleton.GetInstance;
            var segundaInstacia = Singleton.GetInstance;

            if (primeraInstacia.Equals(segundaInstacia))
            {
                Console.WriteLine("Es la misma instacia");
                Console.WriteLine($"Id primera instacia = {primeraInstacia.Id} , Id segunda instacia = {segundaInstacia.Id}");
            }

            Console.Read();

            //Ejemplo uso de sealed (Ejemplo con Singleton3)
            Singleton3.ClaseDerivada claseDerivada = new Singleton3.ClaseDerivada();
            Singleton3.ClaseDerivada claseDerivada2 = new Singleton3.ClaseDerivada();

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
