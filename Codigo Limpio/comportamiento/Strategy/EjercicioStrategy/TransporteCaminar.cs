using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Strategy.EjercicioStrategy
{
    public class TransporteCaminar : Itransporte
    {
        public string metodoDeTRansporte(float pasaje)
        {
            return $" Comprare una bolsa de agua y una charamusca por {pasaje}";
        }
    }
}
