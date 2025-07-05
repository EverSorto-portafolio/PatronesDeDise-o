using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.AFEjemplo1.ClasesConcretas.LinuxTheme
{
    public class ButonLinux : IButton
    {
        public void Render()
        {
            Console.WriteLine("Renderizando un boton de Linux");
        }
    }
}
