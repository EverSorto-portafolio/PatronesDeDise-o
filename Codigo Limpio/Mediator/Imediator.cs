using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Mediator
{
    public  interface Imediator
    {
        void Notify(object sender, string eventCode);
    }
}
