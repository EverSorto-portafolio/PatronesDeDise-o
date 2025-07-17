using Codigo_Limpio.EjemploPrototype1.prototipo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.EjemploPrototype1.Clonables.Modelos
{
    public class Vampiro : Implementar_EnemigoClone
    {
        public string  Ataque { get; set; }
        public decimal vida { get; set; }

        public void ataque(string explicarAtaque) { 
            Ataque = explicarAtaque;
        }
        public void vidaVampiro( decimal vidaInicial) {
            vida = vidaInicial;
        }


        public override void LlamaEnemigo()
        {
            return Vampiro this.MemberwiseClone();
        }
    }
}
