using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State.Ejemplo1
{
    public class Esperando : ImaquinaExpendedora
    {
        public void DispenseProducto()
        {
            Console.WriteLine("Seleciona un producto");
        }

        public void PagarProducto(int pago)
        {
            Console.WriteLine("Seleciona un producto");
        }

        public void SelecionarProducto(string producto)
        {
            Console.WriteLine($"producto selecionado {producto}");
        }
    }
}
