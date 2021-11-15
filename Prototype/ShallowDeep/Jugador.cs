
namespace Prototype.ShallowDeep
{
    internal class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Equipo Equipo { get; set; }

        public Jugador(int id, string nombre, Equipo equipo)
        {
            Id = id;
            Nombre = nombre;
            Equipo = equipo;
        }

        public override string ToString()
        {
            return string.Format($"El jugador: {Nombre} es del equipo {Equipo}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object CloneDeep()
        {
            Jugador jugador = (Jugador)MemberwiseClone();
            jugador.Equipo = (Equipo)this.Equipo.CloneEquipo();

            return jugador;
        }
    }
}
