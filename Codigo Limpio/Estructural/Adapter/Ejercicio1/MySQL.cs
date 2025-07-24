using Codigo_Limpio.Estructural.Adapter.Ejercicio1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.Ejercicio1
{
    public class MySQL : IDatabase
    {
        private readonly Modeloos _modelo;
        public MySQL(Modeloos modelo)
        {
            _modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
        }
        public void Consultar(string consulta)
        {
            Console.WriteLine($"La operacion {consulta} realizada en Mysql");
            _modelo.Id = 1;
            _modelo.Nombre = "MySQL Database";

        }

        public object Respuesta()
        {
            return _modelo;
        }
    }
}
