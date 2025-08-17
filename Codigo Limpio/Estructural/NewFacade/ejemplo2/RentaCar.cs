using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.NewFacade.ejemplo2
{
    public class RentaCar
    {
        public void RentarAuto(string describir)
        {
            Console.WriteLine($"Auto rentado: {describir}");
        }
        public string DevolverAuto(string describir)
        {
            return $"Auto devuelto: {describir}";
        }
        public string ConsultarDisponibilidad(string describir)
        {
            return $"Disponibilidad consultada: {describir}";
        }
    }
}