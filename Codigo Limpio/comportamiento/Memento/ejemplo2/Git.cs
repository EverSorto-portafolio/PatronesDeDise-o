using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Memento.ejemplo2
{
    public  class Git
    {
        private List<Commit> _commits = new List<Commit>();
        Commit _commit;
        public Git(Commit commit)
        {
           _commit = commit; 
        }
        public void Commit() {
            if (!Exist())
            {
                _commits.Add(_commit);
            }
            else { 
                Console.WriteLine("Guardado correctamente");
            }
                
        }
        public void Borrar() {
            if (Exist()) {
                _commits.Remove(_commit);
            }
            Console.WriteLine("Algo salio mal revisa la informacion");
        }

        private bool Exist() {
            return _commits.Any(code => code.Code == _commit.Code);
        }

        public Commit Revert(Commit commit) {
           
          return _commits.FirstOrDefault(code => code.Code == commit.Code) ?? throw new Exception("Error retorno un null");  
        }
    }
}
