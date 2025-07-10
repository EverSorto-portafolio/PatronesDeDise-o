using Codigo_Limpio.FactoryMethod.Ejercicio1.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Ejercicio1.implementacion
{
    public  class HotMailFactory : MensajeFactory
    {
        public override IMensaje CrearMensaje()
        {
            return new Hotmail();
        }
    }
}
