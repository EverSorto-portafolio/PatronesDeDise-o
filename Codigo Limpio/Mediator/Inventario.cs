using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Mediator
{
    public class Inventario
    {
        private Imediator _mediator;
        public Inventario(Imediator mediator)
        {
            _mediator = mediator;
        }
        public  void SetMediator(Imediator mediator)
        {
            _mediator = mediator;
        }
        public void NumeroItemActual(string item) {
            Console.WriteLine($"el numero de item es {item}");
        }
    }
}
