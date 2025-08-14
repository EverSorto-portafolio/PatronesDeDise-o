using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.NewFacade
{
    public class DvDPlayer
    {
        public void On()
        {
            Console.WriteLine("reproduccion desde DVD");
        }

        public void Off()
        {
            Console.WriteLine("detener reproduccion desde DVD");
        }


        public void PlayMovie(string movie)
        {
            Console.WriteLine($"Reproduccion desde {movie}");
        }

    }
}
