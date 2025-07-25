using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.ejercicio2
{
    public class LegasyDatabase
    {
        public void InsertData(string data)
        {
            Console.WriteLine($"se realiza el llamado desde la clase nueva a la antigua {data}");
        }

        public string GetData()
        {
            return "se realiza el llamado desde la clase nueva a la clase antigua";
        }
    }
}
