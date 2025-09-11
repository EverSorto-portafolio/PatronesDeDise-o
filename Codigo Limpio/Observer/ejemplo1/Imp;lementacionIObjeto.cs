using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Observer.ejemplo1
{
    public class Imp_lementacionIObjeto : IObjeto
    {
        private Subasta _subasta;
     
        public void update(Subasta subasta)
        {
            _subasta = subasta;
            Ofertar(subasta.Oferta);
        }
        public void Ofertar(float oferta) {
            Console.WriteLine($"Nueva oferta {_subasta.Oferta}");
        }
    }
}
