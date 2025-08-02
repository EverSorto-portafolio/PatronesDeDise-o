using Codigo_Limpio.Estructural.Bridge.ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Bridge.ejercicio3.ImplementacionesMotor
{
    public class MotorElectrico : Motor
    {
        public void start()
        {
            Console.WriteLine("Motor electrico encendido");
        }
        public void stop()
        {
            Console.WriteLine("Motor electrico apagado");
        }

    }

}
