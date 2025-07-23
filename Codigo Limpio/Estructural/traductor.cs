using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural
{
    public  class traductor : AdapterInterface
    {
        private readonly Epanish _espanol;

        public traductor(Epanish espanol)
        {
            _espanol = espanol;
        }

        public string Answer(string respuesta)
        {
           return _espanol.Answer(respuesta);
        }

        public string Ask(string pregunta)
        {
            return _espanol.Ask(pregunta);
        }
    }
}
