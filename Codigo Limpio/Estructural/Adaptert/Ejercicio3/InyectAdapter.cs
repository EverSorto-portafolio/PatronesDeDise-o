using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Ejercicio3
{
    public class InyectAdapter : IDB
    {
        private readonly ClaSeLegada _claSeLegada;
        public InyectAdapter( ClaSeLegada cl)
        {
            _claSeLegada = cl;
        }
        public void eliminar()
        {
           _claSeLegada.Eliminar();
        }

        public void guardar()
        {
            _claSeLegada.Guardar();
        }
    }
}
