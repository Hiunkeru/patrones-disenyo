
namespace Builder.Ejemplo2
{
    interface IBuilder
    {
        IBuilder ComenzarEnsamblado2(string lineaModelo);
        IBuilder ConstruirEsqueleto2(string tipoCarroceria);
        IBuilder AddRuedas2(int numeroRuedas);
        IBuilder AddFaros2(int numeroFaros);
        IBuilder AcabarEmsamblado2(string observacionesMontaje);
        Producto BuildCoche2();
    }
}
