using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Producto.Factory
{
    public class LanchaFactory : VehiculoFacroty
    {
        public override IVehiculo crearVehiculo()
        {
            return new Lancha();
        }
    }

}
