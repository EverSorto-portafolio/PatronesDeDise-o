using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Memento.ejemplo2
{
    public  class Repository
    {
        private Commit _estadoActual;

        public Repository(Commit estadoActual)
        {
            _estadoActual = estadoActual;
        }

        public void Save() {
           Git entorno =  new Git(_estadoActual);
            entorno.Commit();
        }

        public Commit Restore(Commit _estadoActual)
        {
             Git entorno = new Git(_estadoActual);
           return entorno.Revert(_estadoActual);
        }

    }
}
