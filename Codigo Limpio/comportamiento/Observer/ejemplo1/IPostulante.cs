using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Observer.ejemplo1
{
    public  interface IPostulante
    {
        void Registrar(IObjeto objetos);
        void EliminarSuscripcion(IObjeto objetos);
        void notificar();
    }
}
