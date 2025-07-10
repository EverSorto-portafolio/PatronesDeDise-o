using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Producto
{
    public class Moto : IVehiculo
    {
        public void start()
        {
            Console.WriteLine("Moto arrancando");
        }
        public void stop()
        {
            Console.WriteLine("Moto deteniendose");
        }
        public void manejar()
        {
            Console.WriteLine("Moto manejando");
        }
    }
   
}
