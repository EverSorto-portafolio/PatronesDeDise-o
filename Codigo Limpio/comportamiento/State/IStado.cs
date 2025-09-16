using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.State
{
    public interface IStado
    {
        void Handle(EstadoContexto context);
    }
}
