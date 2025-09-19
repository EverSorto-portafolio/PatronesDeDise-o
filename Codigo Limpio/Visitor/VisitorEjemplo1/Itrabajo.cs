using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor.VisitorEjemplo1
{
    public interface Itrabajo
    {
        public void repararLaptop(Laptop laptop);
        public void repararCelular(Celular celular);
        public void repararLicuadora(Licuadora licuadora);
    }
}
