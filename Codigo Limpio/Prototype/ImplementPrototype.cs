using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Prototype
{
    public abstract class ImplementPrototype : Protopyte
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void dibujar();

        public object clone()
        {
           return this.MemberwiseClone();
        }
    }
}
