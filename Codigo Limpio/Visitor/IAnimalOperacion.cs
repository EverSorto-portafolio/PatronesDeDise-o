using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor
{
    public interface IAnimalOperacion
    {
      public void  VisitarLeon(Leon leon);
        public void VisitarMono(Mono mono);
    }

}
