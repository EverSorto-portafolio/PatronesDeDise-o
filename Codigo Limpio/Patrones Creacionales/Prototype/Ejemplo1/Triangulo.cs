using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Prototype.Ejemplo1
{
    public class Triangulo : ImplementPrototype
    {
        public Triangulo(string name)
        {
            Name = name;
        }
        public override void dibujar()
        {
            Console.WriteLine("Dibujando un triangulo con id: " + Id + " y nombre: " + Name);
        }
    }
}
