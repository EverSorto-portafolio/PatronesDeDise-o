using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio2
{
    public class Hamburgesa : IBurger
    {
        public double Costo()
        {
            return 5.00;
        }

        public string Descripcion()
        {
            return "Hamburguesa con pan, carne, lechuga";
        }
    }
}
