using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Proxy.Ejercicio1
{
    public class implmentacionInterfaz : ISegutiryCamara

    {
        private string _hubicaiconCamra;
        public implmentacionInterfaz(string camara)
        {
            _hubicaiconCamra = camara;
        }
        public void ApagarCamara()
        {
            Console.WriteLine("apagando la camara");
        }

        public void DisplayCameraFeed()
        {
            Console.WriteLine("la camara esta transmitendo en vivo");
        }

        public void EncerderCamara()
        {
            Console.WriteLine("camara encendida");
        }
    }
}
