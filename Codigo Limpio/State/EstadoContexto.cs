using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State
{
    public class EstadoContexto
    {
        public IStado _estado { get; set; }
        public EstadoContexto()
        {
            _estado = new SemafornoEnVerde();
        }
        
        public void Request()
        {
            _estado.Handle(this);
        }

    }
}
