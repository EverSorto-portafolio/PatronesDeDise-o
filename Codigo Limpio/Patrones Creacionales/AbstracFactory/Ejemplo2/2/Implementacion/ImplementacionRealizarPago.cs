using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago
{
    public class ImplementacionRealizarPago : IvalidadPago
    {
        private Usuario _usuario;
        private decimal _monto;
        public ImplementacionRealizarPago( Usuario usuario, decimal monto)
        {
            _usuario = usuario;
        }
        public void ValidarPago(Usuario usuario, decimal monto)
        {
            _monto = monto;
            realizarPago();
            Console.WriteLine($"Pago realizado con éxito. Saldo restante: {_usuario.Saldo}");
        }

        bool realizarPago() {

            if (_usuario.Saldo != 0  && _usuario.Saldo> _monto) { 
                _usuario.Saldo -= _monto;
                return true;
            }
            throw new Exception("Saldo insuficiente para realizar el pago.");

        }
    }
}
