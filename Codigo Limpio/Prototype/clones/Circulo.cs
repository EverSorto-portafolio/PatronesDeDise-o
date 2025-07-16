using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Prototype.clones
{
    public class Circulo : ImplementPrototype
    {
        public Circulo( string name)
        {
            Name = name;
        }
        public override void dibujar()  
        {
            Console.WriteLine("Dibujando un circulo con id: " + Id );
        }
    }
}
