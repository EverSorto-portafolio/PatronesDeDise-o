using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State
{
    public class SemafornoEnVerde : IStado
    {
        public void Handle(EstadoContexto context)
        {
            Console.WriteLine("El semaforo esta en verde");
            context._estado = new SemafornoEnAmarillo();
        }
    }
}
