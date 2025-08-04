using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Composite.Ejemplo1Composite
{
    public class AppFile : IfileSistem
    {
        private string _name;
        public AppFile(string name)
        {
            _name = name;
        }
        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent} " +
                $"- { this.GetType().Name} :" +
                $" {_name}");
        }
    }
}
