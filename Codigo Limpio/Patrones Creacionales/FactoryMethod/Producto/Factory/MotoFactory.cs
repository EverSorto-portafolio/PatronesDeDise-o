using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Producto.Factory
{
    internal class MotoFactory : VehiculoFacroty
    {
        public override IVehiculo crearVehiculo()
        {
            return new Moto();
        }
    }
}
