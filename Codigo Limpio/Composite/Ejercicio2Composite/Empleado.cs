using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Composite.Ejercicio2Composite
{
    public class Empleado : IJerarquia
    {
        private string _nombre;
        public Empleado( string nombre)
        {
            _nombre = nombre;
        }
        public void mostrar()
        {
            Console.WriteLine($"El trabaajor es {_nombre} de tipo {this.GetType()}");
        }
    }
}
