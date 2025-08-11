using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Composite.Ejercicio3
{
    public class CasadorNovato : ICasador
    {
        private string _nombre;
        private string _codigo;
        private string _rango;

        public CasadorNovato()
        {
            _nombre = "";
            _codigo = "";
            _rango = "";
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


        public void Mostrar()
        {
            Console.WriteLine($"Casador Novato: {_nombre}, Codigo: {_codigo}, Rango: {_rango}");
        }

    }
}
