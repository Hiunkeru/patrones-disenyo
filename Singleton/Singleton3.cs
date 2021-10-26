using System;

namespace Singleton
{
    //Ejemplo sin sellar la clase
    public  class Singleton3
    {
        //Esta seria otra forma de instaciar la clase, sin necesidad del constructor estatico si solo queremos devolver la clase sin inicializar valores
        private static readonly Singleton3 Instance = new Singleton3();
        private static int InstanciasTotales = 0;
        public static int UnNumero = 8;
        public Guid Id;

        

        //Se usa un constructor privado para evitar instacias usando new fuera de esta clase
        private Singleton3()
        {
            Console.WriteLine("Entrando en el constructor privado");
            Id = Guid.NewGuid();
            InstanciasTotales++;
            Console.WriteLine($"Instacias totales : {InstanciasTotales}");
            Console.WriteLine("Saliendo del constructor privado");
            
        }

        public static Singleton3 GetInstance => Instance;

        public class ClaseDerivada : Singleton3
        {

        }

    }
}
