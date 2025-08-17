using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Proxy
{
    
    public class Cuenta : IBancoCuenta
    {
        public decimal  _balance;
        public Cuenta( decimal  balance)
        {
            _balance = balance;
        }
        public void Depositar(decimal monto)
        {

            _balance += monto;
        }

        public decimal ObtenerSaldo()
        {
            return _balance;    
        }

        public void Retirar(decimal monto)
        {
           _balance =  _balance >= monto ? 
                _balance - monto : throw new InvalidOperationException("Saldo insuficiente para retirar el monto solicitado.");
        }


    }
}
