using Builder.Ejemplo1;
using Builder.Ejemplo2;
using System;


namespace Builder
{
    internal class Program
    {
        //Para el ejemplo2
        static Ejemplo2.Producto cocheEjemplo2;

        static void Main(string[] args)
        {
            //Console.WriteLine("************  Demo Patron Builder **************** ");
            //var director = new Director();

            //Ejemplo1.IBuilder coche = new Ejemplo1.Coche("Seat León");
            //Ejemplo1.IBuilder moto = new Moto("Honda CBR");

            //director.Build(coche);

            //Ejemplo1.Producto producto1 = coche.GetVehiculo();
            //producto1.Mostrar();

            //director.Build(moto);
            //Ejemplo1.Producto producto2 = moto.GetVehiculo();
            //producto2.Mostrar();

            //Console.ReadLine();


            //Ejemplo 2

            cocheEjemplo2 = new Ejemplo2.Coche("Seat")
                .ComenzarEnsamblado2("Panda")
                .ConstruirEsqueleto2("aluminio")
                .AddFaros2(2)
                .AddRuedas2(4)
                .AcabarEmsamblado2("Todo OK")
                .BuildCoche2();

            cocheEjemplo2.Mostrar();

            cocheEjemplo2 = new Ejemplo2.Coche("Skoda")
                .ComenzarEnsamblado2("Family")
                .ConstruirEsqueleto2("aluminio")
                .AddFaros2(4)
                .AddRuedas2(6)
                .AcabarEmsamblado2("KO en electricidad")
                .BuildCoche2();

            cocheEjemplo2.Mostrar();

        }
    }
}
