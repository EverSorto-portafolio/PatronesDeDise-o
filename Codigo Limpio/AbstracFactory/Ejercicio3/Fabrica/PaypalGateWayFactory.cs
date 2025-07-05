using Codigo_Limpio.AbstracFactory.Ejercicio3.implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejercicio3.Fabrica
{
    public class PaypalGateWayFactory : PasarelaGateway
    {
        public TransacctionLogger CrearLogger()
        {
            return new PaypalTransactionLogger ();
        }

        public IPeymentGateway CrearPasarela()
        {
            return new PaypalGateway();
        }
    }
}
