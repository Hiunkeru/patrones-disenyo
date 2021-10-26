using System;

namespace Singleton
{
    //Usamos sealed no es obligatorio, pero puede ser beneficioso si realiza modificaciones específicas en esta clase Singleton
    public sealed class Singleton2
    {
        //Esta seria otra forma de instaciar la clase, sin necesidad del constructor estatico si solo queremos devolver la clase sin inicializar valores
        private static readonly Singleton2 Instance = new Singleton2();


        //Se usa un constructor privado para evitar instacias usando new fuera de esta clase
        private Singleton2()
        {
            Console.WriteLine("Entrando en el constructor privado");
            Console.WriteLine("Saliendo del constructor privado");
            
        }

        public static Singleton2 GetInstance => Instance;

    }
}
