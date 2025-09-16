using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Strategy.EjercicioStrategy
{
    public class ContexroTransporte
    {
        private Itransporte _contexto;

        public ContexroTransporte(Itransporte contexto)
        {
            _contexto = contexto;
        }

        public void SelecionarTransporte(Itransporte contexto) {
            _contexto = contexto;
        }

        public string ejecutarTransporte(float pasaje) {
            return _contexto.metodoDeTRansporte(pasaje);
        }

        
    }
}
