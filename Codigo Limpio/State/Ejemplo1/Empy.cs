using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State.Ejemplo1
{
    public class Empy : ImaquinaExpendedora
    {
        public void DispenseProducto()
        {
            Console.WriteLine("Sin producto espera que recargen");
        }

        public void PagarProducto(int pago)
        {
            Console.WriteLine("Sin producto devolviendo dinero");
        }

        public void SelecionarProducto(string producto)
        {
            Console.WriteLine("Sin producto");
        }
    }
}
