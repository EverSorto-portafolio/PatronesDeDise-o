using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Mediator.ejercicio1
{
    public  class AvionAeropuerto
    {
        private IAeroPuerto _aeropuerto;

        public AvionAeropuerto()
        {
            
        }

        public void OperacionA(string mensaje) {
            _aeropuerto.enviarMensaje(this, mensaje);
        }

        public void respuestaA(string mensaje) {
            Console.WriteLine(mensaje );
        
        }

        public void setInstruccion(IAeroPuerto aeropuerto)
        {
            _aeropuerto = aeropuerto;
        }
    }
}
