using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Proxy.Ejercicio1
{
    public class CamaraProxy : ISegutiryCamara
    {
        private ISegutiryCamara _camara;
        private bool _autorizacion;
        Dictionary<string, object> _data;

        public CamaraProxy(Dictionary<string, object> acceso)
        {
            _data = acceso;
            Asignar();
        }
        public void ApagarCamara()
        {
            Console.WriteLine("Apagando camara");
        }

        public void DisplayCameraFeed()
        {
            Console.WriteLine("Proyectando Camara en vivo");
        }

        public void EncerderCamara()
        {
            Console.WriteLine("Encender Camara");
        }

        private void Asignar()
        {
            _camara = (ISegutiryCamara)_data["camara"];
            _autorizacion = (bool)_data["autorizacion"];
        }


        public void ValidarAcceso(Action function)
        {

            if (_autorizacion)
            {
                function();
            }
            else
            {
                Console.WriteLine("No tienes permiso para acceder a la camara");
            }

        }
    }
}
