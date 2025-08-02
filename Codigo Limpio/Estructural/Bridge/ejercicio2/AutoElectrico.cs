using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Bridge.ejercicio2
{
    public class AutoElectrico : IAuto
    {
        public void Acelerar()
        {
            Console.WriteLine("El auto de Electrico interna Acelerar");
        }

        public void Apagar()
        {
            Console.WriteLine("El auto de Electrico interna Apagar");
        }

        public void Encender()
        {
            Console.WriteLine("El auto de Electrico interna Encender");
        }

        public void Frenar()
        {
            Console.WriteLine("El auto de Electrico interna frena");
        }
    }
}
