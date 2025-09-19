using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor
{
    public class AnimalRevison : IAnimalOperacion
    {
        public void VisitarLeon(Leon leon)
        {
            Console.WriteLine("Aqui va la logica de la revison medica del Leon");
        }

        public void VisitarMono(Mono mono)
        {
            Console.WriteLine("Aqui va la logica de la revison medica del Mono");
        }
    }
}
