using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Observer
{
    public class Tv : IObserver
    {
        private ModeloTv _modeloTv;
        
        public void update(ModeloTv modeloTv)
        { 
            _modeloTv = modeloTv;
            display();
        }
        public void display() {
            Console.WriteLine($"  el tv es marca {_modeloTv.Marca} ademas tiene codigo de control {_modeloTv.control} segun el modelo {_modeloTv.modelo}");
        }

    }
}
