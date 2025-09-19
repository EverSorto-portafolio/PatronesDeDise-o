using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.templateMethod
{
    public class Computacion : Reclutar
    {
        public override void Entrevista()
        {
            Console.WriteLine("Realizando entrevistas tecnicas");
        }

        public override void IssueOffer()
        {
            Console.WriteLine(" afreciendo el trabajo  "); 
        }

        public override void ReciveCV()
        {
            Console.WriteLine("Recibe el curriculo");
        }

        
    }
}
