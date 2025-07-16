using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Ejercicio2.Producto
{
    public class MensajeNotificacion : Inotificacion
    {
        public void enviar(string mensaje)
        {
             Console.WriteLine("Enviando notificación por Mensaje: " + mensaje);
        }
    }
}
