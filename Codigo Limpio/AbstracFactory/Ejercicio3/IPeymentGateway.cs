using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejercicio3
{
    public  interface IPeymentGateway
    {

        bool isProcessPaymeny(decimal monto);

    }
}
