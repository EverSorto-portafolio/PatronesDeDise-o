using Codigo_Limpio.AbstracFactory.AFEjemplo1.ClasesConcretas.LinuxTheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.AFEjemplo1.Factory
{
    public class LinuxFactory : IThema
    {
        public IButton CreateButton()
        {
            return new ButonLinux();
        }

        public IListaDesplegable CreateListaDesplegable()
        {
            return new ListaDesplegableLinux();
        }

        public Itexbox CreateTextBox()
        {
            return new TextBoxLinux();
        }
    }
}
