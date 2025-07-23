using Codigo_Limpio.Prototype.Ejemplo3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Prototype.Ejemplo3.implementar
{
    public abstract class Mounstruo : IClon
    {
        public int Id { get; set; }
        public abstract void atacar();
        public object clonar()
        {
            return MemberwiseClone();
        }
    }
}
