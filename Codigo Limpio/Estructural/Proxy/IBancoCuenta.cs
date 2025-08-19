using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Proxy
{
    public interface IBancoCuenta
    {
        void Depositar(decimal monto);
        void Retirar(decimal monto);
        decimal ObtenerSaldo();
    }
}
