using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Mediator.ejercicio2
{
    public class AirPlane : AirCraft
    {
        public AirPlane(IAtraficControl atraficControl, string name) : base(atraficControl, name)
        {
        }
    }
}
