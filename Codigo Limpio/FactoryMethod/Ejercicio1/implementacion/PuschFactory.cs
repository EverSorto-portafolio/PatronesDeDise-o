using Codigo_Limpio.FactoryMethod.Ejercicio1.interfaz;
using Codigo_Limpio.FactoryMethod.Ejercicio2.Producto;
using Codigo_Limpio.FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Ejercicio1.implementacion
{
    internal class PuschFactory : NotificationFactory
    {
        public override Inotificacion CrearNotificacion()
        {
            return new PushNotification();
        }
    }
}
