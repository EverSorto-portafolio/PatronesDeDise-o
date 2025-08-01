using Codigo_Limpio.Bridge.ejercicio2.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Bridge.ejercicio2.Implementador
{
    internal class TeslaR3 : TipoAutomovil
    {
        public TeslaR3(IAuto auto) : base(auto)
        {
        }

        public override void EstadoAuto()
        {
            _auto.Encender();
            _auto.Acelerar();
            _auto.Frenar();
            _auto.Apagar();
            MostrarTipo();
        }
    }
}
