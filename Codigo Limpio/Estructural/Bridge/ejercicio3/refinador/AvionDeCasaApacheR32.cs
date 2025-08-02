using Codigo_Limpio.Estructural.Bridge.ejercicio3;
using Codigo_Limpio.Estructural.Bridge.ejercicio3.claseAbstractaMotor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Bridge.ejercicio3.refinador
{
    class AvionDeCasaApacheR32 : UsoMotor
    {
        public AvionDeCasaApacheR32(Motor motor) : base(motor)
        {
        }
        public override void EstadoMotor()
        {
            _motor.start();
            _motor.stop();
        }
    }

}
