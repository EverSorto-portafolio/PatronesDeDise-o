using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.PatronBuilder
{
    public class Plano : IModelo

    {
       private  Modelo _modelo = new Modelo();
        public void Cuarto(int cuarto)
        {
           _modelo.Cuarto = cuarto;
        }
        public void Metros2(int metros2)
        {
            _modelo.Metros2 = metros2;
        }
        public Modelo GetModelo()
        {
            return _modelo;
        }
        public void Puertas(int puertas)
        {
            _modelo.Puertas = puertas;
        }
    }
}
