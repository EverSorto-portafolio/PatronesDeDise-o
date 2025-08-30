using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Mediator.NewFolder
{
    public  class AirBus
    {
        private IAeroPuerto _aeropuerto;

        public AirBus()
        {
        }

        public void OperacionB(string mensaje)
        {
            _aeropuerto.enviarMensaje( this, mensaje );
        }

        public void setInstruccion(IAeroPuerto aeropuerto) { 
                _aeropuerto = aeropuerto;
        }

        public void respuestaB(string mensaje)
        {
            Console.WriteLine(mensaje);

        }
    }
}
