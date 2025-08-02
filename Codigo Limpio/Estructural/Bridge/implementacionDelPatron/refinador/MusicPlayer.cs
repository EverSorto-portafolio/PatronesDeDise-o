using Codigo_Limpio.Estructural.Bridge.implementacionDelPatron.ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Bridge.implementacionDelPatron.refinador
{
    public abstract class MusicPlayer
    {
        protected Iformat _iformat;
        protected MusicPlayer(Iformat iformat)
        {
            _iformat = iformat;
        }

        public abstract void play(string filePath);
    }
}
