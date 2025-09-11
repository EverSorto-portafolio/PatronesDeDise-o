using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Memento
{
    public  class GameSaveManager
    {
        private List<GameMememento> _save = new List<GameMememento>();
        public void SaveGame(Juego juego) {
          _save.Add(juego.SaveGame());
        }

        public void loadGeme(Juego juego, int saveSlot) {
            juego.cargarJuego(_save[saveSlot]);
        }
    }
}
