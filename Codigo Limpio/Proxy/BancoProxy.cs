using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Proxy
{
    public class BancoProxy : IBancoCuenta
    {
        private IBancoCuenta _cuenta;
      
        public BancoProxy( IBancoCuenta cuenta)
        {
            _cuenta = cuenta ?? throw new ArgumentNullException(nameof(cuenta), "La cuenta no puede ser nula.");
        }

       
        public void Depositar(decimal monto)
        {
           _cuenta.Depositar(monto);
        }

        public decimal ObtenerSaldo()
        {
            return _cuenta.ObtenerSaldo();
        }

        public void Retirar(decimal monto)
        {
            aprovar( monto);
        }

        private decimal aprovar(decimal monto) {
            if (_cuenta.ObtenerSaldo() < monto)
            {
                throw new InvalidOperationException("Saldo insuficiente para retirar el monto solicitado.");
            }
            else {
                _cuenta.Retirar(monto);
            }
             
            return _cuenta.ObtenerSaldo();
        }
    }
}
