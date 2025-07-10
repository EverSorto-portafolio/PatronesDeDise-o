using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Producto
{
    public  class Auto : IVehiculo
    {
        public void start()
        {
            Console.WriteLine("Auto arrancando");
        }
        public void stop()
        {
            Console.WriteLine("Auto deteniendose");
        }
        public void manejar()
        {
            Console.WriteLine("Auto manejando");
        }
    }
   
}
