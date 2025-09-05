using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Memento
{
    public  class Juego
    {
        public Personaje estadoActual { get;  set; }

        public GameMememento SaveGame() {
            return new GameMememento(estadoActual);
        }

        public void cargarJuego(GameMememento memento) {
            estadoActual = memento._estado;
        }
    }
}
