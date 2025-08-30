using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Iterator.NewFolder
{
    public class LibroIterados : IIterator<Libro>
    {
        public List<Libro> _libro { get; set; }
        public int _position  { get; set; }

        public LibroIterados(List<Libro> libro)
        {
            _libro = libro;
        }
        public bool MoveNext()
        {
            return _position < _libro.Count();
        }

        public Libro Next()
        {
            var book = _libro[_position];
            _position++;
            return book;
        }
    }
}
