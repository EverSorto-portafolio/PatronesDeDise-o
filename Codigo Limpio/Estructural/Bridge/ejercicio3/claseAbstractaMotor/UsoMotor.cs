using Codigo_Limpio.Estructural.Bridge.ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Bridge.ejercicio3.claseAbstractaMotor
{
    public abstract class UsoMotor
    {
        protected Motor _motor;
        public UsoMotor(Motor motor)
        {
            _motor = motor;
        }

        public abstract void EstadoMotor();
    }
}
