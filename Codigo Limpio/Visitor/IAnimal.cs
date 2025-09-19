using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor
{
    public interface IAnimal
    {
        public void Accept(IAnimalOperacion operacion);
    }
}
