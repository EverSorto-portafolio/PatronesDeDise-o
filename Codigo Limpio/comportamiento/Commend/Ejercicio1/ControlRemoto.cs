using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Commend.Ejercicio1
{
    public  class ControlRemoto 
    {
        public void IcommandTv(IcommandTv command)
        {
            command.executar();
        }
    }
}
