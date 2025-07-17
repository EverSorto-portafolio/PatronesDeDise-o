using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.EjemploPrototype1.prototipo1
{
    public abstract class ClonarEnemigos : IenemigoClone
    {
        public int Id { get; set; }
        public bool isTransform { get; set; }
        public string Name { get; set; }

        public abstract void LlamaEnemigo();
        public object clone()
        {
            return this.MemberwiseClone();
        }
    }
}
