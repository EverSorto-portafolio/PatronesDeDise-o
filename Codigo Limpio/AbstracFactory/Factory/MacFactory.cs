using Codigo_Limpio.AbstracFactory.ClasesConcretas.MacTheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.Factory
{
    public class MacFactory : IThema
    {
        public IButton CreateButton()
        {
            return new ButtonMac();
        }
        public IListaDesplegable CreateListaDesplegable()
        {
            return new ListaDesplegab_leMac();
        }
        public Itexbox CreateTextBox()
        {
            return new TextBoxMac();
        }
    }
    
}
