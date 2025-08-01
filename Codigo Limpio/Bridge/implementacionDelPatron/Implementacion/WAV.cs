using Codigo_Limpio.Bridge.implementacionDelPatron.ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Bridge.implementacionDelPatron.Implementacion
{
    internal class WAV : Iformat
    {
        public void play(string fillepath)
        {
            Console.WriteLine($" se reproduce el formato  mwv desde {fillepath}");
        }
    }
}
