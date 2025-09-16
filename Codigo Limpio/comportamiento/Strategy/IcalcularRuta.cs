using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Strategy
{
    public interface IcalcularRuta
    {
        string CalculateRoute(string partida, string llegada);

    }
}
