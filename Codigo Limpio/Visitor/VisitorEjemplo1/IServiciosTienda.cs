using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor.VisitorEjemplo1
{
    public interface IServiciosTienda
    {
        // Aqui se colocara un conector entre las calses 
        public void trabajo( Itrabajo trabajo);
    }
}
