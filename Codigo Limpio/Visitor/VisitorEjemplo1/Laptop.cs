namespace Codigo_Limpio.Visitor.VisitorEjemplo1
{
    public class Laptop : IServiciosTienda
    {
        public void trabajo(Itrabajo trabajo)
        {
            trabajo.repararLaptop(this);
        }
    }
}