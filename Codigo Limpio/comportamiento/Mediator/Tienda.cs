using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Mediator
{
    public  class Tienda : Imediator
    {
        private Inventario _inventario;
        private CarroDeCompras _carroDeCompras;

        public Tienda(Inventario inventario, CarroDeCompras carroDeCompras)
        {

            _inventario = inventario;
            _carroDeCompras = carroDeCompras;
        }

        public void Notify(object sender, string eventCode)
        {
            if (sender is CarroDeCompras)
            {
                _inventario.NumeroItemActual(eventCode);
            }
        }
    }
}
