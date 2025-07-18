using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Ejemplo3.implementar
{
    public abstract class Mounstruo : IClon
    {
        public int Id { get; set; }
        public abstract void atacar();
        public object clonar()
        {
           return this.MemberwiseClone();
        }
    }
}
