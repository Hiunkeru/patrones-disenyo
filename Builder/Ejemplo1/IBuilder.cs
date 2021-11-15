
namespace Builder.Ejemplo1
{
    interface IBuilder
    {
        void ComenzarEnsamblado();
        void ConstruirEsqueleto();
        void AddRuedas();
        void AddFaros();
        void AcabarEmsamblado();
        Producto GetVehiculo();
    }
}
