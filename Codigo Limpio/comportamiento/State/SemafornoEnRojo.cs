namespace Codigo_Limpio.State
{
    public class SemafornoEnRojo : IStado
    {
        public void Handle(EstadoContexto context)
        {
            Console.WriteLine("El semanforo esta en Rojo");
            context._estado = new SemafornoEnVerde();
        }
    }
}