using Prototype.ejemplo2;
using Prototype.ShallowDeep;
using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***Prototype Demo EJEMPLO 1***\n");

            //ejemplo1.Telefono android = new ejemplo1.Android("Xioami Poco F3");
            //ejemplo1.Telefono iphone = new ejemplo1.IPhone("Iphone 13");

            //ejemplo1.Telefono telefono;

            //// android
            //telefono = android.Clone();
            //android.precioBase = 300;

            //// Trabajamos sobre la copia
            //telefono.precioFinal = telefono.precioBase + ejemplo1.Telefono.SetPrecioSeguro();
            //Console.WriteLine($"Telefono: {telefono.Modelo}, Precio Base. {telefono.precioBase}");
            //Console.WriteLine($"Telefono android: {android.Modelo}, Precio Base. {android.precioBase}");

            //Console.WriteLine($"Telefono: {telefono.Modelo}, Precio. {telefono.precioFinal}");

            //// Iphone
            //telefono = iphone.Clone();

            //// Working on cloned copy
            //telefono.precioFinal = telefono.precioBase + ejemplo1.Telefono.SetPrecioSeguro();
            //Console.WriteLine($"Telefono: {telefono.Modelo}, Precio. {telefono.precioFinal}");

            //Console.ReadLine();


            //Console.WriteLine("***Prototype Demo EJEMPLO 2***\n");
            //TelefonoFactory telefonoFactory = new TelefonoFactory();
            //ejemplo2.Telefono telefonoAndroid = telefonoFactory.GetAndroid();

            //telefonoAndroid.precioFinal = telefonoAndroid.precioBase + ejemplo2.Telefono.SetPrecioSeguro();
            //Console.WriteLine($"Telefono: {telefonoAndroid.Modelo}, Precio. {telefonoAndroid.precioFinal}");

            //ejemplo2.Telefono telefonoIphone = telefonoFactory.GetIphone();

            //telefonoIphone.precioFinal = telefonoIphone.precioBase + ejemplo2.Telefono.SetPrecioSeguro();
            //Console.WriteLine($"Telefono: {telefonoIphone.Modelo}, Precio. {telefonoIphone.precioFinal}");


            //Console.ReadLine();


            Console.WriteLine("***Prototype Demo Shallow & Deep ***\n");
            Equipo equipo = new Equipo("Real Madrid");
            Jugador jugador = new Jugador(9, "Karim Bencema", equipo);

            Console.WriteLine($"Los datos del jugador son:");
            Console.WriteLine(jugador);

            Console.WriteLine($"Hacemos un clon del jugador");
            Jugador jugadorClonado = (Jugador)jugador.Clone();

            Console.WriteLine($"El jugador clonado tiene los siguientes datos");
            Console.WriteLine(jugadorClonado);

            Console.WriteLine($"Cambiamos los datos del jugador clonado");
            jugadorClonado.Id = 10;
            jugadorClonado.Nombre = "Luka Modric";
            jugadorClonado.Equipo.Nombre = "Barcelona";


            Console.WriteLine($"datos del jugador original:");
            Console.WriteLine(jugador);

            Console.WriteLine($"datos del jugdor clonado despues de los cambios:");
            Console.WriteLine(jugadorClonado);

            Console.ReadLine();

            Console.WriteLine($"Ahora usamos Deep Copy");
            Equipo equipoDeep = new Equipo("Real Madrid");
            Jugador jugadorDeep = new Jugador(9, "Karim Bencema", equipoDeep);

            Console.WriteLine($"Los datos del jugador son;");
            Console.WriteLine(jugadorDeep);
            Console.WriteLine($"Hacemos un clon del jugador");
            Jugador jugadorClonadoDeep = (Jugador)jugadorDeep.CloneDeep();


            Console.WriteLine($"Cambiamos los datos del jugador");
            jugadorClonadoDeep.Id = 10;
            jugadorClonadoDeep.Nombre = "Luka Modric";
            jugadorClonadoDeep.Equipo.Nombre = "Barcelona";

            Console.WriteLine($"El jugador 1 tiene los siguientes datos");
            Console.WriteLine(jugadorDeep);

            Console.WriteLine($"y El jugador clonado:");
            Console.WriteLine(jugadorClonadoDeep);

            Console.ReadLine();
            



        }
    }
}
