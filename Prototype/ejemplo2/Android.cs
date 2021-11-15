
namespace Prototype.ejemplo2
{
    internal class Android : Telefono
    {

        public Android(string modelo)
        {
            Modelo = modelo;
            precioBase = 200;
        }

        public override Telefono Clone()
        {
            return this.MemberwiseClone() as Android;
        }
    }
}
