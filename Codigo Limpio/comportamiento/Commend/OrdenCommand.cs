using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Commend
{
    public class OrdenCommand : Icommand
    {
        private Order _order;
        public OrdenCommand(Order order)
        {
            _order = order;
        }
        public void execute()
        {

            _order.Orden();
        }
    }
}
