using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Codigo_Limpio.Mediator.NewFolder
{
    public  class TorreDeControl : IAeroPuerto
    {
        private AirBus _airbus;
        private AvionAeropuerto _avionAeropuerto;

        public TorreDeControl(AirBus airbu, AvionAeropuerto avionAeropuerto)
        {
            _airbus = airbu;
            _avionAeropuerto = avionAeropuerto;
        }

        public void enviarMensaje(object enviar, string mensaje)
        {
            if (enviar is AirBus) {
                _avionAeropuerto.respuestaA($"Airbus {mensaje}");
            }if (enviar is AvionAeropuerto ) {
                _airbus.respuestaB($"Boig solicita {mensaje}");
            }  
        }
    }
}
