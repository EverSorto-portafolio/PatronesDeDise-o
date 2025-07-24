using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.ejercicio2
{
    public class DataAdapterSQL : IDATABASE
    {
        public void Add(string data)
        {
            Console.WriteLine($"se realiza el llamado desde la clase antigua {data}");
        }

        public string Retrive()
        {
            return "se realiza el llamado desde la clase antigua";
        }
    }
}
