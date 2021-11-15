namespace Prototype.ejemplo2
{
    internal class IPhone : Telefono
    {
        public IPhone(string modelo)
        {
            Modelo = modelo;
            precioBase = 700;
        }

        public override Telefono Clone()
        {
            return this.MemberwiseClone() as IPhone;
        }
    }
}
