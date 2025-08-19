using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Commend.Ejercicio1
{
    public class ControlNetFlix : IcommandTv
    {
        private SmartTv _smartTv;
        public ControlNetFlix(SmartTv smartTv)
        {
            _smartTv = smartTv;
        }
        public void executar()
        {
            _smartTv.OpenNetflix();
        }
    }
}
