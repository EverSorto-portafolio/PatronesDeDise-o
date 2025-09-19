using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.templateMethod
{
    public class Banco : Reclutar
    {
        public override void Entrevista()
        {
            Console.WriteLine("Verificando habilidades descritas en el curriculo (habilidades blandas");
        }

        public override void IssueOffer()
        {
            Console.WriteLine("Procesando la oferta");
        }

        public override void ReciveCV()
        {
            Console.WriteLine("Recivido");
        }

        public override void EntrevistaTeorica()
        {
            Console.WriteLine("Realizando entrevista teorica");
        }
    }
    }
