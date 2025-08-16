using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.NewFacade.ejemplo2
{
    public class Vuelo
    {
        public void reservarVuelo(string reserva) {
            Console.WriteLine( $"Vuelo reservado: {reserva}");
        }

        public void cancelarVuelo(string reserva)
        {
            Console.WriteLine( $"Vuelo cancelado: {reserva}");
        }
        public string consultarDisponibilidad(string reserva)
        {
            return $"Disponibilidad de vuelo consultada: {reserva}";
        }
    }
}
