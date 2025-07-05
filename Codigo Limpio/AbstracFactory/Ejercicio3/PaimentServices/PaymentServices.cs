using Codigo_Limpio.AbstracFactory.Ejercicio3.Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejercicio3.PaimentServices
{
    public class PaymentServices
    {
        private IPeymentGateway _pasarelaGateway;
        private TransacctionLogger _transacctionLogger;
        public PaymentServices( PasarelaGateway pasarela)
        {
            _pasarelaGateway = pasarela.CrearPasarela();
            _transacctionLogger = pasarela.CrearLogger();
        }

        public void ProcesarPago(decimal monto)
        {
            if (_pasarelaGateway.isProcessPaymeny(monto))
            {
                _transacctionLogger.LoggearTransaccion("Pago realizado");
            }
            else
            {
                _transacctionLogger.LoggearTransaccion("Pago no realizado");

            }

        }
    }
}
