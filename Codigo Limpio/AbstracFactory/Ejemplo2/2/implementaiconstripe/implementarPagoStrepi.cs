using Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2.implementaiconstripe
{
    public class implementarPagoStrepi : IvalidadPago
    {
     
        private  decimal _monto;
  
        public void ValidarPago(Usuario usuario, decimal monto)
        {
            if (usuario.Saldo < monto) { 
                Console.WriteLine("Saldo insuficiente para realizar el pago de " + _monto + " para el usuario: " + usuario.user);
            }
            if (usuario.Saldo > monto) { 
               Console.WriteLine("Pago realizado con éxito de " + _monto + " para el usuario: " + usuario.user);
                usuario.Saldo -= monto;
            }

            
        }

       
    }
}
