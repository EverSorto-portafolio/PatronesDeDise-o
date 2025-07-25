using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter
{
    internal class Conversar
    {
        public void iniciar(AdapterInterface comunicar, string pregunta, string respuesta)
        {
            Console.WriteLine(comunicar.Ask(pregunta));
            Console.WriteLine(comunicar.Answer(respuesta));
        }
    }
}
