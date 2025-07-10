using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod
{
    public  interface IVehiculo
    {
        public void start();
        public void stop();
        public void manejar();
    }
}
