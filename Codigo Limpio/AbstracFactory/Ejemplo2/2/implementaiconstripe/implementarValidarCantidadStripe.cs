using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2.implementaiconstripe
{
    internal class implementarValidarCantidadStripe : ValidadCantidad
    {
        private readonly Usuario _usuario;
        public implementarValidarCantidadStripe(Usuario usuario)
        {
            _usuario = usuario;
        }
        public decimal ValidadCantidad(Usuario usuario)
        
        {
            decimal monto = 0;
           Console.WriteLine("Validando cantidad en Stripe para el usuario: " + usuario.user);

            string cantidad = Console.ReadLine();
            if (decimal.TryParse(cantidad, out monto)) {
                Console.WriteLine(monto);
                return monto;
            }

            return 0;
        }
    }
}
