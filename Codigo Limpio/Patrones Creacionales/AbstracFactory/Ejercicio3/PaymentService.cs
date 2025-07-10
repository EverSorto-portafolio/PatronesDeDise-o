using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using Codigo_Limpio.AbstracFactory.Ejercicio3.Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejercicio3
{
    public  class PaymentService

    {
        private readonly IPeymentGateway _gateway;
        private readonly TransacctionLogger _logger;

        public PaymentService(PasarelaGateway Ipey) {
            _gateway = Ipey.CrearPasarela();
            _logger = Ipey.CrearLogger();
            
        }
    }
}
