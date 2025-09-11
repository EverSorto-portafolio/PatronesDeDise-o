using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Observer
{
    public  interface Isubject
    {
        void RegistrarObservador( IObserver observador);
        void EliminarObservador(IObserver observador);
        void Notificar();
    }

}
