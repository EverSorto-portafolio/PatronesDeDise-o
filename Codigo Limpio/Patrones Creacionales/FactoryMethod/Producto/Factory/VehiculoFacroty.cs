using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Producto.Factory
{
    public abstract class VehiculoFacroty
    {
        public abstract IVehiculo crearVehiculo();

        public IVehiculo Transprote() { 
        
        IVehiculo vehiculo = crearVehiculo();
            vehiculo.start();
            vehiculo.manejar();
            vehiculo.stop();
            return vehiculo;
        }

    }
}
