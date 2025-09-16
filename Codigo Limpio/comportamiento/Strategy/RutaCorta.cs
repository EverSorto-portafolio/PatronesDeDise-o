using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Strategy
{
    public class RutaCorta : IcalcularRuta
    {
        public string CalculateRoute(string partida, string llegada)
        {
            return $"metodo ma cercano desde {partida} hasta {llegada}";
        }
    }
}
