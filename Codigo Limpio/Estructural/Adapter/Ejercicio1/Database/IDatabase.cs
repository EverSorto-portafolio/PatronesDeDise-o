using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.Ejercicio1.Database
{
    public interface IDatabase
    {
        object Respuesta();
        void Consultar(string consulta);
    }
}
