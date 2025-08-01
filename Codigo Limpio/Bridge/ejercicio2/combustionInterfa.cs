using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Bridge.ejercicio2
{
    public class combustionInterfa : IAuto
    {
        public void Acelerar()
        {
            Console.WriteLine("el auto de combustion interna arranca"); 
        }

        public void Apagar()
        {
            Console.WriteLine("el auto de combustion interna ");
        }

        public void Encender()
        {
            Console.WriteLine("El auto de combustion interna enciende");
        }

        public void Frenar()
        {
            Console.WriteLine("El auto de combustion interna frena");
        }
    }
}
