using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Mediator.ejercicio2
{
    public class Tower : IAtraficControl
    {
        private List<AirCraft> _aircraft = new List<AirCraft>();

        public void RegistroAir(AirCraft airCraft) {
            if ( !_aircraft.Contains(airCraft)) { // verifica si existe el elemeno dentro del arreglo
                _aircraft.Add(airCraft);
            }
        }
        public void senMenssage(AirCraft aircrat, string menssage)
        {
            foreach (AirCraft craft in _aircraft) {
                if (craft != aircrat) { 
                    aircrat.RecivedMensaje(menssage);
                }
            }
        }
    }
}
