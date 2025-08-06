using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Composite.Ejercicio3
{
    internal class RangoS : ICasador
    {
        private string _nombre;
        private string _codigo;
        private string _rango;

        private List<ICasador> _casadores;

        public RangoS()
        {
            _nombre = "";
            _codigo = "";
            _rango = "";
            _casadores = new List<ICasador>();
        }
        public void Rango(string rango)
        {
            _rango = rango;
        }

        public void Nombre(string nombre)
        {
            _nombre = nombre;
        }

        public void Codigo(string codigo)
        {
            _codigo = codigo;
        }

        public void  Mostrar()
        {
            Console.WriteLine($"Casador Novato: {_nombre}, Codigo: {_codigo}, Rango: {_rango}  fuente "); 
        }

        public void AgregarCasador(ICasador casador)
        {
            _casadores.Add(casador);
        }
        public void Recorrer() {
            Mostrar();

            foreach ( var item in _casadores  ) {
               item.Mostrar();
            }
        }
    }
}
