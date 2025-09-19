namespace Codigo_Limpio.Visitor.VisitorEjemplo1
{
    public class Celular : IServiciosTienda
    {
        public void trabajo(Itrabajo trabajo)
        {
            trabajo.repararCelular(this);
        }
    }
}