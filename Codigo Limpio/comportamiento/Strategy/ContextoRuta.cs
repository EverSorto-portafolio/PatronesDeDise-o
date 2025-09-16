using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Strategy
{
    public class ContextoRuta
    {
        private IcalcularRuta _ruta;
        public ContextoRuta(IcalcularRuta ruta)
        {
            _ruta = ruta;
        }



        public void SetContext(IcalcularRuta ruta)
        {
            _ruta = ruta;
        }

        public string ExecutarStrategy(string salida, string llegada) { 
            return _ruta.CalculateRoute(salida, llegada);
        }

    }
}
