using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.FactoryMethod.Ejercicio1.interfaz
{
    public  class GMail : IMensaje
    {
        public void Correcto()
        {
            Console.WriteLine("Mensaje enviado correctamente desde GMail.");
        }
        public void Error()
        {
            Console.WriteLine("Error al enviar el mensaje desde GMail.");
        }
        public void Informacion()
        {
            Console.WriteLine("Información enviada desde GMail.");
        }
    }
}
