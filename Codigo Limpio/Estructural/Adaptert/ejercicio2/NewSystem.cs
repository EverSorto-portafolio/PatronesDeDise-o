using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Estructural.Adapter.ejercicio2
{
    public class NewSystem : IDATABASE
    {
        private readonly LegasyDatabase _legasyDatabase;
        public NewSystem(LegasyDatabase legasyDatabase)
        {
            _legasyDatabase = legasyDatabase;
        }
        public void Add(string data)
        {
            _legasyDatabase.InsertData(data);
        }

        public string Retrive()
        {
            return _legasyDatabase.GetData();
        }
    }
}
