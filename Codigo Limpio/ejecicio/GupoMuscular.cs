using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.ejecicio
{
    public class GupoMuscular
    {
        public bool Pecho { get; set; }
        public bool Espalda { get; set; }
        public bool Pierna { get; set; }
        public bool Hombro { get; set; }
        public bool Bicep { get; set; }
        public bool Tricep { get; set; }
        public bool Abdominal { get; set; }

        public void MostrarGrupoMuscular()
        {
            Console.WriteLine("Grupo Muscular:");
            Console.WriteLine($"Pecho: {Pecho}");
            Console.WriteLine($"Espalda: {Espalda}");
            Console.WriteLine($"Pierna: {Pierna}");
            Console.WriteLine($"Hombro: {Hombro}");
            Console.WriteLine($"Bicep: {Bicep}");
            Console.WriteLine($"Tricep: {Tricep}");
            Console.WriteLine($"Abdominal: {Abdominal}");
        }

    }
}
