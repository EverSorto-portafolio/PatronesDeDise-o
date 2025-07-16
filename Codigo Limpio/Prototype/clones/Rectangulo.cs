using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Prototype.clones
{
    public class Rectangulo : ImplementPrototype
    {
        public Rectangulo(string name)
        {
            Name = name;
        }
        public override void dibujar()
        {
           Console.WriteLine("Dibujando un rectangulo con id: " + Id + " y nombre: " + Name);
        }
    }
}
