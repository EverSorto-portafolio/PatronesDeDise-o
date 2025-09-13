namespace Codigo_Limpio.State
{
    public class SemafornoEnAmarillo : IStado
    {
        public void Handle(EstadoContexto context)
        {
            Console.WriteLine("El semanforo esta en amarillo");
            context._estado = new SemafornoEnRojo();
        }
    }
}