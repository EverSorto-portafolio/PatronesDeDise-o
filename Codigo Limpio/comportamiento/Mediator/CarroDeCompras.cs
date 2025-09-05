using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Mediator
{
    public  class CarroDeCompras
    {
        private Imediator _mediator;
        public CarroDeCompras(Imediator imediator)
        {
            _mediator = imediator;
        }

        public void SetMediator(Imediator imediator)
        {
            _mediator = imediator;
        }

        public void addItem(string item) {
            _mediator.Notify(this, item); // quien lo genera, quien lo notifica
        }
    }
}
