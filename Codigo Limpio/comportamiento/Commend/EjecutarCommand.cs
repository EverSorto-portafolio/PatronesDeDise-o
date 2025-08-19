using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Commend
{
    public  class EjecutarCommand
    {
        public void Ejecutar(Icommand command)
        {
            command.execute();
        }
    }
}
