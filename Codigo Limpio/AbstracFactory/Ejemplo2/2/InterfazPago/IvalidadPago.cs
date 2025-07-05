using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejemplo2._2.InterfazPago
{
    public interface IvalidadPago
    {
        void ValidarPago(Usuario usuario, decimal monto );
    }
}
