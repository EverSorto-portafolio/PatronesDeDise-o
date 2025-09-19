using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor
{
    internal class EntrenarAnimal : IAnimalOperacion
    {
        public void VisitarLeon(Leon leon)
        {
            Console.WriteLine(" Entrenar al leon");
        }

        public void VisitarMono(Mono mono)
        {
            Console.WriteLine(" Entrenar al mono");
        }
    }
}
