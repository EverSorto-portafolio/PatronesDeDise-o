using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor.VisitorEjemplo1
{
    public class Reparacion : Itrabajo
    {
        public void repararCelular(Celular celular)
        {
            Console.WriteLine("Cambiar bateria");
        }

        public void repararLaptop(Laptop laptop)
        {
            Console.WriteLine("Cambiar teclado");
        }

        public void repararLicuadora(Licuadora licuadora)
        {
            Console.WriteLine("Cambiar baso y motor");
        }
    }
}
