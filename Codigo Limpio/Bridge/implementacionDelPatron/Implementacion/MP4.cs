using Codigo_Limpio.Bridge.implementacionDelPatron.ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Bridge.implementacionDelPatron.Implementacion
{
    public class MP4 : Iformat
    {
        public void play(string fillepath)
        {
            Console.WriteLine($" se reproduce el formato  mp4 desde {fillepath}");
        }
    }
}
