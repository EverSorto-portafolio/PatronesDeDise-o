using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Strategy.EjercicioStrategy
{
    internal class TrnasporteAutomovil : Itransporte
    {
        public string metodoDeTRansporte(float pasaje)
        {
            return $" inicilizando el pedido de uber por {pasaje}";
        }
    }
}
