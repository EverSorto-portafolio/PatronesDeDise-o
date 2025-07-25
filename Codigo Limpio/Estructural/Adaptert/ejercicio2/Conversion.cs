using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.ejercicio2
{
    public class Conversion
    {
        public void add(IDATABASE bd, string mensaje)
        {
            bd.Add(mensaje);
        }
        public string retrive(IDATABASE bd)
        {
            return bd.Retrive();
        }
    }
}
