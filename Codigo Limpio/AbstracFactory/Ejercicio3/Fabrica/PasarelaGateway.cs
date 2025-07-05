using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Ejercicio3.Fabrica
{
    public interface PasarelaGateway
    {
        IPeymentGateway CrearPasarela();
        TransacctionLogger CrearLogger();
    }
}
