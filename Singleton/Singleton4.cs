using System;

namespace Singleton
{

    //Usamos sealed no es obligatorio, pero puede ser beneficioso si realiza modificaciones específicas en esta clase Singleton
    public sealed class SingletonLazy
    {
        //Delegado
        delegate SingletonLazy SingletonDelegado();
        private static SingletonDelegado miDelegado = CrearSingleton;

        //Func
        private static Func<SingletonLazy> miFuncDelegate = CrearSingleton;

        private static readonly Lazy<SingletonLazy> Instance = new Lazy<SingletonLazy>(miDelegado());
        private static readonly Lazy<SingletonLazy> Instance2 = new Lazy<SingletonLazy>(miFuncDelegate());
        private static readonly Lazy<SingletonLazy> Instance3 = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {
        }

        private static SingletonLazy CrearSingleton()
        {
            return new SingletonLazy();
        }
        public static SingletonLazy GetInstance => Instance.Value;

    }
}

//Lazy<T> --> Iniciación diferida
//La inicialización diferida de un objeto implica que su creación se aplaza hasta que se usa por primera vez

//Una vez que se ha creado el objeto diferido, no se crea ninguna instancia de SingletonLazy mientras no se tenga acceso por primera vez a la propiedad Value de la variable Lazy

//Un objeto Lazy<T> siempre devuelve el mismo objeto o valor con el que se ha inicializado. Por lo tanto, la propiedad Value es de solo lectura

//De forma predeterminada, los objetos Lazy<T> son seguros para subprocesos. Es decir, si el constructor no especifica el tipo de seguridad para subprocesos,
//    En escenarios multiproceso, el primer subproceso que tiene acceso a la propiedad Value de un objeto Lazy<T>
//    lo inicializa para todos los accesos siguientes en todos los subprocesos, y todos los subprocesos comparten los mismos datos.
//    Por lo tanto, no importa qué subproceso inicializa el objeto y las condiciones de carrera son benignas.