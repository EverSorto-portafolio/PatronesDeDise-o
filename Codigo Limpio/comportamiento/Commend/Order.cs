using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Commend
{
    public class Order
    {
        public void Orden() {
            Console.WriteLine("Orden de compra realizada");
        }

        public void CancelarOrden() {
            Console.WriteLine("La orden fue Cancelada");
        }
    }
}
