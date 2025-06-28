using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.PatronBuilder
{
    public  class Modelo
    {
        public int Puertas { get; set; }
        public int Cuarto { get; set; }
        public int Metros2 { get; set; }

        public void MostrarCasa() {
        Console.WriteLine
                ($"" +
                $"La casa tiene {Puertas}" +
                $" puertas, {Cuarto}" +
                $" cuartos y {Metros2} metros cuadrados.");
        }
    }
}
