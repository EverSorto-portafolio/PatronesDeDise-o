using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Composite.Ejemplo1Composite
{
    public class Folder : IfileSistem
    {
        private string _name;
        private List<IfileSistem> _children;

        public Folder(string name)
        {
            _name = name;
            _children = new List<IfileSistem>();
        }

        public void Item(IfileSistem item)
        {
            _children.Add(item);
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- Folder: {_name}");

            foreach (var item in _children)
            {
                item.Display(indent + "  ");
            }

        }
    }
}
