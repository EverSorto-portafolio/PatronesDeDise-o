using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.ejercicio2
{
    public interface IDATABASE
    {
        void Add(string data);
        string Retrive();
    }
}
