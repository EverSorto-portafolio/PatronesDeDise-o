using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.AFEjemplo1
{
    public interface IThema
    {
        Itexbox CreateTextBox();
        IListaDesplegable CreateListaDesplegable();
        IButton CreateButton();
    }
}
