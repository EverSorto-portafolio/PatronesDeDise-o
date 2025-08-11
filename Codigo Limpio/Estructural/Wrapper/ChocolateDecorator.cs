using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Wrapper
{
    public class ChocolateDecorator : DecoradorCafe
    {
        public ChocolateDecorator(ICafe cafe) : base(cafe)
        {
        }
        public override string GetDescription()
        {
            return _cafe.GetDescription +", Chocolate";
        }
        public override double GetCost()
        {
            return _cafe.GetCost() + 0.50;
        }

    }
}
