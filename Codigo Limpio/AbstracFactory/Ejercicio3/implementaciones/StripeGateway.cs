using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejercicio3.implementaciones
{
    public class StripeGateway : IPeymentGateway
    {
        public bool isProcessPaymeny(decimal monto)
        {
            Console.WriteLine($"Procesando pago de {monto} a traves de Stripe.");
            return true;
        }
    }
    
}
