using System;

namespace Singleton
{

    //Usamos sealed no es obligatorio, pero puede ser beneficioso si realiza modificaciones específicas en esta clase Singleton
    public sealed class Singleton1
    {
        private static Singleton1 Instance;

        //Se usa un constructor privado para evitar instacias usando new fuera de esta clase
        private Singleton1()
        {
            Console.WriteLine("Entrando en el constructor privado");
            Console.WriteLine("Saliendo del constructor privado");
        }

        //Esto pueder ser valido para entornos con un único hilo, pero en entornos multihilo puede crearnos nuevas instacias de la clase
        public static Singleton1 GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Singleton1();
                }

                return Instance;
            }
        }

    }
}

//Ver Singleton4 para ver como se soluciona este caso con multihilo