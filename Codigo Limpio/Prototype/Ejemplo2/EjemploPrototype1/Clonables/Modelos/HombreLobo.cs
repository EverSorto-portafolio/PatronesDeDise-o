using Codigo_Limpio.Prototype.Ejemplo2.EjemploPrototype1.prototipo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.Prototype.Ejemplo2.EjemploPrototype1.Clonables.Modelos
{
    public class HombreLobo : ClonarEnemigos
    {

        //public int Id { get; set; }
        //public bool isTransform { get; set; }
        //public string Name { get; set; }
        public bool lunaLlena { get; set; }
        public string Devilidad { get; set; }

        public string Ataque { get; set; }

        public void LunaLlena(bool lunaLlena)
        {
            this.lunaLlena = lunaLlena;
        }
        public void DevilidadHombreLobo(string devilidad)
        {
            Devilidad = devilidad;
        }
        public void AtaqueHombreLobo(string ataque)
        {
            Ataque = ataque;
        }
        public void isTransformacion(bool isTransform)
        {
            this.isTransform = isTransform;
        }
        public void NameHombreLobo(string name)
        {
            Name = name;
        }



        public override void LlamaEnemigo()
        {
            Console.WriteLine(
                $"Propiedades nombre : {Name} , " +
                $"luna llena {lunaLlena}, " +
                $"debilidad {Devilidad}," +
                $" ataque {Ataque}, " +
                $"se puede transformar {isTransform} "
            );
        }
    }
}
