using Codigo_Limpio.Bridge.implementacionDelPatron.ejemplo1;
using Codigo_Limpio.Bridge.implementacionDelPatron.refinador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Bridge.implementacionDelPatron.ejecutor
{
    public class ReproductorAndroid : MusicPlayer
    {
        public ReproductorAndroid(Iformat iformat) : base(iformat)
        {
        }

        public override void play(string filePath)
        {
            Console.WriteLine("reproduccion desde Android");
            _iformat.play(filePath);
        }
    }
}
