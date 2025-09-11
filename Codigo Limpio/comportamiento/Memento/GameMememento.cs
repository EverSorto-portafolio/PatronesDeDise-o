using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Memento
{
    public  class GameMememento
    {
        public Personaje _estado { get; set; }

        public GameMememento(Personaje estado)
        {
            _estado = estado;
        }


    }
}
