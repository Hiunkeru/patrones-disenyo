
namespace Builder.Ejemplo1
{
    internal class Director
    {
        private IBuilder _builder;

        public void Build(IBuilder builder)
        {
            _builder = builder;

            _builder.ComenzarEnsamblado();
            _builder.ConstruirEsqueleto();
            _builder.AddRuedas();
            _builder.AddFaros();
            _builder.AcabarEmsamblado();
        }
    }
}
