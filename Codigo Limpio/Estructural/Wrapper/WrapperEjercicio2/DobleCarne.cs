using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio2
{
    public class DobleCarne : ImplementacionHamburgesa
    {
        public DobleCarne(IBurger burger) : base(burger)
        {
        }

        override public double Costo()
        {
            return base.Costo() + 25;
        }
        override public string Descripcion()
        {
            return base.Descripcion() + ", Doble Carne";
        }

    }
}
