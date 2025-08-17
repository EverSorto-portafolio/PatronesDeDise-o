using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.NewFacade.ejemplo2
{
    public class Hotel
    {
        public void reservarHabitacion(string descripcion)
        {
            Console.WriteLine($"Habitación reservada: {descripcion}");
        }
        public string cancelarReserva(string descripcion)
        {
            return $"Reserva cancelada: {descripcion}";
        }
        public string consultarDisponibilidad(string descripcion)
        {
            return $"Disponibilidad consultada: {descripcion}";
        }
    }
}
