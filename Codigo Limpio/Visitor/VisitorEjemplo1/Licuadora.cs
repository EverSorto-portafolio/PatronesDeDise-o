namespace Codigo_Limpio.Visitor.VisitorEjemplo1
{
    public class Licuadora : IServiciosTienda
    {
        public void trabajo(Itrabajo trabajo)
        {
            trabajo.repararLicuadora(this);
        }
    }
}