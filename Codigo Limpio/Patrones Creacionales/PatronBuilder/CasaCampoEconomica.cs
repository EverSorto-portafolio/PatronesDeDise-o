using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.PatronBuilder
{
    public  class CasaCampoEconomica
    {
        private IModelo _modelo;

       public  CasaCampoEconomica(IModelo modelo)
        {
            _modelo = modelo;
        }

        public void ConstruirCasa()
        {
           
            _modelo.Cuarto(1);
            _modelo.Metros2(50);
            _modelo.Puertas(2);
        }

    }
}
