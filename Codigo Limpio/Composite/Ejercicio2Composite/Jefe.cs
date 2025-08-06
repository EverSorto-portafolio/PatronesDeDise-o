using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Composite.Ejercicio2Composite
{
    public class Jefe : IJerarquia
    {
        private string _nombre;
        private List<IJerarquia> _subordinados;

        public Jefe(string nombre)
        {
            _nombre = nombre;
            _subordinados = new List<IJerarquia>();
        }


        public void agregarSubordinado(IJerarquia subordinado)
        {
            _subordinados.Add(subordinado);
        }

        public void mostrar()
        {
            Console.WriteLine($" El trabaajor es {_nombre} de tipo {this.GetType()}");
        }

        public void recorrer() {
            foreach (var subordinado in _subordinados)
            {
                subordinado.mostrar();
            }
        }
    }
}
