using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State.Ejemplo1
{
    public  interface ImaquinaExpendedora
    {
        void SelecionarProducto(string producto);
        void PagarProducto(int pago);
        void DispenseProducto();
    }
}
