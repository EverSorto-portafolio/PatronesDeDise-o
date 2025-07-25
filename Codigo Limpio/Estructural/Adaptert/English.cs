using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter
{
    public class English : AdapterInterface
    {
        public string Answer(string respuesta)
        {
            return $"Answer in English: {respuesta}";
        }

        public string Ask(string pregunta)
        {
            return $"Ask in English: {pregunta}";
        }
    }
}
