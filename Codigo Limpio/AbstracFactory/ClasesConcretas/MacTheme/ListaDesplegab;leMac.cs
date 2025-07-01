using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.ClasesConcretas.MacTheme
{
    public class ListaDesplegab_leMac : IListaDesplegable
    {
        public void Render()
        {
            Console.WriteLine("Renderizando Lista Desplegable en Mac");
        }
    }
}
