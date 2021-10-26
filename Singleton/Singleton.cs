using System;

//Código de ejemplo usando un constructor estatico
namespace Singleton
{

    //Usamos sealed no es obligatorio, pero puede ser beneficioso si realiza modificaciones específicas en esta clase Singleton
    public sealed class Singleton
    {

        private static readonly Singleton Instance;
        private static int InstanciasTotales;
        public static int UnNumero = 8;
        public Guid Id;

        //Se usa un constructor privado para evitar instacias usando new fuera de esta clase
        private Singleton()
        {
            Console.WriteLine("Entrando en el constructor privado");
            Id = Guid.NewGuid();
            Console.WriteLine("Saliendo del constructor privado");
        }

        /*
         * Un constructor estatico se puede usar para:
         * 1 - Inicializar datos de forma estatica
         * 2- Para realizar una acción una unica vez
         *
         * El constructor estatico se llamará automaticamente antes de que crees la primera instacia o cuando referencias miembros estaticos en el código.
         */

        static Singleton()
        {
            Console.WriteLine("Entrando en el constructor estatico");
            Instance = new Singleton();
            InstanciasTotales++;
            Console.WriteLine($"Instacia de Singleton creada, numero de instacias {InstanciasTotales}");
            Console.WriteLine("Saliendo del constructor estatico");
        }

        public static Singleton GetInstance => Instance;

        public static Singleton GetInstance2
        {
            get
            {
                return Instance;
            }
        }
    }
}
