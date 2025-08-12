using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio1
{
    public class Crema : DecoradorCafe
    {
        public Crema(ICafe cafe) : base(cafe)
        {
        }

        public override string GetDescription()
        {
            return _cafe.GetDescription() + ", Crema";
        }

        public override double GetCost()
        {
            return _cafe.GetCost() + 0.30;
        }
    }
}
