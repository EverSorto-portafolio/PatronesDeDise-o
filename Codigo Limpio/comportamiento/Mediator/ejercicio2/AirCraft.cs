using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Mediator.ejercicio2
{
    public  abstract class AirCraft
    {
        protected IAtraficControl _atraficControl;
        protected string _name;

        protected AirCraft(IAtraficControl atraficControl, string name)
        {
            _atraficControl = atraficControl;
            _name = name;
            if ( _atraficControl is Tower concreteTower) {
                concreteTower.RegistroAir(this);
            }
        }

        public void SendMessage(string mensaje) { 
               _atraficControl.senMenssage(this, mensaje);
        }

        public void RecivedMensaje(string mensaje ) {

            Console.WriteLine($"{_name} recibe el mensaje: {mensaje}");
        }
    }
}
