using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.ClasesConcretas.MacTheme
{
    public class ButtonMac : IButton
    {
        public void Render()
        {
            Console.WriteLine("Renderizando Button en Mac");
        }
    }
}
