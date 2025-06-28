using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.PatronBuilder
{
    public  interface IModelo
    {
        Modelo GetModelo();
        void Puertas(int puertas);
        void Cuarto(int cuarto);
        void Metros2(int metros2);
    }
}
