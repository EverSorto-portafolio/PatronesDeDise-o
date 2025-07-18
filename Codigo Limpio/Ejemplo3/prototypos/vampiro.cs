using Codigo_Limpio.Ejemplo3.implementar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Ejemplo3.prototypos
{
    public class vampiro : Mounstruo
    {
        public override void atacar()
        {
            const string mensaje = "El vampiro ataca con colmillos afilados y sed de sangre.";
            Console.WriteLine(mensaje);
        }
    }
}
