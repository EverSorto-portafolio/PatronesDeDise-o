using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio2
{
    public class Queso : ImplementacionHamburgesa
    {
        public Queso(IBurger burger) : base(burger)
        {
        }

        override public double Costo()
        {
            return base.Costo() + 10;
        }
        public override string Descripcion()
        {
            return base.Descripcion() +", Queso";
        }

    }
}
