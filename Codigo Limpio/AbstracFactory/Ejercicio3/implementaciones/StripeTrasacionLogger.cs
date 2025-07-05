using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejercicio3.implementaciones
{
    internal class StripeTrasacionLogger : TransacctionLogger
    {
        public void LoggearTransaccion(string mensaje)
        {
            Console.WriteLine($"Log de transacción Stripe: {mensaje}");
        }
    }
}
