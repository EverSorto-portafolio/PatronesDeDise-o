using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.ClasesConcretas.LinuxTheme
{
    public class ListaDesplegableLinux : IListaDesplegable
    {
        public void Render()
        {
            Console.WriteLine("Renderizando Lista Desplegable en Linux");
        }
    }
   
}
