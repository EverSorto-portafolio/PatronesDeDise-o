using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Ejercicio1
{
    public abstract class MensajeFactory 
    {
        public abstract IMensaje CrearMensaje(); // metodo con el que crearemos los objetos

        public IMensaje Mostrar() {

            IMensaje mensaje = CrearMensaje(); // creamos el objeto
            mensaje.Correcto(); // llamamos al metodo correcto
            mensaje.Error(); // llamamos al metodo error
            mensaje.Informacion(); // llamamos al metodo informacion
            return mensaje; // retornamos el objeto creado
        }

    }
}
