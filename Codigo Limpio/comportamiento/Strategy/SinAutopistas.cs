using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Strategy
{
    public class SinAutopistas : IcalcularRuta
    {
        public string CalculateRoute(string partida, string llegada)
        {
            return $"metodo sin autopistas desde {partida} hasta {llegada}";
        }
    }
}
