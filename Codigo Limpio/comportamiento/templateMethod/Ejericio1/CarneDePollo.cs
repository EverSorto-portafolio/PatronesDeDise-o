using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.templateMethod.Ejericio1
{
    public  class CarneDePollo : Receta
    {
        public override void Agua()
        {
            Console.WriteLine("Dos tasas de agua");
        }
        public override void Arroz()
        {
            Console.WriteLine("Tres tasas de arroz");
        }
        public override void CarneRes()
        {
            Console.WriteLine("Por cada media libra de pollo cocinar por 10  minutos fuego medio");
        }
        public override void Especias()
        {
            Console.WriteLine("Mostaza y sal");
        }
    }
}
