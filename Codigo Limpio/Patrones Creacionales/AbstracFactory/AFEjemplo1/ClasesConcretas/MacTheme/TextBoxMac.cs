﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.AbstracFactory.AFEjemplo1.ClasesConcretas.MacTheme
{
    public class TextBoxMac : Itexbox
    {
        public void Render()
        {
            Console.WriteLine("Renderizando TextBox en Mac");
        }
    }
}
