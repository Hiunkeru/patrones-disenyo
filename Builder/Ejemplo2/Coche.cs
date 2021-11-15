

namespace Builder.Ejemplo2
{
    internal class Coche : IBuilder
    {
        private string Marca;
        private Producto producto;

        public Coche(string marca)
        {
            producto = new Producto();
            Marca = marca;
        }


        public IBuilder AcabarEmsamblado2(string observacionesMontaje)
        {
            producto.Add($"ensamblado del coche finalizado con el siguiente comentario: {observacionesMontaje}");

            return this;
        }

        public IBuilder AddFaros2(int numeroFaros)
        {
            producto.Add($"Número de faros añadidos {numeroFaros}");

            return this;
        }

        public IBuilder AddRuedas2(int numeroRuedas)
        {
            producto.Add($"Número de ruedas añadidas {numeroRuedas}");

            return this;
        }

        public Producto BuildCoche2()
        {
            return producto;
        }

        public IBuilder ComenzarEnsamblado2(string lineaModelo)
        {
            producto.Add($"Comenzando el ensamblado del coche {Marca} - {lineaModelo}");

            return this;
        }

        public IBuilder ConstruirEsqueleto2(string tipoCarroceria)
        {
            producto.Add($"material del coche {tipoCarroceria}");

            return this;
        }
    }
}
