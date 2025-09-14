using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State.Ejemplo1
{
    public class Despachar : ImaquinaExpendedora
    {
        public void DispenseProducto()
        {
            Console.WriteLine("Soldato el producto");
        }

        public void PagarProducto(int pago)
        {
            Console.WriteLine($"Producto pago correcto {pago}");
        }

        public void SelecionarProducto(string producto)
        {
            Console.WriteLine($"Producto ya selecionado {producto}");
        }
    }
}

