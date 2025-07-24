using Codigo_Limpio.Estructural;
using Codigo_Limpio.Estructural.Adapter.Ejercicio1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.Ejercicio1.Consultar
{
    public class Consultar
    {
        public object sql(IDatabase consultar, string consulta)
        {
            consultar.Consultar(consulta);
            return consultar.Respuesta();
        }
    }
}
