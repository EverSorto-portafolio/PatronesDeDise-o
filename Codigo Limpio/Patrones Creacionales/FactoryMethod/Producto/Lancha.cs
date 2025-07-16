using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Producto
{
    public class Lancha : IVehiculo
    {
        public void start()
        {
            Console.WriteLine("Lancha arrancando");
        }
        public void stop()
        {
            Console.WriteLine("Lancha deteniendose");
        }
        public void manejar()
        {
            Console.WriteLine("Lancha navegando");
        }
    }
  
}
