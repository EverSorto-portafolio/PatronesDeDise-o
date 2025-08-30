using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Iterator.NewFolder
{
    public  class Libro
    {
        public string  _title { get; set; }
        public string _autor { get; set; }

        public Libro(string title,string autor  ) {
         _autor = autor;
         _title = title;
        
        }
    }
}
