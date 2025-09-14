using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State.Ejemplo1
{
    public class Pagando : ImaquinaExpendedora
    {
        public void DispenseProducto()
        {
            Console.WriteLine("Debes pagar el producto");
        }

        public void PagarProducto(int pago)
        {
            Console.WriteLine($"Pago insertado {pago}");
        }

        public void SelecionarProducto(string producto)
        {
            Console.WriteLine($"Producto Selecionado {producto}");
        }
    }
}
