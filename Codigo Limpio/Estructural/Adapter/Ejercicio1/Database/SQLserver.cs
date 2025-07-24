using Codigo_Limpio.Estructural.Adapter.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.Ejercicio1.Database
{
    public class SQLserver
    {
        readonly Modeloos _modelo;
        public SQLserver(Modeloos modelo)
        {
            _modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
        }
        public void Consultar(string consulta)
        {
            Console.WriteLine($"La operacion {consulta} realizada en SQLServer");
            _modelo.Id = 1;
            _modelo.Nombre = "SQLServer ";

        }

        public object Respuesta()
        {
            return _modelo;
        }
    }

}
