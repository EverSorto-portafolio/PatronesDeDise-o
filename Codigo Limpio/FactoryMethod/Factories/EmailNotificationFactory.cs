using Codigo_Limpio.FactoryMethod.Ejercicio2.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Factories
{
    public class EmailNotificationFactory : NotificationFactory
    {
        public override Inotificacion CrearNotificacion()
        {
            return new EmailNotificacion();
        }
    }
}
