using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio1
{
    public class Cafe : ICafe
    {
        public string GetDescription()
        {
            return "Café";
        }
        public double GetCost()
        {
            return 1.00;
        }
    }
}
