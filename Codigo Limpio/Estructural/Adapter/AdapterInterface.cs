using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter
{
    public interface AdapterInterface
    {
        string Ask(string pregunta);
        string Answer(string respuesta);
    }
}
