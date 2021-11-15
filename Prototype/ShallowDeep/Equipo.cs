
namespace Prototype.ShallowDeep
{
    public class Equipo
    {
        public string Nombre { get; set; }

        public Equipo(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        public object CloneEquipo()
        {
            //Copia Shallow
            return this.MemberwiseClone();
        }
    }
}
