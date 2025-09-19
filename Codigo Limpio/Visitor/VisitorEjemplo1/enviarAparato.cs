using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Visitor.VisitorEjemplo1
{
    internal class enviarAparato : Itrabajo
    {
        public void repararCelular(Celular celular)
        {
            Console.WriteLine("Reparado y listo para enviar");
        }

        public void repararLaptop(Laptop laptop)
        {
            Console.WriteLine("Esperando pieza");
        }

        public void repararLicuadora(Licuadora licuadora)
        {
            Console.WriteLine("Se nos quebro el baso de la pieza, importando uno nuevo");
        }
    }
}
