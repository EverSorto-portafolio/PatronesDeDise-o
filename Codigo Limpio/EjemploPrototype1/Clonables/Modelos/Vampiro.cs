using Codigo_Limpio.EjemploPrototype1.prototipo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.EjemploPrototype1.Clonables.Modelos
{
    public class Vampiro : ClonarEnemigos
    {
        //public int Id { get; set; }
        //public bool isTransform { get; set; }
        //public string Name { get; set; }

        public decimal puntosDevida { get; set; }
        public Vampiro()
        {
        }
        public void vida(decimal puntos) {
            puntosDevida = puntos;
        }
        public void Istransformation(bool isTransform)
        {
            this.isTransform = isTransform;
        }

        public void NameVampire(string name)
        {
            Name = name;
        }

        public override void LlamaEnemigo()
        {
            Console.WriteLine($"Propiedades nombre : {Name} , puntos de vida {puntosDevida}, se puedetrans formar { isTransform}");
        }
    }
}
