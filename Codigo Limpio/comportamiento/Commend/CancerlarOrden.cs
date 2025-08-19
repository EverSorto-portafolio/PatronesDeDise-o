using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Commend
{
    public class CancerlarOrden : Icommand
    {
        private Order _order;
        public CancerlarOrden(Order order)
        {
            _order = order;
        }
        public void execute()
        {
            _order.CancelarOrden();
        }
    }
}
