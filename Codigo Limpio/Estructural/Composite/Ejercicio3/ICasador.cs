using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Composite.Ejercicio3
{
    public interface ICasador
    {

        void Rango(string rango);
        public void Nombre(string nombre);
        public void Codigo(string codigo);
        public void Mostrar();
    }
}
