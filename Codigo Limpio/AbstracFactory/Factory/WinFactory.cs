using Codigo_Limpio.AbstracFactory.ClasesConcretas.WindowsTheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Factory
{
    public class WinFactory : IThema
    {
        public IButton CreateButton()
        {
            return new ButonWindows();
        }

        public IListaDesplegable CreateListaDesplegable()
        {
            return new ListaDesplegableWin();
        }

        public Itexbox CreateTextBox()
        {
            return new TextBoxWindows();
        }
    }
}
