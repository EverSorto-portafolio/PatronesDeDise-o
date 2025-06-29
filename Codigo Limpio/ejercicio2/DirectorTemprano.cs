using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.ejercicio2
{
    public class DirectorTemprano
    {
        public void temprano(ComidaDeMama comida) { 
            comida.Pan("Tostado con queso derretido");
            comida.Tortilla("Sin tortillas");
            comida.Lechuga("Ensalada fresca");
            comida.Tomate("Salsa de tomate para el arroz y carne");
            comida.Papas("Papas fritas crujientes");
            comida.Cebolla("Cebolla caramelizada");
            comida.Queso("Queso cheddar rallado");
            comida.Carne("Carne molida sazonada");
            comida.Tocino("Sin tocino");
            comida.Pollo("Sin pollo");
            Console.WriteLine("Comida temprana receta lista:");
        }
    }
}
