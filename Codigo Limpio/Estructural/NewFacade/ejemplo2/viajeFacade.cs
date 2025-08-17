using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.NewFacade.ejemplo2
{
    public class viajeFacade
    {
        private Hotel _hotel;
        private Vuelo _vuelo;
        private RentaCar _rentaCar;
        private Dictionary<string, string> _plan;
        public viajeFacade(Dictionary<string, string> plan)
        {
            _plan = plan;
        }
        public void hotel(Hotel hotel)
        {
            _hotel = hotel;
        }
        public void vuelo(Vuelo vuelo)
        {
            _vuelo = vuelo;
        }
        public void rentaCar(RentaCar rentaCar)
        {
            _rentaCar = rentaCar;
        }
        public void planearViaje()
        {
            _hotel.reservarHabitacion(_plan["hotel"]);
            _vuelo.reservarVuelo(_plan["vuelo"]);
            _rentaCar.RentarAuto(_plan["auto"]);
        }


    }
}
