using Codigo_Limpio.Ejemplo3.implementar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Ejemplo3.prototypos
{
    public  class HombreLobo : Mounstruo
    {
       
        public override void atacar()
        {
            Console.WriteLine("En las noches de luna llena");
        }
    }
}
